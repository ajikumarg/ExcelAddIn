using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using ExcelDataReader;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace Excel2016AddIn
{
    public static class WorkbookExtensions
    {
        //Return the Worksheet if it exists, otherwise create a new worksheet and return it.
        public static Excel.Worksheet GetWorksheetByName(string name)
        {
            Excel.Worksheet worksheet;
            Excel.Workbook workbook = Globals.ThisAddIn.Application.ActiveWorkbook;

            worksheet = workbook.Worksheets.OfType<Excel.Worksheet>().FirstOrDefault(ws => ws.Name == name);

            if (worksheet == null)
                worksheet = workbook.Worksheets.Add();
            return worksheet;
        }

        //Walk-Through the range and construct a DataTable
        public static DataTable ExcelRangeToDataTable(Excel.Range range)
        {
            Excel.Worksheet ws = Globals.ThisAddIn.Application.ActiveSheet;
            DataTable table = new DataTable();
            //var cells = range.Cells;

            int rows = range.Rows.Count;
            int cols = range.Columns.Count;
            string colname;

            DataRow row;

            for (int c = 1; c <= cols; c++)
            {
                colname = range.Cells[1, c].Value2;
                table.Columns.Add(colname);
            }

            for (int r = 2; r <= rows; r++)
            {
                row = table.NewRow();
                for (int c = 1; c < cols; c++)
                    row[c] = range.Cells[r, c].Value2;
            }

            return table;
        }

        public static DataTable GetDataDictionary(string path, string sheetName)
        {
            DataTable table = new DataTable();
            using (FileStream fileStream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader = ExcelDataReader.ExcelReaderFactory.CreateReader(fileStream);
            }
            return table;
        }

        public static DataTable GetM61DataDictionary(string sheetName)
        {
            Excel.Workbook wb = Globals.ThisAddIn.Application.ActiveWorkbook;
            Excel.Worksheet sheet = wb.Worksheets[sheetName];

            #region ListObject
            //foreach (Excel.ListObject lo in sheet.ListObjects)
            //{
            //    Excel.Range srcRow = lo.DataBodyRange;
            //    Excel.ListRow oLastRow = wb.Worksheets["Sheet2"].ListObjects["table1"].ListRows.Add();
            //    srcRow.Copy();
            //    oLastRow.Range.PasteSpecial(Excel.XlPasteType.xlPasteValues);
            //}
            #endregion 

            //Add a Sheet to print out the Named Ranges
            Excel.Worksheet worksheetdict=Globals.ThisAddIn.Application.ActiveWorkbook.Sheets["DataDictionary"];
            Excel.Range range = worksheetdict.Range["DataDictionary"];

            //Copy-Paste to  new Worksheet to doublecheck values
            Excel.Worksheet worksheetnew = WorkbookExtensions.GetWorksheetByName("DataDictionary2");
            
            worksheetnew.Range["A1"].Value = range.Value;

            //Convert to DataTable 
            return ExcelRangeToDataTable(range);
        }

        public static Dictionary<string, string> GetNamedRanges(string sheetName)
        {
            Dictionary<string, string> M61Names = new Dictionary<string, string>();
            DataTable dtDict = GetM61DataDictionary(sheetName);

            foreach (DataRow r in dtDict.Rows)
            {
                if ((int)r["Required"] == 1)
                    M61Names.Add(r["TableName"].ToString(),r["FieldName"].ToString());
            }
            return M61Names;
        }
    }
}
