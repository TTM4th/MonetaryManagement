using System.Collections.Generic;
using System.Linq;
using MonetaryManagement.Definition;
using DBConnector.Entity;
using DBConnector.Accessor;
namespace MonetaryManagement.Business.Process
{
    internal class Register
    {
        /// <summary>
        /// 登録用データ
        /// </summary>
        private IReadOnlyList<OneRecordData> RegisttedData { get;}

        private MoneyUsedDataAccessor DataAccessor;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="registTargetData">フォームに入力したデータ</param>
        internal Register(IReadOnlyList<OneRecordData> registTargetData)
        {
            RegisttedData = registTargetData;
            DataAccessor = new MoneyUsedDataAccessor(FrontEnd.State.TargetTableName);
        }

        /// <summary>
        /// データを登録する
        /// </summary>
        internal void RegistData()
        {
            DataAccessor.UploadMonetaryData(ConvertMoneyUsedData());
        }
        
        internal IEnumerable<MoneyUsedData> ConvertMoneyUsedData()
        {
            return RegisttedData.Select((onerecord,index) => new MoneyUsedData {ID=index,Date=onerecord.PaidDate,Price=onerecord.Price,Classification=onerecord.Classification});
        }

    }
}
