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
    internal class WarehouseDataCalls
    {
        internal static APIResponseModel GetWarehouseData()
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "Warehouse");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result.Replace("WAR_", ""));
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        internal static APIResponseModel GetOneWarehouseData(int WarehouseID)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "Warehouse/" + WarehouseID.ToString());
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result.Replace("WAR_", ""));
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        internal static APIResponseModel InsertWarehouseData(DSWarehouse dsWarehouseData)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "Warehouse");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(dsWarehouseData.Warehouse);
                    json = "{\"WarehouseData\" : " + json + "}";

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

        internal static APIResponseModel UpdateWarehouseData(DSWarehouse dsWarehouseData)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "Warehouse");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(dsWarehouseData.Warehouse);
                    json = "{\"WarehouseData\" : " + json + "}";

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

        internal static APIResponseModel DeleteWarehouseData(DSWarehouse dsWarehouseData)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "Warehouse");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "DELETE";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string json = JsonConvert.SerializeObject(dsWarehouseData.Warehouse);
                    json = "{\"WarehouseData\" : " + json + "}";

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
