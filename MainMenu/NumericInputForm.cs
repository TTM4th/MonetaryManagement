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

        // ���l�̂ݓ��͋���
        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // OK�{�^���������̏���
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
                MessageBox.Show("1�ȏ�̐��l����͂��Ă��������B", "���̓G���[", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TextBox.Focus();
            }
        }
    }
}
