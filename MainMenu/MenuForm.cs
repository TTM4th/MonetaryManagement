using DBConnector.Accessor;
using DBConnector.Data;
using DBConnector.Model;
using DBConnector.Service;
using System;
using System.Linq;
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
            // MonthlyFundテーブルが存在しない場合は作成・初期化する
            if (!_service.IsExistMonthlyFundTable())
            {
                _service.CreateMonthlyFundTable();
            }
            // 初期残高データが存在しない場合
            if (!_service.IsExistFirstBalance())
            {
                var insertPrice = 0m;

                var recentInitialBalance = _service.RecentInitialBalance;
                if (recentInitialBalance.HasValue)
                {
                    // 直近の初期残高が存在する場合は、現在年月の1か月前の月別テーブル内に登録された利用金額合計値を引いた値を当月の初期残高として登録する
                    insertPrice = recentInitialBalance.Value - _service.GetMonthlySumPrice(_service.MonthlyTableNames.First());
                }
                else
                { 
                    // 直近の最新残高が存在しない場合（初回起動時を想定）は、初期残高入力モーダル経由でユーザに初期残高を入力してもらう
                    using (var form = new NumericInputForm())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            insertPrice = (decimal)form.Result;
                        }
                    }
                }

                _service.InsertMonthlyFundRecord(insertPrice);
            }
            if (!_service.IsExistMonetaryTable())
            {
                // 現在年月の月別テーブルが存在しない場合は、作成・初期化する
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
