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
            //Get M61 Data Dictionary
            DataTable m61DataDict;
            m61DataDict=WorkbookExtensions.GetM61DataDictionary("DataDictionary");

            //Globals.ThisAddIn.PublishNames();

            //Read Sizer Data
            DataSet dsSizer = new DataSet("Sizer");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
