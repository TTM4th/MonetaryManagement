using System;
using System.Windows.Forms;

namespace MainMenu
{ 
    public partial class NumericInputForm : Form
    {
        public decimal Result { get; private set; }

        public NumericInputForm()
        {
            InitializeComponent();
            this.TextBox.Focus();
        }

        // 数値のみ入力許可
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // OKボタン押下時の処理
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(TextBox.Text, out decimal value) && value > 0)
            {
                Result = value;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("1以上の数値を入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBox.Focus();
            }
        }
    }
}
