namespace MainMenu.Controller
{
    class ActionLogics
    {
        /// <summary>
        /// 送信元のフォームオブジェクトインスタンス
        /// </summary>
        private MenuForm ParentForm { get; }

        private DataController DataController { get; }

        internal ActionLogics(MenuForm menuForm)
        {
            ParentForm = menuForm;
            DataController = new DataController();
            ParentForm.TableNameComboBox.DataSource = DataController.MonthlyTableNames;
        }

        /// <summary>
        /// 現在残高をフォームに反映させる
        /// </summary>
        internal void ReflectNowBalance()
        {
            ParentForm.NowBalance.Text = DataController.GetCurrentBalance().ToString();
            ParentForm.NowBalance.Update();
        }

        internal void ReflectIsInitialNowMonth()
        {
            if (DataController.IsNowMonthEmpty()) { ParentForm.WholeEdit.Checked = false; ParentForm.WholeEdit.Enabled = false; }
        }

    }
}
