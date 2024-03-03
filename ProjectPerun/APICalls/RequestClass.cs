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
using ProjectPerun.Models;

namespace ProjectPerun.APICalls
{
    internal class RequestClass
    {
        internal static APIResponseModel GetRequest(RequestParametersModel parameters)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(parameters.Path);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = parameters.RequestType;

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return (parameters.Substring != "") ? JsonConvert.DeserializeObject<APIResponseModel>(result.Replace(parameters.Substring, ""))
                                                    : JsonConvert.DeserializeObject<APIResponseModel>(result);

                /*if (parameters.Substring != "")
                    return JsonConvert.DeserializeObject<APIResponseModel>(result.Replace(parameters.Substring, ""));
                else
                    return JsonConvert.DeserializeObject<APIResponseModel>(result); */
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        internal static APIResponseModel Request(RequestParametersModel parameters)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(parameters.Path);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = parameters.RequestType;

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    streamWriter.Write(parameters.RequestJSON);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
                return (parameters.Substring != "") ? JsonConvert.DeserializeObject<APIResponseModel>(result.Replace(parameters.Substring, ""))
                                                    : JsonConvert.DeserializeObject<APIResponseModel>(result);

                /*if (parameters.Substring != "")
                    return JsonConvert.DeserializeObject<APIResponseModel>(result.Replace(parameters.Substring,""));
                else
                    return JsonConvert.DeserializeObject<APIResponseModel>(result); */
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }
    }
}
