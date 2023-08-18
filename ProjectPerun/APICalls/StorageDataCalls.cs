using Newtonsoft.Json;
using ProjectPerunDesktop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerunDesktop.DataCalls
{
    internal class StorageDataCalls
    {
        internal static APIResponseModel GetStorageData()
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath+ "storage/all/1");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                //{
                //    string json = "{\"CustomerQuoteId\": \"" + customerQuoteId + "\", \"DATAAREAID\": " + dataAreaId + "\"}";
                //    streamWriter.Write(json);
                //}

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result.Replace("STO_",""));
            }
            catch(Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        //internal static async Task<APIResponseModel> InsertStorageData(DataTable dataTable)
        //{
        //    //HttpClient client = new()
        //    //{
        //    //    BaseAddress = new Uri(Global.basePath)
        //    //};

        //    //using HttpRequestMessage request = new(HttpMethod.Get, "storage/all/1");
        //    ////request.Headers.Add("user_key", tokens[0]);
        //    ////request.Headers.Add("Session_key", tokens[1]);

        //    ////string json = JsonConvert.SerializeObject(table);
        //    ////request.Content = new StringContent(json, Encoding.UTF8)
        //    ////{
        //    ////    Headers =
        //    ////    {
        //    ////        ContentType = new("application/json")
        //    ////    }
        //    ////};
        //    //try
        //    //{
        //    //    using HttpResponseMessage response = await client.SendAsync(request);
        //    //    response.EnsureSuccessStatusCode();
        //    //    string serverResponse = await response.Content.ReadAsStringAsync();

        //    //    serverResponse = serverResponse.Replace("STO_", "");

        //    //    APIResponseModel? apiResponse = JsonConvert.DeserializeObject<APIResponseModel>(serverResponse);

        //    //    return (apiResponse == null) ? throw new Exception("API response is null!") : apiResponse;
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    return new APIResponseModel(false, ex.Message, new DataTable());
        //    //}
        //    return new APIResponseModel();
        //}
    }
}
