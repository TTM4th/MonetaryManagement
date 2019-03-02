using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetaryManagement.File
{
    class Data
    {
        /// <summary>
        /// 日付
        /// </summary>
        public List<string> Date{set; get;}
        /// <summary>
        /// 金額（日別）
        /// </summary>
        public List<decimal> Money { set; get; }
        /// <summary>
        /// 分類種類
        /// </summary>
        private enum Classification
        {Unchin=1,Inshoku,NhichiYouhin,Goraku,Irui,Shoumouhin,Service,MiBunrui}
        /// <summary>
        /// 分類
        /// </summary>
        public List<int> Bunrui { set; get; }
        private bool isfirst;

        Data()
        {
            isfirst=true;
        }
        /// <summary>
        /// 1レコード分のデータレイアウト分け
        /// </summary>
        /// <param name="oneRecord">テキストの1レコード文字列（CSV形式）</param>
        private void SetData(string oneRecord)
        {
            string[] arr = oneRecord.Split(',');
            Date.Add(arr[0]);
            Money.Add(Convert.ToDecimal(arr[1]));
            Bunrui.Add(Convert.ToInt32((Classification)Enum.ToObject(typeof(Classification),Convert.ToInt32(arr[2]))));
        } 
    }
}
