using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetaryManagement.FrontEnd
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

        /// <summary>
        /// 月単位で丸ごと編集するか否か
        /// </summary>
        internal static bool IsMonthlyWholeEditMode { get; private set; }

        /// <summary>
        /// IsMonthlyWholeEditModeプロパティSetter
        /// </summary>
        /// <param name="isWholeEditMode">月単位編集の場合=true/日単位で追加だけの場合=false</param>
        internal static void SetIsMonthlyWholeEditMode(bool isWholeEditMode)
        {
            IsMonthlyWholeEditMode = isWholeEditMode;
        }
    }
}
