﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TableExistCheck()
        {
            var testObj = new DBConnector.Controller.MoneyUsedDataTableManager();
            Console.WriteLine($"Is Exist Table ? ANS={testObj.IsExistMonetaryTable("TEST")}");
        }

        [TestMethod]//DB上にある月別利用額テーブル名の取得テスト
        public void GetMonthlyTableNameTest()
        {
            var testObj = new DBConnector.Controller.MoneyUsedDataTableManager();
            var names = testObj.MonthlyTableNames();
            foreach (string name in names)
            {
                var words = name.Split('-');
                Console.WriteLine($"{name}");
                Console.WriteLine($"{words[0]},{words[1]}");
            }
        }

        [TestMethod]//月別利用額テーブルの作成テスト
        public void CreateTable()
        {
            var testObj = new DBConnector.Controller.MoneyUsedDataTableManager();
            testObj.CreateTable("TEST");
            Console.WriteLine($"Is Exist Table ? ANS={testObj.IsExistMonetaryTable("TEST")}");
        }

        [TestMethod]//月別利用額テーブルの消去テスト
        public void InitializeTable()
        {
            var testObj = new DBConnector.Controller.MoneyUsedDataTableManager();
            testObj.InitializeTable("TEST");
        }

        [TestMethod]//月別利用額テーブルのデータ挿入テスト
        public void InsertTable()
        {
            string tableName = "TEST";
            var testObj = new DBConnector.Accessor.MoneyUsedDataAccessor(tableName);
            var testManger = new DBConnector.Controller.MoneyUsedDataTableManager();

            if (testManger.IsExistMonetaryTable(tableName)) { testManger.InitializeTable(tableName); }
            else { testManger.CreateTable(tableName); }

            var uploadObj = new List<DBConnector.Entity.MoneyUsedDataEntity>
            {
                new DBConnector.Entity.MoneyUsedDataEntity { ID = 1, Date = "1999/01/02", Price = -15000, Classification = "?" },
                new DBConnector.Entity.MoneyUsedDataEntity { ID = 2, Date = "1999/01/02", Price = 108, Classification = "2" }
            };

            testObj.UploadMonetaryData(uploadObj);
            testObj.GetMonetarydata();
            foreach (DBConnector.Entity.MoneyUsedDataEntity data in testObj.MoneyUsedDataEntitiesFromTable)
            {
                Console.WriteLine($"{data.ID}|{data.Date}|{data.Price}|{data.Classification}");
            }

        }
        [TestMethod]//月別利用額テーブルのデータ更新テスト
        public void UpdateTable()
        {
            string tableName = "TEST";
            var testObj = new DBConnector.Accessor.MoneyUsedDataAccessor(tableName);
            var testManger = new DBConnector.Controller.MoneyUsedDataTableManager();

            if (testManger.IsExistMonetaryTable(tableName)) { testManger.InitializeTable(tableName); }
            else { testManger.CreateTable(tableName); }

            var uploadObj = new List<DBConnector.Entity.MoneyUsedDataEntity>
            {
                new DBConnector.Entity.MoneyUsedDataEntity { ID = 1, Date = "1999/01/02", Price = -15000, Classification = "8" },
                new DBConnector.Entity.MoneyUsedDataEntity { ID = 2, Date = "1999/01/02", Price = 108, Classification = "3" },
                new DBConnector.Entity.MoneyUsedDataEntity { ID = 3, Date = "1999/01/02", Price = 108, Classification = "2" }
            };

            testObj.UploadMonetaryData(uploadObj);
            testObj.GetMonetarydata();
            foreach (DBConnector.Entity.MoneyUsedDataEntity data in testObj.MoneyUsedDataEntitiesFromTable)
            {
                Console.WriteLine($"{data.ID}|{data.Date}|{data.Price}|{data.Classification}");
            }

        }
        [TestMethod]//月別利用額テーブルのデータ更新テスト
        public void DeleteTable()
        {
            string tableName = "TEST";
            var testObj = new DBConnector.Accessor.MoneyUsedDataAccessor(tableName);
            var testManger = new DBConnector.Controller.MoneyUsedDataTableManager();

            if (testManger.IsExistMonetaryTable(tableName)) { testManger.InitializeTable(tableName); }
            else { testManger.CreateTable(tableName); }

            var uploadObj = new List<DBConnector.Entity.MoneyUsedDataEntity>
            {
                new DBConnector.Entity.MoneyUsedDataEntity { ID = 1, Date = "1999/01/02", Price = -15000, Classification = "8" },
                new DBConnector.Entity.MoneyUsedDataEntity { ID = 3, Date = "1999/01/02", Price = 108, Classification = "2" }
            };

            testObj.UploadMonetaryData(uploadObj);
            testObj.GetMonetarydata();
            foreach (DBConnector.Entity.MoneyUsedDataEntity data in testObj.MoneyUsedDataEntitiesFromTable)
            {
                Console.WriteLine($"{data.ID}|{data.Date}|{data.Price}|{data.Classification}");
            }

        }
        [TestMethod]//月単位の合計利用金額を取得するテスト
        public void GetMontlySumTEST()
        {
            var obj = new DBConnector.Controller.MoneyUsedDataTableManager();
            Console.WriteLine(obj.GetMonthlyPrice("2021", "03"));
        }

        [TestMethod]//月単位の残額を取得するテスト
        public void GetMontlyBalanceTEST()
        {
            var obj = new DBConnector.Accessor.MonthlyFundAccessor();
            var obj2 = new DBConnector.Controller.MoneyUsedDataTableManager();
            //月初日のデータが無い場合（前月の月別テーブルは存在する）-> これエラーケースなのでテストしない
            //Console.WriteLine(obj.GetMonthFirstBalance(2020, 5));

            //月初日のデータが無い場合（前月の月別テーブルと前月初日の残額情報はある）
            Console.WriteLine(obj.GetMonthFirstBalance(2021, 5));
            //月初日のデータがない場合（1か月前の月別テーブルと前月初日の残額情報が存在しない）
            int[] searchyear = { 2021, 8 };
            if (obj2.IsExistMonetaryTable($"{searchyear[0]}-{searchyear[1].ToString("00")}") == false) { obj2.CreateTable($"{searchyear[0]}-{searchyear[1].ToString("00")}"); }

            Console.WriteLine(obj.GetMonthFirstBalance(searchyear[0], searchyear[1]));
        }
    }
}
