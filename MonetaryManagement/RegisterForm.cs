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
    internal partial class RegisterForm : Form
    {
        
        #region "内部変数"

        private IEnumerable<Classifications.Classification> Classifications { get;  }

        private Controller.ActionLogics ActionLogics { get; }

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RegisterForm()
        {
            InitializeComponent();
            ActionLogics = new Controller.ActionLogics(this);
        }

        #region"イベント"
        /// <summary>
        /// 登録フォーム読み取り時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterForm_Load(object sender, EventArgs e){ ActionLogics.LoadParentFormAction();}

        /// <summary>
        /// カレンダーの選択日付を変更した場合のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDateCalender_DateSelected(object sender, DateRangeEventArgs e){ ActionLogics.DateSelectedAction();}

        /// <summary>
        /// 区分項目の選択項目を変更した場合のイベント処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e){ ActionLogics.SelectKubunAction();}

        /// <summary>
        /// 追加ボタンクリック時のイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterButton_Click(object sender, EventArgs e){ ActionLogics.AddInputDataRow();}
        /// <summary>
        /// 消去ボタンクリック時イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e){ ActionLogics.DeleteDataRow();}

        /// <summary>
        /// 登録ボタンクリックイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterButton_Click(object sender, EventArgs e){ ActionLogics.RegistData();}

        #endregion

    }
}
