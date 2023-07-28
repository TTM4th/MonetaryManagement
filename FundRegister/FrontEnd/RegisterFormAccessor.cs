namespace FundRegister.FrontEnd
{
    public class RegisterFormAccessor
    {
        public static void RunRegisterForm(string TargetTableName,bool isWholeEdit)
        {
            State.SetTableName(TargetTableName);
            State.SetIsMonthlyWholeEditMode(isWholeEdit);
            var ins=new RegisterForm(State.IsMonthlyWholeEditMode);
            ins.ShowDialog();
        }
    }
}
