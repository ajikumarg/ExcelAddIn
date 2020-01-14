using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using ExcelDataReader.Core;
using ExcelDataReader.Exceptions;
using ExcelDataReader.Log.Logger;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace Excel2016AddIn
{
    public static class ReadExcelData
    {
		public static IEnumerable<Recipient> GetData(string path, string worksheetName, bool isFirstRowAsColumnNames = true)
		{
			return new ExcelData(path).GetData(worksheetName, isFirstRowAsColumnNames)
				.Select(dataRow => new Recipient()
				{
					Municipality = dataRow["Municipality"].ToString(),
					Sexe = dataRow["Sexe"].ToString(),
					LivingArea = dataRow["LivingArea"].ToString()
				});
		}

		private static IExcelDataReader GetExcelDataReader(string path, bool isFirstRowAsColumnNames)
		{
			using (FileStream fileStream = File.Open(path, FileMode.Open, FileAccess.Read))
			{
				IExcelDataReader dataReader;

				if (path.EndsWith(".xls"))
					dataReader = ExcelReaderFactory.CreateBinaryReader(fileStream);
				else if (path.EndsWith(".xlsx"))
					dataReader = ExcelReaderFactory.CreateOpenXmlReader(fileStream);
				else
					throw new FileToBeProcessedIsNotInTheCorrectFormatException("The file to be processed is not an Excel file");

				dataReader.IsFirstRowAsColumnNames = isFirstRowAsColumnNames;
				return dataReader;
			}
		}

		private static DataSet GetExcelDataAsDataSet(string path, bool isFirstRowAsColumnNames)
		{
			return GetExcelDataReader(path, isFirstRowAsColumnNames).AsDataSet();
		}

		private static DataTable GetExcelWorkSheet(string path, string workSheetName, bool isFirstRowAsColumnNames)
		{
			DataTable workSheet = GetExcelDataAsDataSet(path, isFirstRowAsColumnNames).Tables[workSheetName];
			if (workSheet == null)
				throw new WorksheetDoesNotExistException(string.Format("The worksheet {0} does not exist, has an incorrect name, or does not have any data in the worksheet", workSheetName));
			return workSheet;
		}

		private static IEnumerable<DataRow> GetData(string path, string workSheetName, bool isFirstRowAsColumnNames = true)
		{
			return from DataRow row in GetExcelWorkSheet(path, workSheetName, isFirstRowAsColumnNames).Rows select row;
		}

		public static void Test()
		{
			ExcelDataReader.ExcelReaderFactory.CreateReader();

		}
	}
}
