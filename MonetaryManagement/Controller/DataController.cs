using System;
using System.Collections.Generic;
using System.Linq;
using MonetaryManagement.Definition;
using System.Windows.Forms;

namespace MonetaryManagement.Controller
{
    class DataController
    {
        //送信元のフォームオブジェクト
        private RegisterForm ParentForm { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="parntFormObj">親にしたいRegisterForm</param>
        internal DataController(RegisterForm parntFormObj) {
            ParentForm = parntFormObj;
            Classifications = new Classifications().ClassificationItems;
        }

        /// <summary>
        /// セット先のインデックス情報を状況に応じて返す（非選択の場合/選択している場合）
        /// </summary>
        /// <returns>セット先の行インデックス情報</returns>
        private int TargetIndex { get { return ParentForm.InputGridView.CurrentRow.Index; } }

        internal IEnumerable<Classifications.Classification> Classifications { get; }

        #region DataGridViewの選択行各列項目プロパティ
        /// <summary>
        /// GridViewの支払い日付欄の日付を取得・設定する
        /// </summary>
        internal string PaidDate_gv
        {
            get
            {
                var tmp = ParentForm.InputGridView.Rows[TargetIndex].Cells[(int)InputGridViewCellIndexes.Date].Value;
                if (tmp == null) { return string.Empty; }
                else { return tmp.ToString(); }
            }
            set { ParentForm.InputGridView.Rows[TargetIndex].Cells[(int)InputGridViewCellIndexes.Date].Value = value; }
        }

        /// <summary>
        /// GridViewの金額欄に入力した文字列を取得する
        /// </summary>
        internal string Price_gv
        {
            get
            {
                var tmp = ParentForm.InputGridView.Rows[TargetIndex].Cells[(int)InputGridViewCellIndexes.Price].Value;
                if (tmp == null) { return string.Empty; }
                else { return tmp.ToString(); }
            }
            set { ParentForm.InputGridView.Rows[TargetIndex].Cells[(int)InputGridViewCellIndexes.Price].Value = value; }
        }

        /// <summary>
        /// GridViewの区分欄の区分を取得・設定する
        /// </summary>
        internal string Classification_gv
        {
            get
            {
                var tmp = ParentForm.InputGridView.Rows[TargetIndex].Cells[(int)InputGridViewCellIndexes.Classification].Value;
                if (tmp == null) { return string.Empty; }
                else { return tmp.ToString(); }
            }
            set { ParentForm.InputGridView.Rows[TargetIndex].Cells[(int)InputGridViewCellIndexes.Classification].Value = value; }
        }

        #endregion

        #region 各種コントロールで選択した値プロパティ
        /// <summary>
        /// SelectDateCalenderで選択した日付をYYYY/MM/DD形式の文字列でとる
        /// </summary>
        internal string SelectedDate
        { get { return ParentForm.SelectDateCalender.SelectionStart.ToShortDateString(); } }

        /// <summary>
        /// ListBoxで選択した区分コードを取得する
        /// </summary>
        internal string SelectedClassification
        {
            get
            {
                return Classifications.Where(item => item.KeyAndFormItemPair.Value == ParentForm.KubunListBox.SelectedItem.ToString())
                    .Select(item => item.KeyAndFormItemPair.Key).Single();
            }
        }


        #endregion

        /// <summary>
        /// InputGridviewに入力した項目をiEnumerableで返す
        /// </summary>
        internal IReadOnlyList<OneRecordData> InputDataList
        {
            get
            {
                return ParentForm.InputGridView.Rows.OfType<DataGridViewRow>()
                       .Select(row => new OneRecordData(row.Cells[(int)InputGridViewCellIndexes.Date].Value.ToString(),
                                                                 Convert.ToDecimal(row.Cells[(int)InputGridViewCellIndexes.Price].Value),
                                                                 row.Cells[(int)InputGridViewCellIndexes.Classification].Value.ToString())).ToList<OneRecordData>();
            }
        }
    }
}
