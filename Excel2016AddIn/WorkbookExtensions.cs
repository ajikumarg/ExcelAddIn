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
        #region Property
        private static string sheetNameDataDictionary;
        public static string DataDictionary
        {
            get => sheetNameDataDictionary;
            set => sheetNameDataDictionary = value;
        }

        private static string sheetNameM61Input;
        public static string M61Input
        {
            get => sheetNameM61Input;
            set => sheetNameM61Input = value;
        }
        #endregion Property


        #region Utility Functions
        public static IEnumerable<Excel.Name> FilterByM61InputTables(IEnumerable<Excel.Name> tables, string regEx)
        {
            return tables.Where(x => x.Name.StartsWith(regEx)).ToList();
        }

        //Return the Worksheet if it exists, otherwise create a new worksheet and return it.
        public static Excel.Worksheet GetWorksheetByName(string name)
        {
            Excel.Worksheet worksheet;
            Excel.Workbook workbook = Globals.ThisAddIn.Application.ActiveWorkbook;

            worksheet = workbook.Worksheets.OfType<Excel.Worksheet>().FirstOrDefault(ws => ws.Name == name);

            if (worksheet == null)
            {
                worksheet = workbook.Worksheets.Add();
                worksheet.Name = name;
            }
            else
            {
                worksheet.UsedRange.Clear();
                worksheet.UsedRange.ClearContents();
            }


            return worksheet;
        }

        //Walk-Through the range and construct a DataTable
        public static DataTable ExcelRangeToDataTable(Excel.Range range)
        {
            DataTable table = new DataTable();
            //var cells = range.Cells;

            int rows = range.Rows.Count;
            int cols = range.Columns.Count;
            string name, colname;
            Excel.Range target;

            DataRow row;

            for (int c = 1; c <= cols; c++)
            {
                //colname = range.Cells[1, c].Value2;
                target = range.Cells[1, c];
                try
                {
                    name = ((Excel.Name)target.Name).Name;
                    colname = name.Substring(name.LastIndexOf(@"!") + 1);
                }
                catch (System.Runtime.InteropServices.COMException e)
                {
                    colname = target.Value2.ToString();
                }
                table.Columns.Add(colname);
            }

            for (int r = 2; r <= rows; r++)
            {
                row = table.NewRow();
                for (int c = 1; c <= cols; c++)
                    row[c-1] = range.Cells[r, c].Value2;
                table.Rows.Add(row);
            }

            return table;
        }
        public static void PublishNames()
        {
            int iRow = 2;
            System.Text.RegularExpressions.Regex regEx = new System.Text.RegularExpressions.Regex("M61.Table");

            try
            {
                Excel.Worksheet M61InputExp = Globals.ThisAddIn.Application.ActiveWorkbook.Worksheets[1];

                //Add a Sheet to print out the Named Ranges
                Excel.Worksheet newWorksheet;
                newWorksheet = WorkbookExtensions.GetWorksheetByName("NamedRanges");

                //Set as Activesheet
                newWorksheet.Activate();

                //var names = (IEnumerable<Excel.Names>)this.Application.ActiveWorkbook.Names;
                //var namesfiltered = names.Where(x => x..StartsWith(regEx)).ToList();
                //var namesfiltered = FilterByM61InputTables(names, regEx);


                foreach (Excel.Name name in Globals.ThisAddIn.Application.ActiveWorkbook.Names)
                {
                    //Console.WriteLine(String.Format("{0} refers to {1}", name.Name, name.RefersTo));
                    newWorksheet.Range["A" + iRow].Value2 = String.Format("{0}", name.Name);
                    iRow++;
                }
            }
            catch (Exception e)
            {
                //Application.StatusBar = e.Message;
                //Application.ActiveWorkbook.Close(false);
            }
            finally
            {
            }

        }
        #endregion Utilities

        public static DataTable GetM61DataDictionary(string rangeDataDictionary)
        {
            //Method 1
            Excel.Workbook wb = Globals.ThisAddIn.Application.ActiveWorkbook;
            Excel.Worksheet worksheetdict=Globals.ThisAddIn.Application.ActiveWorkbook.Sheets[DataDictionary];
            //Excel.Range range = worksheetdict.Range["DataDictionary"];
            Excel.Range range = worksheetdict.Range[rangeDataDictionary];

            //Convert to DataTable 
            return ExcelRangeToDataTable(range);
            
            ////Method 2
            //foreach (Excel.Name n in wb.Names)
            //    if (n.Name.ToString() == rangeDataDictionary)
            //        range = n.RefersToRange;

            ////Convert to DataTable 
            //return ExcelRangeToDataTable(range);
        }


        public static List<string> GetSizerNamedRanges(string rangeDataDictionary)
        {
            //string sheetName = "DataDictionary";
            string TableName = string.Empty;
            List<string> m61NamedRanges = new List<string>();

            DataTable dtDict = GetM61DataDictionary(rangeDataDictionary);

            try
            {
                foreach (DataRow row in dtDict.Rows)
                {
                    TableName = row["TableName"].ToString();
                    if(!m61NamedRanges.Contains(TableName))
                        m61NamedRanges.Add(row["TableName"].ToString());
                }
            }
            catch (ArgumentException)
            {
                //Console.WriteLine("An element with Key = \"txt\" already exists.");
            }

            return m61NamedRanges;
        }


        public static void LoadSizerTables(List<string> listTables,DataSet dsSizer)
        {
            DataTable table;

            Excel.Names SizerNamedRanges = Globals.ThisAddIn.Application.ActiveWorkbook.Names;

            foreach (Excel.Name name in SizerNamedRanges)
            {
                string val = name.Name;
                if (listTables.Contains(name.Name.ToString()))
                {
                    table = ExcelRangeToDataTable(name.RefersToRange);
                    table.TableName = name.Name;
                    dsSizer.Tables.Add(table);
                }
            }
        }


    }
}
