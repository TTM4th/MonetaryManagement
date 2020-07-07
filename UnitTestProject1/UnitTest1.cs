using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cf = new CSVFormatter(@"D:\Documents\WorkFolder\'20_5.txt");
            cf.Write();
        }

        [TestMethod]
        public void TestRun()
        {
            FundRegister.FrontEnd.RegisterFormAccessor.RunRegisterForm("TEST",true);
        }

        [TestMethod]
        public void DAtest()
        {
            var pubIns = new DBConnector.Accessor.MonthlyFundAccessor();
            Console.WriteLine(pubIns.GetMonthFirstBalance(2020, 7));
            Console.WriteLine(DBConnector.Accessor.MoneyUsedDataAccessor.GetMonthlyPrice(2020, 7));
        }

        [TestMethod]
        public void DMtest()
        {
            var conIns = new DBConnector.Controller.MoneyUsedDataTableManager();
            foreach (string name in conIns.MonthlyTableNames())
            {
                Console.WriteLine($"テーブル名:{name}");
            }
            string tblname = "2020-08";
            Console.WriteLine($"Is Exist {tblname} ? {conIns.IsExistMonetaryTable(tblname)}");
        }
    }

    internal class CSVFormatter
    {
        internal CSVFormatter(string path){ Path = path; }
        private string Path;
        private IReadOnlyList<string[]> readlines;
        private IReadOnlyList<string> outlines;
        internal void Write()
        {
            IEnumerable<string> lines = System.IO.File.ReadAllLines(Path);
            readlines =lines.Select(x => x.Split(',')).ToList<string[]>();
            SetDate();
            System.IO.File.WriteAllLines(Path, outlines, System.Text.Encoding.GetEncoding("shift_jis"));
        }

        internal void SetDate()
        {
            string onedate;
            for(int index=0; index<readlines.Count; index++ )
            {
                onedate = readlines[index][0];
                if (onedate == "") { readlines[index][0] = readlines[index - 1][0]; }
            }
            outlines = readlines.Select(x => string.Join(",", x)).ToList();
        }
    }

}
