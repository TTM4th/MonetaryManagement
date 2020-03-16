using MonetaryManagementAccessor.Entity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonetaryManagementAccessor.Accessor
{
    public class DBAccessor
    {

        private UsingData UsingData { get; }
        public IReadOnlyList<MoneyData> MoneyDataSet { private set; get; }

        public DBAccessor()
        {
            UsingData = new UsingData();
        }

        public void GetMoneyData() {
            MoneyDataSet=UsingData.MoneyDataSet.ToList<MoneyData>();
        }
    }
}
