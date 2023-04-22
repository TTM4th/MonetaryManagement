using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundCollator
{
    public partial class EmoneyInput : UserControl
    {
        public EmoneyInput()
        {
            InitializeComponent();
        }

        private void emoney_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b'){ return;}
            //数値0～9以外が押された時はイベントをキャンセルする
            if (e.KeyChar < '0' || '9' < e.KeyChar){e.Handled = true;}

        }

        /// <summary>
        /// メソッド呼び出し時にemoney_textboxに入力した値をdecimal型で取得する
        /// </summary>
        /// <returns></returns>
        internal decimal GetInputValue() {
            string input_value = this.emoney_textBox.Text;
            if (string.IsNullOrEmpty(input_value)) { return 0; }
            else { return Convert.ToDecimal(input_value); }
        }
        
    }
}
