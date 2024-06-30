using DBConnector.Entity;
using MonetaryManagementDefinitions.Flags;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class SumByClass : UserControl
    {

        private Dictionary<string, string> item;

        private Dictionary<string, Label> SumPriceLabels;

        public SumByClass()
        {
            InitializeComponent();
            item = new Dictionary<string, string>
            {
                { ClassificationFlags.UnchinName, ClassificationFlags.UnchinFlag },
                { ClassificationFlags.InshokuName, ClassificationFlags.InshokuFlag },
                { ClassificationFlags.NichiyouHinName, ClassificationFlags.NichiyouHinFlag },
                { ClassificationFlags.GorakuName, ClassificationFlags.GorakuFlag },
                { ClassificationFlags.IruiName, ClassificationFlags.IruiFlag },
                { ClassificationFlags.ShoumouHinName, ClassificationFlags.ShomouHinFlag },
                { ClassificationFlags.ServiceHiName, ClassificationFlags.ServiceHiFlag },
                { ClassificationFlags.AzukeIreName, ClassificationFlags.AzukeIreFlag },
                { ClassificationFlags.MibunruiName, ClassificationFlags.MibunruiFlag }
            };
            SumPriceLabels = new Dictionary<string,Label> 
            { { ClassificationFlags.UnchinName, label1 },
                { ClassificationFlags.InshokuName, label2 },
                { ClassificationFlags.NichiyouHinName, label3 },
                { ClassificationFlags.GorakuName, label4 },
                { ClassificationFlags.IruiName, label5 },
                { ClassificationFlags.ShoumouHinName, label6 },
                { ClassificationFlags.ServiceHiName, label7 },
                { ClassificationFlags.AzukeIreName, label8 },
                { ClassificationFlags.MibunruiName, label9 }
            };
        }

        public void RelfectFromUsedData(IDictionary<string, decimal> data)
        {
            foreach (KeyValuePair<string, Label> valuePair in SumPriceLabels)
            {
                valuePair.Value.Text = $"{valuePair.Key}　：￥　{data[item[valuePair.Key]]}";
            }
        }

    }

}
