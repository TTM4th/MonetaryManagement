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
            var cf = new CSVFormatter(@"D:\Documents\WorkFolder\'20_2.txt");
            cf.Write();
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
