using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundCollator.FrontEnd
{
    public class FundCollatorFormAccessor
    {
        public static void RunFundCollatorForm(decimal nowbalance)
        {
            var ins = new FundCollatorFrom(nowbalance);
            ins.ShowDialog();
        }
    }
}
