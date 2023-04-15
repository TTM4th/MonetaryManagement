using System.Windows;
using WpfMainMenu.Controller;

namespace WpfMainMenu
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ActionLogics = new ActionLogics(this);
        }
        private ActionLogics ActionLogics { get; }

        private void MainWindow1_Loaded(object sender, RoutedEventArgs e)
        {
            InsertMode.IsChecked = true;
            TableNameComboBox.SelectedIndex = 0;
            ActionLogics.ReflectNowBalance();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FundRegister.FrontEnd.RegisterFormAccessor.RunRegisterForm((string)TableNameComboBox.SelectedItem, WholeEdit.IsChecked ?? false);
            this.Show();
            ActionLogics.ReflectNowBalance();
        }
    }
}
