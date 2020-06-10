using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetaryManagementDefinitions.Flags
{
    public class ClassificationFlags
    {
        public static string UnchinFlag { get { return "1"; } }

        public static string UnchinName { get { return "運賃"; } }

        public static string InshokuFlag { get { return "2"; } }

        public static string InshokuName { get { return "飲食費"; } }

        public static string NichiyouHinFlag { get { return "3"; } }

        public static string NichiyouHinName { get { return "日用品・家電"; } }

        public static string GorakuFlag { get { return "4"; } }

        public static string GorakuName { get { return "娯楽"; } }

        public static string IruiFlag { get { return "5"; } }

        public static string IruiName { get { return "衣類"; } }

        public static string ShomouHinFlag { get { return "6"; } }

        public static string ShoumouHinName { get { return "消耗品"; } }

        public static string ServiceHiFlag { get { return "7"; } }

        public static string ServiceHiName { get { return "サービス費"; } }

        public static string AzukeIreFlag { get { return "8"; } }

        public static string AzukeIreName { get { return "預入・引出・収入"; } }

        public static string MibunruiFlag { get { return "?"; } }

        public static string MibunruiName { get { return "未分類"; } }

    }
}
