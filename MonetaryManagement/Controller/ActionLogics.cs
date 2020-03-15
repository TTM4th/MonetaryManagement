using MonetaryManagement.Business.Process;
using MonetaryManagement.Definition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonetaryManagement.Controller
{
    class ActionLogics
    {
        //送信元のフォームオブジェクト
        private RegisterForm ParentForm { get; }
        private DataController DataController { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="parntFormObj">親にしたいRegisterForm</param>
        internal ActionLogics(RegisterForm parntFormObj)
        {
            ParentForm = parntFormObj;
            DataController = new DataController(ParentForm);
        }

        #region Action

        /// <summary>
        /// RegisterFormのLoadイベントで実行するアクション
        /// </summary>
        internal void LoadParentFormAction()
        {
            ParentForm.KubunListBox.Items.
            AddRange(DataController.Classifications.Select(item => item.FormItem).ToArray());
            ParentForm.InputGridView.Rows.Add();
        }

        /// <summary>
        /// SelectDateCalenderで日付を選択した際に実行するアクション
        /// </summary>
        internal void DateSelectedAction() { DataController.PaidDate_gv = DataController.SelectedDate; }

        /// <summary>
        /// ListBox1選択項目を変更した場合に実行するアクション
        /// </summary>
        internal void SelectKubunAction() { DataController.Classification_gv = DataController.SelectedClassification; }

        /// <summary>
        /// 金額情報登録行を追加する際のアクション
        /// </summary>
        internal void AddInputDataRow()
        {
            if (DataController.PaidDate_gv == string.Empty ||
                DataController.Classification_gv == string.Empty ||
                decimal.TryParse(DataController.Price_gv, out decimal price) == false) { MessageBox.Show("入力欄に有効な値を入力してください"); }
            else
            {
                ParentForm.InputGridView.Rows.Add();
                int newRowIndex = ParentForm.InputGridView.Rows.GetLastRow(DataGridViewElementStates.None);
                ParentForm.InputGridView.CurrentCell = ParentForm.InputGridView.Rows[newRowIndex].Cells[(int)InputGridViewIndexes.Date];
            }
        }

        /// <summary>
        /// 入力した金額情報を消去したい際のアクション
        /// </summary>
        internal void DeleteDataRow()
        {
            if (ParentForm.InputGridView.Rows.OfType<DataGridViewRow>().Any() == false)
            { ParentForm.InputGridView.Rows.Remove(ParentForm.InputGridView.CurrentRow); ParentForm.InputGridView.Rows.Add(); }
            else { ParentForm.InputGridView.Rows.Remove(ParentForm.InputGridView.CurrentRow); }
        }

        /// <summary>
        /// 登録ボタンクリック時に実行するアクション
        /// </summary>
        internal void RegistData()
        {
            var register = new Register(this.DataController.InputDataList);
            register.RegistData();
        }
        #endregion

    }
}
