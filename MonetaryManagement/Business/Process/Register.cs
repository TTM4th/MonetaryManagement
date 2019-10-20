using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonetaryManagement.Definition;
namespace MonetaryManagement.Business.Process
{
    internal class Register
    {
        /// <summary>
        /// 登録用データ
        /// </summary>
        private IEnumerable<OneRecordData> RegisttedData { get;}

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="registTargetData">フォームに入力したデータ</param>
        internal Register(IEnumerable<OneRecordData> registTargetData)
        {
            RegisttedData = registTargetData;
        }

        /// <summary>
        /// データを登録する
        /// </summary>
        internal void RegistData()
        {

        }
        
    }
}
