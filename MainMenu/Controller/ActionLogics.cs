﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMenu.Controller
{
    class ActionLogics
    {
        /// <summary>
        /// 送信元のフォームオブジェクトインスタンス
        /// </summary>
        private MenuForm ParentForm { get; }

        private DataController DataController { get; }

        internal ActionLogics(MenuForm menuForm)
        {
            ParentForm = menuForm;
            DataController = new DataController();
        }

        /// <summary>
        /// 現在残高をフォームに反映させる
        /// </summary>
        internal void ReflectNowBalance()
        {
            ParentForm.NowBalance.Text = DataController.GetCurrentBalance().ToString();
            ParentForm.NowBalance.Update();
        }

    }
}