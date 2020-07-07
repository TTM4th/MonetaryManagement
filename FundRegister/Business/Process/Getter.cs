using System.Collections.Generic;
using System.Linq;
using DBConnector.Accessor;
using DBConnector.Entity;
using FundRegister.Definition;

namespace FundRegister.Business.Process
{
    internal class Getter
    {
        /// <summary>
        /// 金銭管理データ取得部品
        /// </summary>
        private MoneyUsedDataAccessor DataAccessor;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        internal Getter()
        {
            DataAccessor = new MoneyUsedDataAccessor(FrontEnd.State.TargetTableName);
        }

        /// <summary>
        /// DBから金銭管理データを取得する
        /// </summary>
        /// <returns></returns>
        internal IEnumerable<OneRecordData> GetData()
        {
            DataAccessor.GetMonetarydata();
            return ConvertOneRecordData(DataAccessor.MoneyUsedDataEntitiesFromTable);
        }

        /// <summary>
        /// MoneyUsedData型の列挙オブジェクトからOneRecord型の列挙オブジェクトに変換する
        /// </summary>
        /// <param name="gotData">MoneyUsedData型の列挙オブジェクト</param>
        /// <returns></returns>
        private IEnumerable<OneRecordData> ConvertOneRecordData(IEnumerable<MoneyUsedData> gotData)
        {
            return gotData.Select(onerecord => new OneRecordData (onerecord.Date,onerecord.Price,onerecord.Classification));
        }

    }
}
