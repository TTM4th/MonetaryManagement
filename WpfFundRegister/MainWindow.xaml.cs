using System.Collections.Generic;
using System.Windows;
using WpfFundRegister.Definition;

namespace WpfFundRegister
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        #region "内部変数"

        //private IEnumerable<Classifications.Classification> Classifications { get; }

        /// <summary>
        /// 本オブジェクトのコントロールイベント時に行う処理ロジッククラスインスタンス
        /// </summary>
        //private Controller.ActionLogics ActionLogics { get; }

        #endregion

        public MainWindow()
        {
            InitializeComponent();
            //ActionLogics = new Controller.ActionLogics(this, false);
        }

        //internal MainWindow(bool iswholeEditMode)
        //{
            //InitializeComponent();
            //ActionLogics = new Controller.ActionLogics(this, iswholeEditMode);
        //}
    }
}
