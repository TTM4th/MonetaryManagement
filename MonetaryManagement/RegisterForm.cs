using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonetaryManagement
{
    public partial class RegisterForm : Form
    {

        #region "内部変数"
        /// <summary>
        /// 使用した金額あたりの情報構造体
        /// </summary>
        private struct OneRecordData
        {
           public string PaidDate;
           public decimal Price;
           public string Classification;
        }
        /// <summary>
        /// 現在入力中の情報を保有するプロパティ変数
        /// </summary>
        private OneRecordData _NowRecordData;
        /// <summary>
        /// 現在入力中の情報を保有するプロパティ
        /// </summary>
        private OneRecordData NowRecordData {get{return _NowRecordData;} }
        /// <summary>
        /// 項目リストボックス用文字列ソース
        /// </summary>
        private Dictionary<string,string> ClassificationDicitonary
        {
            get
            {
                return new Dictionary<string, string> { {"1", "運賃"},
                                                        { "2","飲食費" },
                                                        { "3","日用品・家電"},
                                                        { "4","娯楽" },
                                                        { "5","衣類" } ,
                                                        {"6","消耗品" },
                                                        { "7","サービス費"},
                                                        { "?","未分類"} };
            }
        }
        /// <summary>
        /// GridViewの支払い日付欄の日付を取得・設定する
        /// </summary>
        private string PaidDate_gv
        {
            get{var tmp = InputGridView.Rows[TargetIndex()].Cells[0].Value;
                if (tmp == null) { return string.Empty; }
                else { return tmp.ToString(); }
            }
            set{ InputGridView.Rows[TargetIndex()].Cells[0].Value = value;}
        }
        /// <summary>
        /// GridViewの区分欄の日付を取得・設定する
        /// </summary>
        private string Classification_gv
        {
            get { var tmp= InputGridView.Rows[TargetIndex()].Cells[2].Value;
                if (tmp == null) { return string.Empty; }
                else { return tmp.ToString(); }
            }
            set { InputGridView.Rows[TargetIndex()].Cells[2].Value = value; }
        }
        /// <summary>
        /// GridViewの金額欄に入力した文字列を取得する
        /// </summary>
        private string Price_gv
        {
            get {var tmp = InputGridView.Rows[TargetIndex()].Cells[1].Value;
                if (tmp == null) { return string.Empty; }
                else { return tmp.ToString(); }}
            set { InputGridView.Rows[TargetIndex()].Cells[1].Value=value; }
        }
        /// <summary>
        /// ListBoxで選択した区分コードを取得する
        /// </summary>
        private string SelectedClassification
        {
            get { return KubunListBox.SelectedItem.ToString().Substring(0, 1); }
        }
        /// <summary>
        /// SelectDateCalenderで選択した日付をYYYY/MM/DD形式の文字列でとる
        /// </summary>
        private string SelectedDate
        {
            get { return SelectDateCalender.SelectionStart.ToShortDateString(); }
        }
        #endregion
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RegisterForm()
        {
            InitializeComponent();
            this.KubunListBox.Items.AddRange(ClassificationDicitonary.Select(kvp => string.Concat(kvp.Key, ":", kvp.Value)).ToArray());
            InputGridView.Rows.Add();
        }
        /// <summary>
        /// カレンダーの選択日付を変更した場合のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDateCalender_DateSelected(object sender, DateRangeEventArgs e)
        {
            PaidDate_gv = SelectedDate;
        }
        /// <summary>
        /// 区分項目の選択項目を変更した場合のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Classification_gv = SelectedClassification;
        }

        /// <summary>
        /// セット先のインデックス情報を状況に応じて返す（非選択の場合/選択している場合）
        /// </summary>
        /// <returns>セット先の行インデックス情報</returns>
        private int TargetIndex()
        {
          return InputGridView.CurrentRow.Index;
        }
        /// <summary>
        /// 追加ボタンクリック時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if(PaidDate_gv==string.Empty || Classification_gv == string.Empty || decimal.TryParse(Price_gv, out decimal price) == false) { MessageBox.Show("入力欄に有効な値を入力してください"); }
            else { InputGridView.Rows.Add(); Price_gv = price.ToString();}
        }
        /// <summary>
        /// 消去ボタンクリック時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (InputGridView.Rows.Count-1 == 0) { InputGridView.Rows.Remove(InputGridView.CurrentRow); InputGridView.Rows.Add(); }
            else { InputGridView.Rows.Remove(InputGridView.CurrentRow); }
        }
        /// <summary>
        /// 登録ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e)
        { 
           
        }

    }
}
