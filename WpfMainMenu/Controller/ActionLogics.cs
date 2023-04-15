namespace WpfMainMenu.Controller
{
    class ActionLogics
    {
        /// <summary>
        /// 送信元のフォームオブジェクトインスタンス
        /// </summary>
        private MainWindow ParentForm { get; }

        private DataController DataController { get; }

        internal ActionLogics(MainWindow menuForm)
        {
            ParentForm = menuForm;
            DataController = new DataController();
            ParentForm.TableNameComboBox.ItemsSource = DataController.MonthlyTableNames;
        }

        /// <summary>
        /// 現在残高をフォームに反映させる
        /// </summary>
        internal void ReflectNowBalance()
        {
            ParentForm.NowBalance.Content = DataController.GetCurrentBalance().ToString();
            //ParentForm.NowBalance.Update();
        }


    }
}
