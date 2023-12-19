using System;
using System.Linq;
using System.Windows.Forms;
using FundRegister.Controller;

namespace FundRegister
{
    internal partial class RegisterForm : Form
    {
        
        #region "内部変数"

        /// <summary>
        /// 送信元フォームオブジェクトで入力したデータを管理するインスタンス
        /// </summary>
        private DataController Controller { get; }

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal RegisterForm()
        {
            InitializeComponent();
            this.Controller = new DataController(this);
        }


        #region"イベント"
        /// <summary>
        /// 登録フォーム読み取り時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterForm_Load(object sender, EventArgs e){
            this.Controller.InitializeKubunListBox();
            this.Controller.ReflectGridFromDB();
        }

        /// <summary>
        /// カレンダーの選択日付を変更した場合のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDateCalender_DateSelected(object sender, DateRangeEventArgs e){
            this.Controller.PaidDate_gv = this.Controller.SelectedDate;
        }

        /// <summary>
        /// 区分項目の選択項目を変更した場合のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e){ 
            this.Controller.Classification_gv = this.Controller.SelectedClassification;
        }

        /// <summary>
        /// 追加ボタンクリック時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterButton_Click(object sender, EventArgs e){ 
            if (this.Controller.HasInValidRows) { this.Controller.MoveToFirstInValidRow(); }
            else { this.Controller.AppendNewRowAction(); }
        }
        /// <summary>
        /// 消去ボタンクリック時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e){
            this.InputGridView.Rows.Remove(this.InputGridView.CurrentRow);
            if (this.InputGridView.Rows.OfType<DataGridViewRow>().Any() == false) { this.InputGridView.Rows.Add(); }
        }

        /// <summary>
        /// 登録ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e){
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                this.Controller.ReflectToDB();
            }
            catch (System.Exception)
            {//何かの手違いで有効値が入っていないエラー行が一つでも存在したらここの例外を拾う
                MessageBox.Show("有効な値を入力してください", "値が入力されていません");
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }
        #endregion
    }
}
