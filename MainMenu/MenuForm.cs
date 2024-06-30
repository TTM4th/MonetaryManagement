﻿using DBConnector.Accessor;
using DBConnector.Data;
using DBConnector.Service;
using System;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();

            _service = new MenuFormService(
                new MonthlyFundData(new MonetaryManagementDataAdapter()),
                new MoneyUsedData(new MonetaryManagementDataAdapter()));
            if (!_service.IsExistFirstBalance())
            {
                _service.InsertFromPreviousMonth();
            }
            if (!_service.IsExistMonetaryTable())
            {
                _service.CreateMonetaryTable();
            }

            //更新処理アクションで行いたい処理を具体実装する
            this.ReflectNowBalance =
               () =>
               {
                   var model = _service.CreateViewModel();
                   this.TableNameComboBox.DataSource = model.MonthlyTableNames;
                   this.NowBalanceValue = model.CurrentBalance;
                   this.NowBalanceLabel.Text = this.NowBalanceValue.ToString();
                   this.NowBalanceLabel.Update();
               };
        }

        private readonly MenuFormService _service;

        /// <summary>
        /// 更新処理アクション
        /// </summary>
        private Action ReflectNowBalance;

        /// <summary>
        /// 現在金額（10進数型）
        /// </summary>
        private decimal NowBalanceValue;

        private void Form1_Load(object sender, EventArgs e)
        {
            TableNameComboBox.SelectedIndex = 0;
            this.ReflectNowBalance();
        }

        private void RunFundRegister_Click(object sender, EventArgs e)
        {
            FundRegister.FrontEnd.RegisterFormAccessor.RunRegisterForm((string)TableNameComboBox.SelectedItem);
            this.Show();
            this.ReflectNowBalance();
        }

        private void Button_Run_collator_Click(object sender, EventArgs e)
        {
            FundCollator.FrontEnd.FundCollatorFormAccessor.RunFundCollatorForm(this.NowBalanceValue);
            this.Show();
            this.ReflectNowBalance();
        }

        private void TableNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.sumByClassBox.RelfectFromUsedData((string)TableNameComboBox.SelectedItem);
            this.ReflectNowBalance();
        }
    }
}
