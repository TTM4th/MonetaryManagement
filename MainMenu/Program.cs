using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonUtilities.CommonParts;
namespace MainMenu
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            FormSingletonUtility<MenuForm>.ImplementedGlobalMutexRun();
        }
    }
}
