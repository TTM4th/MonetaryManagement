namespace FundRegister.FrontEnd
{
    internal class State
    {

        /// <summary>
        /// データ送受するテーブル名プロパティ
        /// </summary>
        internal static string TargetTableName{get; private set;}

        internal static string TargetYear;
        internal static string TargetMonth;

        /// <summary>
        /// TargetTableNameプロパティSetter
        /// </summary>
        /// <param name="tableName"></param>
        internal static void SetTableName(string tableName)
        {
            var yyyy_mm = tableName.Split('-');
            TargetYear = yyyy_mm[0];
            TargetMonth = yyyy_mm[1];
        }

    }
}
