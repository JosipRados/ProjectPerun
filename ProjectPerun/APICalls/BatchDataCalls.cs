using Newtonsoft.Json;
using ProjectPerun.DataSets;
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

namespace ProjectPerun.APICalls
{
    internal class BatchDataCalls
    {
        internal static APIResponseModel GetBatchData()
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "batch");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result.Replace("BAT_", ""));
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        internal static APIResponseModel GetOneBatchData(int batchID)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "batch/" + batchID.ToString());
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result.Replace("BAT_", ""));
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        internal static APIResponseModel InsertBatchData(DSBatchData dsBatchData)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "batch");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(dsBatchData.BatchTable);
                    json = "{\"BatchData\" : " + json + "}";

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

        internal static APIResponseModel UpdateBatchData(DSBatchData dsBatchData)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "batch");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(dsBatchData.BatchTable);
                    json = "{\"BatchData\" : " + json + "}";

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

        internal static APIResponseModel DeleteBatchData(DSBatchData dsBatchData)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "batch");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "DELETE";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(dsBatchData.BatchTable);
                    json = "{\"BatchData\" : " + json + "}";

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

        internal static APIResponseModel GetNewBatchID()
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "batch/batch-number");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

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
