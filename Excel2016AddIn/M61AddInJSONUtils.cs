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
            Dictionary<string, object> m61DictApiResponse = new Dictionary<string, object>();
            DataTable dtM61Dict=new DataTable("M61DataDictionary");

            string FullFilePath = @"C:\temp\M61DataDictionaryFull.json";
            M61AddInJSONUtils.JSONM61DataDict =  File.ReadAllText(FullFilePath);
            m61DictApiResponse =  JsonConvert.DeserializeObject<Dictionary<string, object>>(M61AddInJSONUtils.JSONM61DataDict);
            if (Convert.ToBoolean(m61DictApiResponse["Succeeded"]))
            {
                //dtM61Dict = JsonConvert.DeserializeObject<DataTable>(M61AddInJSONUtils.JSONM61DataDict);
                //var response = JsonConvert.DeserializeObject(M61AddInJSONUtils.JSONM61DataDict);
                dtM61Dict = JsonConvert.DeserializeObject<DataTable>(JsonConvert.SerializeObject(m61DictApiResponse["DataDictionaryList"]));
            }
            return dtM61Dict;
        }

        public static List<string> GetReqSizerTableNames(DataTable m61DataDict) 
        {
            List<string> lstTables = new List<string>();

            #region LINQ Query
            //var reqTables = from names in m61DataDict.AsEnumerable()
            //                where names["Required"] == "1"
            //                select names;
            //foreach (DataRow reqTable in reqTables)
            //{
            //    if (!lstTables.Contains(reqTable["NamedRange"].ToString()))
            //        lstTables.Add(reqTable["NamedRange"].ToString());
            //}
            #endregion

            foreach (DataRow dr in m61DataDict.Rows)
                if (dr["Required"].ToString() == "1" && !lstTables.Contains(dr["NamedRange"].ToString()))
                    lstTables.Add(dr["NamedRange"].ToString());

            return lstTables;
        }
        public static void InitAndAddCFParametersToJSON(IDictionary<string, object> Params)
        {
            M61AddInJSONUtils.JSONM61CFInputs = string.Empty;
            JSONM61CFInputs = "{";
            foreach(string Param in Params.Keys)
            {
                JSONM61CFInputs += "\"" + Param.ToString() + "\": " + "\"" + Params[Param].ToString() + "\",";
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

        public static void SerielizeDataTableToJSON(DataTable table)
        {
            JSONM61CFInputs += "\"" + table.TableName + "\": ";
            JSONM61CFInputs+=JsonConvert.SerializeObject(table, Formatting.Indented);
        }

        public static void CompleteJSON()
        {
            M61AddInJSONUtils.JSONM61CFInputs += "}";
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
