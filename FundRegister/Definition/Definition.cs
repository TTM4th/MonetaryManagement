using MonetaryManagementDefinitions.Flags;
using System.Collections.Generic;

namespace FundRegister.Definition
{

    /// <summary>
    /// RegisterフォームのDataGridViewのセルのインデックス情報
    /// </summary>
    internal enum InputGridViewCellIndexes
        {   
            ID,
            Date,
            Price,
            Classification
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
                        new Classification(ClassificationFlags.UnchinFlag, ClassificationFlags.UnchinName),
                        new Classification(ClassificationFlags.InshokuFlag, ClassificationFlags.InshokuName),
                        new Classification(ClassificationFlags.NichiyouHinFlag, ClassificationFlags.NichiyouHinName),
                        new Classification(ClassificationFlags.GorakuFlag,ClassificationFlags.GorakuName),
                        new Classification(ClassificationFlags.IruiFlag, ClassificationFlags.IruiName),
                        new Classification(ClassificationFlags.ShomouHinFlag, ClassificationFlags.ShoumouHinName),
                        new Classification(ClassificationFlags.ServiceHiFlag, ClassificationFlags.ServiceHiName),
                        new Classification(ClassificationFlags.AzukeIreFlag,ClassificationFlags.AzukeIreName),
                        new Classification(ClassificationFlags.MibunruiFlag, ClassificationFlags.MibunruiName)
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
