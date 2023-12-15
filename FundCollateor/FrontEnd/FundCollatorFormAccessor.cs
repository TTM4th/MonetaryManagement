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
