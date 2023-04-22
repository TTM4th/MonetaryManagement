using System;
using System.Collections.Generic;
using System.Linq;
using WpfFundRegister.Definition;
using WpfFundRegister.Business.Process;
using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace WpfFundRegister.Controller
{
    class DataController
    {
        //送信元のフォームオブジェクト
        private MainWindow ParentForm { get; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="parntFormObj">親にしたいRegisterForm</param>
        internal DataController(MainWindow parntFormObj) {
            ParentForm = parntFormObj;
            Classifications = new Classifications().ClassificationItems;
        }

        /// <summary>
        /// セット先のインデックス情報を状況に応じて返す（非選択の場合/選択している場合）
        /// </summary>
        /// <returns>セット先の行インデックス情報</returns>
        private int TargetIndex { get { return ParentForm.InputGridView.SelectedIndex; } }

        internal IEnumerable<Classifications.Classification> Classifications { get; }

        #region DataGridViewの選択行各列項目プロパティ
        /// <summary>
        /// GridViewの支払い日付欄の日付を取得・設定する
        /// </summary>
        internal string PaidDate_gv
        {
            get
            {
                var tmp = ParentForm.InputGridView.SelectedItem;
                if (tmp == null) { return string.Empty; }
                else { return ((TextBlock)ParentForm.InputGridView.Columns[(int)InputGridViewCellIndexes.Date].GetCellContent(tmp)).Text; }
            }
            set
            {
                var tmp = ParentForm.InputGridView.SelectedItem;
                ((TextBlock)ParentForm.InputGridView.Columns[(int)InputGridViewCellIndexes.Date].GetCellContent(tmp)).Text = value;
            }
        }

        /// <summary>
        /// GridViewの金額欄に入力した文字列を取得する
        /// </summary>
        internal string Price_gv
        {
            get
            {
                var tmp = ParentForm.InputGridView.SelectedItem;
                if (tmp == null) { return string.Empty; }
                else { return ((TextBlock)ParentForm.InputGridView.Columns[(int)InputGridViewCellIndexes.Price].GetCellContent(tmp)).Text; }
            }
            set
            {
                var tmp = ParentForm.InputGridView.SelectedItem;
                ((TextBlock)ParentForm.InputGridView.Columns[(int)InputGridViewCellIndexes.Price].GetCellContent(tmp)).Text = value;
            }
        }

        /// <summary>
        /// GridViewの区分欄の区分を取得・設定する
        /// </summary>
        internal string Classification_gv
        {
            get
            {
                var tmp = ParentForm.InputGridView.SelectedItem;
                if (tmp == null) { return string.Empty; }
                else { return ((TextBlock)ParentForm.InputGridView.Columns[(int)InputGridViewCellIndexes.Classification].GetCellContent(tmp)).Text; }
            }
            set
            {
                var tmp = ParentForm.InputGridView.SelectedItem;
                ((TextBlock)ParentForm.InputGridView.Columns[(int)InputGridViewCellIndexes.Classification].GetCellContent(tmp)).Text = value;
            }
        }

        #endregion

        #region 各種コントロールで選択した値プロパティ
        /// <summary>
        /// SelectDateCalenderで選択した日付をYYYY/MM/DD形式の文字列でとる
        /// </summary>
        internal string SelectedDate
        { get { return ParentForm.SelectDateCalender.SelectedDate.ToString(); } }

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
        //internal IReadOnlyList<OneRecordData> InputDataList
        //{
            //get
            //{
            //    return ParentForm.InputGridView.DataContext.Translate
            //           (row => new OneRecordData(row.Cells[(int)InputGridViewCellIndexes.Date].Value.ToString(),
            //                                                     Convert.ToDecimal(row.Cells[(int)InputGridViewCellIndexes.Price].Value),
            //                                                     row.Cells[(int)InputGridViewCellIndexes.Classification].Value.ToString())).Where(data => data.IsEmpty() == false).ToList<OneRecordData>();
            //}
        //}


        /// <summary>
        /// DBから取得したデータをGridに挿入する
        /// </summary>
        internal void ReflectGridFromDB()
        {
            var entities = new Getter().GetData();
            ObservableCollection<OneRecordData> row;
            //2023-03-26 テーブルはあるけど1行もない場合の緊急回避措置を重い腰上げて追加！！
            if (!entities.Any()) {
                row = new ObservableCollection<OneRecordData>();
                row.Add(new OneRecordData(null,null,null));
            }
            else {
                row = new ObservableCollection<OneRecordData>(entities);
            }
            ParentForm.InputGridView.DataContext = row;
            //foreach (OneRecordData item in entities)
            //{
            //ParentForm.InputGridView.Rows.Add(item.PaidDate,item.Price,item.Classification);
            //}
        }
    }
}
