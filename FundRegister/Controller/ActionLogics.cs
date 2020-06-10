using FundRegister.Business.Process;
using FundRegister.Definition;
using System.Linq;
using System.Windows.Forms;

namespace FundRegister.Controller
{
    class ActionLogics
    {
        /// <summary>
        /// 送信元のフォームオブジェクトインスタンス
        /// </summary>
        private RegisterForm ParentForm { get; }

        /// <summary>
        /// 送信元フォームオブジェクトで入力したデータを管理するインスタンス
        /// </summary>
        private DataController DataController { get; }

        private bool IsMonthlyWholeEditMode  { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="parntFormObj">親にしたいRegisterForm</param>
        internal ActionLogics(RegisterForm parntFormObj,bool iswholeEditMode)
        {
            ParentForm = parntFormObj;
            DataController = new DataController(ParentForm);
            IsMonthlyWholeEditMode = iswholeEditMode;
        }

        #region Action

        /// <summary>
        /// RegisterFormのLoadイベントで実行するアクション
        /// </summary>
        internal void LoadParentFormAction()
        {
            ParentForm.KubunListBox.Items.
                AddRange(DataController.Classifications.Select(item => item.FormItem).ToArray());
            if (IsMonthlyWholeEditMode) { DataController.ReflectGridFromDB(); }
            else { ParentForm.InputGridView.Rows.Add(); }
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
                ParentForm.InputGridView.CurrentCell = ParentForm.InputGridView.Rows[newRowIndex].Cells[(int)InputGridViewCellIndexes.Date];
            }
        }

        /// <summary>
        /// 入力した金額情報を消去したい際のアクション
        /// </summary>
        internal void DeleteDataRow()
        {
            ParentForm.InputGridView.Rows.Remove(ParentForm.InputGridView.CurrentRow);
            if (ParentForm.InputGridView.Rows.OfType<DataGridViewRow>().Any() == false){ ParentForm.InputGridView.Rows.Add(); }
        }

        /// <summary>
        /// 登録ボタンクリック時に実行するアクション
        /// </summary>
        internal void RegistData()
        {
            Cursor.Current = Cursors.WaitCursor;
            var register = new Register(this.DataController.InputDataList);
            register.RegistData(this.IsMonthlyWholeEditMode);
            ParentForm.InputGridView.Rows.Clear();
            if (IsMonthlyWholeEditMode) { DataController.ReflectGridFromDB(); }
            else { ParentForm.InputGridView.Rows.Add(); }
            Cursor.Current = Cursors.Default;
        }
        #endregion


    }
}
