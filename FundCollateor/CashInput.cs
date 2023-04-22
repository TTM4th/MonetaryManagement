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
    public partial class CashInput : UserControl
    {

        private Dictionary<int, NumericUpDown> eachinput;

        public CashInput()
        {
            InitializeComponent();
            eachinput = new Dictionary<int, NumericUpDown>{ {1,this.numericUpDown_1yen },
                                                            {5,this.numericUpDown_5yen },
                                                            {10,this.numericUpDown_10yen },
                                                            {50,this.numericUpDown_50yen },
                                                            {100,this.numericUpDown_100yen },
                                                            {500,this.numericUpDown_500yen },
                                                            {1000,this.numericUpDown_1000yen },
                                                            {5000,this.numericUpDown_5000yen },
                                                            {10000,this.numericUpDown_10000yen }
                                                        };
        }

        /// <summary>
        /// メソッド呼び出し時に各NumericUPDownコントロールに入力した値から現金を計算する
        /// </summary>
        /// <returns>所持金（現金）</returns>
        internal decimal CalcInputValue() {
            //NumericUpDownコントロールの入力値が0の場合は変更前の値が残るという仕様を回避するため
            //敢えて0をセットする措置を行っている
            foreach (var obj in eachinput.Where(x => string.IsNullOrEmpty(x.Value.Text))) {
                obj.Value.Value = 0;
            };
            //処理数を減らすため、入力値0のNumericUPDownの計算は省く
            return eachinput.Where(x => x.Value.Value > 0).Select(x => x.Key * x.Value.Value).Sum();
        }

    }
}
