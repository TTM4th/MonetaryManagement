using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetaryManagement.Definition
{       
        
        /// <summary>
        /// RegisterフォームのDataGridViewのセルのインデックス情報
        /// </summary>
        internal enum InputGridViewCellIndexes
        {
            Date,
            Price,
            Classification
        }

        /// <summary>
        /// 使用した金額あたりの情報構造体
        /// </summary>
       internal class OneRecordData
        {
           internal OneRecordData(string paidDate,decimal price,string classification)
            {
                this.PaidDate = paidDate;
                this.Price = price;
                this.Classification = classification;
            }
            internal string PaidDate { get; }
            internal decimal Price { get; }
            internal string Classification { get; }
            internal bool IsEmpty(){return PaidDate == null || Classification == null;}
        }

        /// <summary>
        /// 項目区分情報
        /// </summary>
        internal class Classifications
        {
            /// <summary>
            /// コンストラクタ
            /// </summary>
            internal Classifications()
            {
                ClassificationItems = new List<Classification>
                    {
                        new Classification("1", "運賃"),
                        new Classification("2", "飲食費"),
                        new Classification("3", "日用品・家電"),
                        new Classification("4", "娯楽"),
                        new Classification("5", "衣類"),
                        new Classification("6", "消耗品"),
                        new Classification("7", "サービス費"),
                        new Classification("8", "収入"),
                        new Classification("?", "未分類")
                    };
            }

            /// <summary>
            /// 区分項目情報
            /// </summary>
            internal IEnumerable<Classification> ClassificationItems;

            /// <summary>
            /// 項目フラグと項目名（項目フラグと項目名のペアを管理する構造体）
            /// </summary>
            internal struct Classification
            {
                /// <summary>
                /// コンストラクタ
                /// </summary>
                /// <param name="key">項目フラグ</param>
                /// <param name="item">項目フラグとペアになる項目名</param>
                internal Classification(string key, string item)
                {
                    this.Key = key;
                    this.Item = item;
                    this.FormItem = string.Concat(this.Key, ":", this.Item);
                    this.KeyAndFormItemPair = new KeyValuePair<string, string>(this.Key, this.FormItem);
                }
                /// <summary>項目フラグ</summary>
                internal string Key;

                /// <summary>項目名</summary>
                internal string Item;
                
                /// <summary>フォーム用項目</summary>
                internal string FormItem;
                
                /// <summary>キー：項目フラグ(Key)、値：フォーム用項目（FormItem）</summary>
                internal KeyValuePair<string, string> KeyAndFormItemPair;
            }

        }
}
