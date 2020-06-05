using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MonetaryManagement.File
{
    class KeyBreak
    {

        private bool isfirst;
        private MonetaryManagement.File.Data mydata;
        private StreamReader mystreamReader;
        /// <summary>
        /// コンストラクタ(初回読み込み)
        /// </summary>
        /// <param name="_data"></param>
        KeyBreak(string _key,Data _data,StreamReader _streamReader)
        {
            isfirst = true;
            key = _key;
            mydata = _data;
            mystreamReader = _streamReader;
        }
        /// <summary>
        /// 読み取りモード
        /// </summary>
        public enum Mode { Shokai=0,tsuzuki }
        private string key;
        private string prevkey;

        /// <summary>
        /// ブレーク処理実行
        /// </summary>
        /// <param name="path">ファイルパス情報</param>
        public List<string> Read(string @path)
        {
            mystreamReader=new StreamReader(@path,Encoding.GetEncoding("Shift_JIS"));

                while (mystreamReader.EndOfStream == false)
                {
                    mydata.SetData(mystreamReader.ReadLine());
                    //初行処理か否かの判別
                    //初回なら前キーを設定
                    if (isfirst == true) {prevkey = key;}

                    else { if (key == "") { key = prevkey; } }

                    //補定処理
                    if (key != "" && key != prevkey) { prevkey = key; }
                         
                }
            }


    }
}
