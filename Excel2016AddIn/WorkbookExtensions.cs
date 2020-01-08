using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace Excel2016AddIn
{
    public static class WorkbookExtensions
    {
        public static Excel.Worksheet GetWorksheetByName(this Excel.Workbook workbook, string name)
        {
            return workbook.Worksheets.OfType<Excel.Worksheet>().FirstOrDefault(ws => ws.Name == name);
        }
    }
}
