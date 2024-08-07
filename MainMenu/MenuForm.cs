﻿using DBConnector.Accessor;
using DBConnector.Data;
using DBConnector.Model;
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
                new MoneyUsedData(new MonetaryManagementDataAdapter())
                );
            if (!_service.IsExistMonthlyFundTable())
            {
                _service.CreateMonthlyFundTable();
            }
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
                   this.NowBalanceValue = _model.CurrentBalance;
                   this.NowBalanceLabel.Text = this.NowBalanceValue.ToString();
                   this.NowBalanceLabel.Update();
               };
            this.RelfectSumByClass = () =>
            {
                var year_mm = TableNameComboBox.SelectedItem.ToString().Split("-");
                _model.MoneyUsedData = _service.LoadSumPricesByClassification(year_mm[0], year_mm[1]);
                this.sumByClassBox.RelfectFromUsedData(_model.MoneyUsedData);
            };
        }

        private readonly MenuFormService _service;

        private MenuFormModel _model;

        /// <summary>
        /// 更新処理アクション
        /// </summary>
        private Action ReflectNowBalance;

        /// <summary>
        /// 区分別集計値ビュー更新アクション
        /// </summary>
        private Action RelfectSumByClass;

        /// <summary>
        /// 現在金額（10進数型）
        /// </summary>
        private decimal NowBalanceValue;

        private void Form1_Load(object sender, EventArgs e)
        {
            _model = _service.CreateViewModel();
            this.TableNameComboBox.DataSource = _model.MonthlyTableNames;
            TableNameComboBox.SelectedIndex = 0;
            this.ReflectNowBalance();
        }

        private void RunFundRegister_Click(object sender, EventArgs e)
        {
            FundRegister.FrontEnd.RegisterFormAccessor.RunRegisterForm((string)TableNameComboBox.SelectedItem);
            this.Show();

            _model.CurrentBalance = _service.GetCurrentBalance();
            this.ReflectNowBalance();

            this.RelfectSumByClass();

        }

        private void Button_Run_collator_Click(object sender, EventArgs e)
        {
            FundCollator.FrontEnd.FundCollatorFormAccessor.RunFundCollatorForm(this.NowBalanceValue);
            this.Show();
        }

        private void TableNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.RelfectSumByClass();
        }
    }
}
