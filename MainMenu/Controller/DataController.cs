using DBConnector.Accessor;
using DBConnector.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu.Controller
{


    internal class DataController
    {
        /// <summary>
        /// 現在月の月別利用金額データテーブル名
        /// </summary>
        private string AccessMonthlyUsedTableName;

        /// <summary>
        /// 月別利用金額データテーブルのAcceser
        /// </summary>
        private MoneyUsedDataAccessor MonthlyUsedAccessor;

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

        internal DataController()
        {
            AccessMonthlyUsedTableName = $"{NowYear}-{DateTime.Now.Month.ToString("00")}";
            MonthlyUsedAccessor = new MoneyUsedDataAccessor(AccessMonthlyUsedTableName);
            MonthlyFundAccessor = new MonthlyFundAccessor();
            MonthlyUsedManager = new MoneyUsedDataTableManager();
        }

        /// <summary>
        /// 現在残高を取得する
        /// </summary>
        /// <returns></returns>
        internal decimal GetCurrentBalance()
        {
            if (MonthlyUsedManager.IsExistMonetaryTable(AccessMonthlyUsedTableName)==false) { MonthlyUsedManager.CreateTable(AccessMonthlyUsedTableName); }
            MonthlyUsedAccessor.GetMonetarydata();
            decimal nowUsed = MonthlyUsedAccessor.MoneyUsedDataEntitiesFromTable.Sum(x => x.Price);
            return MonthlyFundAccessor.GetMonthFirstBalance(NowYear, NowMonth)-nowUsed;
        }

    }
}
