using System;
using System.Windows.Forms;

namespace FundCollator
{
    public partial class FundCollatorFrom : Form
    {
        private decimal NowBalance;

        public FundCollatorFrom()
        {
            InitializeComponent();
        }

        internal FundCollatorFrom(decimal nowbalance)
        {
            InitializeComponent();
            this.NowBalance = nowbalance;
            this.label_from_db.Text = this.NowBalance.ToString();
        }

        private void Button_calc_Click(object sender, EventArgs e)
        {
            decimal inputtedCash = this.emoneyInput1.GetInputValue() + this.cashInput.CalcInputValue();
            this.label_cash.Text = inputtedCash.ToString();
            this.label_diff.Text = string.Empty;
            if (inputtedCash != this.NowBalance)
            {
                decimal diff = inputtedCash - NowBalance;
                this.label_diff.Text = diff.ToString();
            }
        }
    }
}
