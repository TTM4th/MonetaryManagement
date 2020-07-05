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
        /// コンストラクタ
        /// </summary>
        internal DataController()
        {
            MonthlyFundAccessor = new MonthlyFundAccessor();
            MonthlyUsedManager = new MoneyUsedDataTableManager();
        }

        /// <summary>
        /// 現在残高を取得する
        /// </summary>
        /// <returns></returns>
        internal decimal GetCurrentBalance()
        {
            return MonthlyFundAccessor.GetMonthFirstBalance(NowYear, NowMonth)-MoneyUsedDataAccessor.GetMonthlyPrice(NowYear,NowMonth);
        }

    }
}
