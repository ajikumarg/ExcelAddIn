using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.IO;
using Newtonsoft.Json;

namespace Excel2016AddIn
{
    class M61AddInJSONUtils
    {
        #region Properties

        private static string _jsonM61DataDict;
        public static string JSONM61DataDict
        {
            get => _jsonM61DataDict;
            set => _jsonM61DataDict = value;
        }
        private static string _jsonM61CFInputs;
        public static string JSONM61CFInputs
        {
            get => _jsonM61CFInputs;
            set => _jsonM61CFInputs = value;
        }


        #endregion 

        public static DataTable GetM61DataDictionary()
        {
            DataTable dtM61Dict;

            string FullFilePath = @"C:\temp\M61DataDictionary.json";
            M61AddInJSONUtils.JSONM61DataDict =  File.ReadAllText(FullFilePath);

            dtM61Dict = JsonConvert.DeserializeObject<DataTable>(M61AddInJSONUtils.JSONM61DataDict);
            return dtM61Dict;
        }
        public static void InitAndAddCFParametersToJSON(IDictionary<string, string> Params)
        {
            M61AddInJSONUtils.JSONM61CFInputs = string.Empty;
            JSONM61CFInputs += "[";
            foreach(string Param in Params.Keys)
            {
                
            }



        }
        public static string DataTableToJson(DataTable dt)
        {
            DataSet ds = new DataSet();
            ds.Merge(dt);
            StringBuilder JsonString = new StringBuilder();
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                JsonString.Append("[");
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    JsonString.Append("{");
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        if (j < ds.Tables[0].Columns.Count - 1)
                        {
                            JsonString.Append("\"" + ds.Tables[0].Columns[j].ColumnName.ToString() + "\":" + "\"" + ds.Tables[0].Rows[i][j].ToString() + "\",");
                        }
                        else if (j == ds.Tables[0].Columns.Count - 1)
                        {
                            JsonString.Append("\"" + ds.Tables[0].Columns[j].ColumnName.ToString() + "\":" + "\"" + ds.Tables[0].Rows[i][j].ToString() + "\"");
                        }
                    }
                    if (i == ds.Tables[0].Rows.Count - 1)
                    {
                        JsonString.Append("}");
                    }
                    else
                    {
                        JsonString.Append("},");
                    }
                }
                JsonString.Append("]");
                return JsonString.ToString();
            }
            else
            {
                return null;
            }
        }

        public static string SerielizeToJSON(DataTable table)
        {
            string jsonResult = JsonConvert.SerializeObject(table, Formatting.Indented);
            return jsonResult;

        }
        public static void WriteJsonToFile(string FullFilePath = @"C:\temp\M61CFRequest.json")
        {
            if (FullFilePath == "")
                FullFilePath = @"C:\temp\M61CFRequest.json";

            FileInfo fi = new FileInfo(FullFilePath);

            if (!Directory.Exists(fi.DirectoryName))
            {
                Directory.CreateDirectory(fi.DirectoryName);
            }

            File.WriteAllText(FullFilePath, M61AddInJSONUtils.JSONM61CFInputs);
        }


    }
}
