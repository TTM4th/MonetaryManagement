using System.Collections.Generic;
using System.Linq;
using FundRegister.Definition;
using DBConnector.Entity;
using DBConnector.Accessor;
using DBConnector.Controller;
namespace FundRegister.Business.Process
{
    internal class Register
    {
        /// <summary>
        /// 登録用データ
        /// </summary>
        private IReadOnlyList<OneRecordData> RegisttedData { get;}

        /// <summary>
        /// 金銭管理データ取得部品
        /// </summary>
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
        internal void RegistData(bool isWholeEditMode)
        {
            if (isWholeEditMode) { new MoneyUsedDataTableManager().InitializeTable(FrontEnd.State.TargetTableName); }
            DataAccessor.UploadMonetaryData(ConvertMoneyUsedData());
        }
        
        /// <summary>
        /// OneRecordからMoneyUsedData型の列挙オブジェクトに変換する
        /// </summary>
        /// <returns></returns>
        internal IEnumerable<MoneyUsedData> ConvertMoneyUsedData()
        {
            return RegisttedData.Select((onerecord,index) => new MoneyUsedData {ID=index,Date=onerecord.PaidDate,Price=onerecord.Price,Classification=onerecord.Classification});
        }

    }
}
