namespace FundRegister.FrontEnd
{
    internal class State
    {

        /// <summary>
        /// データ送受するテーブル名プロパティ
        /// </summary>
        internal static string TargetTableName{get; private set;}

        /// <summary>
        /// TargetTableNameプロパティSetter
        /// </summary>
        /// <param name="tableName"></param>
        internal static void SetTableName(string tableName)
        {
            TargetTableName = tableName;
        }
    }
}
