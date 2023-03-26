using MainMenu.Controller;
using System;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
            ActionLogics = new ActionLogics(this);
        }

        private ActionLogics ActionLogics { get; }

        private void Form1_Load(object sender, EventArgs e)
        {
            InsertMode.Checked = true;
            TableNameComboBox.SelectedIndex = 0;
            ActionLogics.ReflectNowBalance();
        }

        private void RunFundRegister_Click(object sender, EventArgs e)
        {
            FundRegister.FrontEnd.RegisterFormAccessor.RunRegisterForm((string)TableNameComboBox.SelectedItem, WholeEdit.Checked);
            this.Show();
            ActionLogics.ReflectNowBalance();
        }


    }
}
