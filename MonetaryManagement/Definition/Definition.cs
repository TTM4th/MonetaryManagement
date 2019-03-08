using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetaryManagement.Definition
{
        /// <summary>
        /// 使用した金額あたりの情報構造体
        /// </summary>
       public struct OneRecordData
        {
           public string PaidDate;
           public decimal Price;
           public string Classification;
        }

}
