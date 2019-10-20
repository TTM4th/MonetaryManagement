using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MonetaryManagement;
using MonetaryManagement.Definition;
using MonetaryManagement.Business.Process;

namespace MonetaryManagement
{
    public partial class RegisterForm : Form
    {
        
        #region "内部変数"

        private IEnumerable<Classifications.Classification> Classifications { get;  }

        /// <summary>
        /// セット先のインデックス情報を状況に応じて返す（非選択の場合/選択している場合）
        /// </summary>
        /// <returns>セット先の行インデックス情報</returns>
        private int TargetIndex { get { return InputGridView.CurrentRow.Index; } }

        /// <summary>
        /// GridViewの支払い日付欄の日付を取得・設定する
        /// </summary>
        private string PaidDate_gv
        {
            get{var tmp = InputGridView.Rows[TargetIndex].Cells[0].Value;
                if (tmp == null) { return string.Empty; }
                else { return tmp.ToString(); }
            }
            set{ InputGridView.Rows[TargetIndex].Cells[0].Value = value;}
        }

        /// <summary>
        /// GridViewの区分欄の日付を取得・設定する
        /// </summary>
        private string Classification_gv
        {
            get { var tmp= InputGridView.Rows[TargetIndex].Cells[2].Value;
                if (tmp == null) { return string.Empty; }
                else { return tmp.ToString(); }
            }
            set { InputGridView.Rows[TargetIndex].Cells[2].Value = value; }
        }

        /// <summary>
        /// GridViewの金額欄に入力した文字列を取得する
        /// </summary>
        private string Price_gv
        {
            get {var tmp = InputGridView.Rows[TargetIndex].Cells[1].Value;
                if (tmp == null) { return string.Empty; }
                else { return tmp.ToString(); }}
            set { InputGridView.Rows[TargetIndex].Cells[1].Value=value; }
        }

        /// <summary>
        /// ListBoxで選択した区分コードを取得する
        /// </summary>
        private string SelectedClassification
        { get {
                return Classifications.Where(item => item.KeyAndFormItemPair.Value == KubunListBox.SelectedItem.ToString())
                    .Select(item => item.KeyAndFormItemPair.Key).Single();
            }
        }

        /// <summary>
        /// SelectDateCalenderで選択した日付をYYYY/MM/DD形式の文字列でとる
        /// </summary>
        private string SelectedDate
        {get { return SelectDateCalender.SelectionStart.ToShortDateString(); }}

        /// <summary>
        /// InputGridviewに入力した項目をiEnumerableで返す
        /// </summary>
        private IEnumerable<OneRecordData> InputDataList
        {
            get
            {return InputGridView.Rows.OfType<DataGridViewRow>()
                    .Select(row => new OneRecordData(row.Cells[0].Value.ToString(),
                                                              Convert.ToDecimal(row.Cells[1].Value),
                                                              row.Cells[2].Value.ToString()));}
        }
        

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RegisterForm()
        {
            InitializeComponent();
            var items = new Classifications();
            Classifications = items.ClassificationItems;
        }

        #region"イベント"
        /// <summary>
        /// 登録フォーム読み取り時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            this.KubunListBox.Items.
                AddRange(Classifications.Select(item => item.FormItem).ToArray());
            InputGridView.Rows.Add();
        }

        /// <summary>
        /// カレンダーの選択日付を変更した場合のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDateCalender_DateSelected(object sender, DateRangeEventArgs e){PaidDate_gv = SelectedDate;}

        /// <summary>
        /// 区分項目の選択項目を変更した場合のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e){Classification_gv = SelectedClassification;}


        /// <summary>
        /// 追加ボタンクリック時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if(PaidDate_gv==string.Empty || 
                Classification_gv == string.Empty || 
                decimal.TryParse(Price_gv, out decimal price) == false) { MessageBox.Show("入力欄に有効な値を入力してください"); }
            else { InputGridView.Rows.Add();
                   InputGridView.CurrentCell=InputGridView.Rows[TargetIndex+1].Cells[0]; }
        }
        /// <summary>
        /// 消去ボタンクリック時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (InputGridView.Rows.OfType<DataGridViewRow>().Any()==false)
            { InputGridView.Rows.Remove(InputGridView.CurrentRow); InputGridView.Rows.Add(); }
            else { InputGridView.Rows.Remove(InputGridView.CurrentRow); }
        }

        /// <summary>
        /// 登録ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var register =new Register(this.InputDataList);
            register.RegistData();
        }

        #endregion

    }
}
