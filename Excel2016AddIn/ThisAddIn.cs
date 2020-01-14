using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace Excel2016AddIn
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        public void PublishNames()
        {
            int iRow = 2;

            try
            {
                Excel.Worksheet M61InputExp = Application.ActiveWorkbook.Worksheets[1];

                //Add a Sheet to print out the Named Ranges
                Excel.Worksheet newWorksheet;
                newWorksheet = WorkbookExtensions.GetWorksheetByName("NamedRanges");

                //newWorksheet = (Excel.Worksheet)this.Application.Worksheets.Add();
                //newWorksheet.Name = "NamedRanges";

                //Set as Activesheet
                newWorksheet.Activate();
                //Excel.Names names = this.Application.ActiveWorkbook.Names;
                //var names = (IEnumerable<Excel.Names>)this.Application.ActiveWorkbook.Names;
                //var namesfiltered = names.Where()


                foreach (Excel.Name name in this.Application.ActiveWorkbook.Worksheets[1].Names)
                {

                    //Console.WriteLine(String.Format(
                    //"{0} refers to {1}", name.Name, name.RefersTo));
                    newWorksheet.Range["A" + iRow].Value2 = String.Format("{0} refers to {1}", name.Name, name.RefersTo);
                    iRow++;

                }
            } catch(Exception e)
            {
                Application.StatusBar = e.Message;
                Application.ActiveWorkbook.Close(false);
            }
            finally
            {
                Application.ActiveWorkbook.Close(true);
            }

        }



        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
