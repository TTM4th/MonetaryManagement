using DBConnector.Accessor;
using DBConnector.Controller;
using System;
using System.Collections.Generic;
using System.Linq;

namespace WpfMainMenu.Controller
{


    internal class DataController
    {

        /// <summary>
        /// 月別初期残高データテーブルのAcceser
        /// </summary>
        private MonthlyFundAccessor MonthlyFundAccessor;

        /// <summary>
        /// 月別利用金額データテーブルのManager
        /// </summary>
        private MoneyUsedDataTableManager MonthlyUsedManager;

        /// <summary>
        /// 現在年
        /// </summary>
        private int NowYear { get { return DateTime.Now.Year; } }

        /// <summary>
        /// 現在月
        /// </summary>
        private int NowMonth { get { return DateTime.Now.Month; } }

        /// <summary>
        /// 現在月の利用額総和
        /// </summary>
        private decimal NowMonthSum { get { return MonthlyUsedManager.GetMonthlyPrice(NowYear.ToString(), NowMonth.ToString("00")); } }
        
        internal IReadOnlyList<string> MonthlyTableNames { get; private set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal DataController()
        {
            MonthlyFundAccessor = new MonthlyFundAccessor();
            MonthlyUsedManager = new MoneyUsedDataTableManager();
            //現在月の月別利用額テーブルが存在しない場合は作成する。
            if (!MonthlyFundAccessor.IsExistFirstBalance(NowYear, NowMonth)) { MonthlyFundAccessor.InsertFromPreviousMonth(NowYear, NowMonth); }
            string newTablename = $"{NowYear}-{NowMonth.ToString("00")}";
            if (MonthlyUsedManager.IsExistMonetaryTable(newTablename) == false) { MonthlyUsedManager.CreateTable(newTablename); }
            MonthlyTableNames = MonthlyUsedManager.MonthlyTableNames().Take(6).ToList();
        }

        /// <summary>
        /// 現在残高を取得する
        /// </summary>
        /// <returns></returns>
        internal decimal GetCurrentBalance()
        {
            return MonthlyFundAccessor.GetMonthFirstBalance(NowYear, NowMonth) - NowMonthSum;
        }

    }
}
