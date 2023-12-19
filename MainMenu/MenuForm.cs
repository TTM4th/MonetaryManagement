using MainMenu.Controller;
using System;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            DataController = new DataController();
            this.TableNameComboBox.DataSource = DataController.MonthlyTableNames;
            //更新処理アクションで行いたい処理を具体実装する
            this.ReflectNowBalance = 
               () => {
                    this.NowBalanceValue = DataController.GetCurrentBalance();
                    this.NowBalanceLabel.Text = this.NowBalanceValue.ToString();
                    this.NowBalanceLabel.Update();
                    };
        }

        private DataController DataController { get; }
        //更新処理アクション
        private Action ReflectNowBalance;
        //現在金額（10進数型）
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
        }
    }
}
