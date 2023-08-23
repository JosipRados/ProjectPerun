using Newtonsoft.Json;
using ProjectPerunDesktop.Models;
using ProjectPerunDesktop;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ProjectPerun.DataSets;

namespace ProjectPerun.APICalls
{
    internal class MaterialDataCalls
    {
        internal static APIResponseModel GetMaterialData()
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "material-data");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result.Replace("MAT_", ""));
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        internal static APIResponseModel InsertMaterialData(DSMaterialData materialData)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "material-data");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(materialData.MaterialData);
                    json = "{\"materialData\" : " + json + "}";
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result);
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        internal static APIResponseModel UpdateMaterialData(DSMaterialData materialData)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "material-data");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(materialData.MaterialData);
                    json = "{\"materialData\" : " + json + "}";
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result);
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        internal static APIResponseModel DeleteMaterialData(DSMaterialData materialData)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "material-data");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "DELETE";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(materialData.MaterialData);
                    json = "{\"materialData\" : " + json + "}";
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result);
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }
    }
}
