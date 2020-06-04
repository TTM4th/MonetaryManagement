using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetaryManagement.FrontEnd
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
