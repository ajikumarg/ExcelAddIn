using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Excel2016AddIn
{
    public partial class M61Ribbon
    {
        private void M61Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            lblTime.Label = "Load Time: " + DateTime.Now.ToString();
        }

        private void btnRunCF_Click(object sender, RibbonControlEventArgs e)
        {
            //AboutBox1 abtBox = new AboutBox1();
            //abtBox.Show();
            M61CF m61CF = new M61CF();
            m61CF.Show();
        }

        private void btnAbout_Click(object sender, RibbonControlEventArgs e)
        {
            AboutBox1 abtBox = new AboutBox1();
            abtBox.Show();
        }
    }
}
