namespace FundRegister.FrontEnd
{
    public class RegisterFormAccessor
    {
        public static void RunRegisterForm(string TargetTableName)
        {
            State.SetTableName(TargetTableName);
            var ins=new RegisterForm();
            ins.ShowDialog();
        }
    }
}
