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
            List<string> lstSizerTables;
            WorkbookExtensions.DataDictionary = DDName;

            //Get M61 Data Dictionary
            DataTable m61DataDict;
            //m61DataDict = WorkbookExtensions.GetM61DataDictionary(DDName);
            m61DataDict = M61AddInJSONUtils.GetM61DataDictionary();
            lstSizerTables = M61AddInJSONUtils.GetReqSizerTableNames(m61DataDict);

            //Read Sizer Data
            DataSet dsSizer = new DataSet("Sizer");
            //lstSizerTables = WorkbookExtensions.GetSizerNamedRanges(DDName);
            WorkbookExtensions.LoadSizerTables(lstSizerTables, dsSizer);

            //Serielize the DataSet to JSON
            if (dsSizer.Tables.Count > 0)
            {
                int tableCount = 0;
                Dictionary<string, object> m61params = GetM61CFParameters();
                M61AddInJSONUtils.InitAndAddCFParametersToJSON(m61params);
                foreach (DataTable dt in dsSizer.Tables)
                {
                    M61AddInJSONUtils.SerielizeDataTableToJSON(dt);
                    if (!(tableCount++ == dsSizer.Tables.Count))
                        M61AddInJSONUtils.JSONM61CFInputs += ", ";

                }
                M61AddInJSONUtils.CompleteJSON();
                M61AddInJSONUtils.WriteJsonToFile();
            }
        }

        private Dictionary<string,object> GetM61CFParameters()
        {
            Dictionary<string, object> m61params = new Dictionary<string, object>();
            string sCFOutputType;

            m61params.Add("Calc", this.radCalc.Checked ? "Yes" : "No");
            m61params.Add("Save", this.radSave.Checked ? "Yes" : "No");


            if (this.chkPeriodic.Checked && this.chkTransaction.Checked)
                sCFOutputType = "Transactional, Periodic";
            else if (this.chkTransaction.Checked)
                sCFOutputType = "Transactional";
            else
                sCFOutputType = "Periodic";

            m61params.Add("CFOutputType", sCFOutputType);

            return m61params;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
