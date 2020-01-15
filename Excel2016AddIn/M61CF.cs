 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel2016AddIn
{
    public partial class M61CF : Form
    {
        public M61CF()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string DDName = "DataDictionary";
            WorkbookExtensions.DataDictionary = DDName;

            //Get M61 Data Dictionary
            //DataTable m61DataDict;
            //m61DataDict = WorkbookExtensions.GetM61DataDictionary(DDName);

            //Globals.ThisAddIn.PublishNames();

            //Read Sizer Data
            DataSet dsSizer = new DataSet("Sizer");
            List<string> sizerTables = WorkbookExtensions.GetSizerNamedRanges(DDName);

            WorkbookExtensions.LoadSizerTables(sizerTables, dsSizer);


            //Serielize the DataSet to JSON
            string JsonDeal = M61AddInJSONUtils.SerielizeToJSON(dsSizer.Tables[0]);
            M61AddInJSONUtils.WriteJsonToFile(JsonDeal);

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
