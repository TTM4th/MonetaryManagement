﻿using DBConnector.Data;
using FundRegister.Definition;
using FundRegister.FrontEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace FundRegister.Controller
{
    class DataController
    {

        //送信元のフォームオブジェクト
        private readonly RegisterForm ParentForm;

        /// <summary>
        /// セット先のインデックス情報を状況に応じて返す（非選択の場合/選択している場合）
        /// </summary>
        /// <returns>セット先の行インデックス情報</returns>
        private int TargetIndex => ParentForm.InputGridView.CurrentRow.Index;

        /// <summary>
        /// 使用金額区分フラグリスト
        /// </summary>
        private readonly IEnumerable<Classifications.Classification> Classifications;

        /// <summary>
        /// 金額使用DB操作オブジェクト
        /// </summary>
        private readonly IMoneyUsedData _moneyUsedData;

        /// <summary>
        /// InputGridviewに入力した項目をIReadOnlyList形式で取得する
        /// </summary>
        private IReadOnlyList<DataGridViewRow> InputDataList => ParentForm.InputGridView.Rows.OfType<DataGridViewRow>().ToList();

        /// <summary>
        /// InputGridViewの各セルの有効値チェック関数リスト
        /// </summary>
        private readonly IEnumerable<Func<DataGridViewRow, bool>> IsExistInValidColumnFuncs;

        /// <summary>
        /// データ登録ができる行が一つもないかどうか判別する
        /// </summary>
        private bool IsZeroRows => this.InputDataList.All(row => this.IsExistInValidColumnFuncs.All(fnc => fnc(row)));

        /// <summary>
        /// データ登録にあたって無効値を含む行が存在するか判別する
        /// </summary>
        internal bool HasInValidRows => this.InputDataList.Any(row => this.IsExistInValidColumnFuncs.Any(fnc => fnc(row)));

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="parntFormObj">親にしたいRegisterForm</param>
        internal DataController(RegisterForm parntFormObj, IMoneyUsedData moneyUsedData) {
            ParentForm = parntFormObj;
            Classifications = new Classifications().ClassificationItems;
            _moneyUsedData = moneyUsedData;
            IsExistInValidColumnFuncs = new List<Func<DataGridViewRow, bool>>
            {
                row => row.Cells[(int)InputGridViewCellIndexes.ID].Value is null,
                row => row.Cells[(int)InputGridViewCellIndexes.Price].Value is null ? true : 
                        decimal.TryParse(row.Cells[(int)InputGridViewCellIndexes.Price].Value.ToString(), out decimal price) == false,
                row => row.Cells[(int)InputGridViewCellIndexes.Date].Value is null,
                row => row.Cells[(int)InputGridViewCellIndexes.Classification].Value is null
            };
        }

        /// <summary>
        /// 「区分」リストボックスのマッピング処理
        /// </summary>
        internal void InitializeKubunListBox()
        {
            ParentForm.KubunListBox.Items.
                AddRange(this.Classifications.Select(item => item.FormItem).ToArray());
        }

        #region DataGridViewの選択行各列項目プロパティ
        /// <summary>
        /// GridViewの支払い日付欄の日付を取得・設定する
        /// </summary>
        internal string PaidDate_gv
        {
            set { ParentForm.InputGridView.Rows[TargetIndex].Cells[(int)InputGridViewCellIndexes.Date].Value = value; }
        }


        /// <summary>
        /// GridViewの区分欄の区分を取得・設定する
        /// </summary>
        internal string Classification_gv
        {
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
        /// 行追加時に行う処理
        /// </summary>
        internal void AppendNewRowAction()
        {
            ParentForm.InputGridView.Rows.Add();
            int newRowIndex = ParentForm.InputGridView.Rows.GetLastRow(DataGridViewElementStates.None);
            int newid = (int)ParentForm.InputGridView.Rows.OfType<DataGridViewRow>().Max(x => x.Cells[(int)InputGridViewCellIndexes.ID].Value) + 1;
            ParentForm.InputGridView.Rows[newRowIndex].Cells[(int)InputGridViewCellIndexes.ID].Value = newid;
            ParentForm.InputGridView.CurrentCell = ParentForm.InputGridView.Rows[newRowIndex].Cells[(int)InputGridViewCellIndexes.Date];
        }

        /// <summary>
        /// 無効値を含む最初の行に移動する処理
        /// </summary>
        internal void MoveToFirstInValidRow()
        {
            MessageBox.Show("入力欄に有効な値を入力してください");
            var targetindex = this.InputDataList.First(row => this.IsExistInValidColumnFuncs.Any(fnc => fnc(row))).Index;
            ParentForm.InputGridView.CurrentCell = null;
            ParentForm.InputGridView.ClearSelection();
            ParentForm.InputGridView.Rows[targetindex].Selected = true;
            ParentForm.InputGridView.CurrentCell = ParentForm.InputGridView[(int)InputGridViewCellIndexes.Date, targetindex];
            ParentForm.InputGridView.FirstDisplayedScrollingRowIndex = targetindex;
        }

        /// <summary>
        /// GridのデータをDBに反映させる
        /// </summary>
        internal void ReflectToDB()
        {
            if (this.IsZeroRows)
            { 
                _moneyUsedData.DeleteMonetaryData(State.TargetYear, State.TargetMonth);
                return;
            }
            else if (this.HasInValidRows)
            {
                this.MoveToFirstInValidRow();
                return;
            }
            var uploaddata = this.InputDataList.Select(x => new DBConnector.Entity.MoneyUsedDataEntity()
            {
                ID = (int)x.Cells[(int)InputGridViewCellIndexes.ID].Value,
                Date = x.Cells[(int)InputGridViewCellIndexes.Date].Value.ToString(),
                Price = Convert.ToDecimal(x.Cells[(int)InputGridViewCellIndexes.Price].Value),
                Classification = x.Cells[(int)InputGridViewCellIndexes.Classification].Value.ToString()
            })
            .Where(data => !(data.Date is null || data.Classification is null)).ToList();
            _moneyUsedData.UploadMonetaryData(uploaddata, State.TargetYear, State.TargetMonth);
            ParentForm.InputGridView.Rows.Clear();
            this.ReflectGridFromDB();
        }

        /// <summary>
        /// DBから取得したデータをGridに挿入する
        /// </summary>
        internal void ReflectGridFromDB()
        {
            var data = _moneyUsedData.LoadMoneyUsedData(State.TargetYear, State.TargetMonth);
            if (!(data?.Any() ?? false)) {
                ParentForm.InputGridView.Rows.Add();
                ParentForm.InputGridView.Rows[0].Cells[(int)InputGridViewCellIndexes.ID].Value = 1;
                return;
            }
            foreach(DBConnector.Entity.MoneyUsedDataEntity entity in data)
            {
                ParentForm.InputGridView.Rows.Add(entity.ID,entity.Date,entity.Price,entity.Classification);
            }
            
        }
    }
}
