using Newtonsoft.Json;
using ProjectPerun.APICalls;
using ProjectPerun.DataSets;
using ProjectPerun.Models;
using ProjectPerunDesktop;
using ProjectPerunDesktop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerun.Services
{
    internal class BatchService
    {
        public static DataTable GetBatchData()
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "batch", "GET", "", "BAT_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetOneBatchData(int batchID)
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "batch/" + batchID.ToString(), "GET", "", "BAT_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static APIResponseModel InsertBatchData(DSBatchData dsBatchData)
        {
            string json = JsonConvert.SerializeObject(dsBatchData.BatchTable);
            json = "{\"BatchData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "batch", "POST", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel UpdateBatchData(DSBatchData dsBatchData)
        {
            string json = JsonConvert.SerializeObject(dsBatchData.BatchTable);
            json = "{\"BatchData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "batch", "PUT", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel DeleteBatchData(DSBatchData dsBatchData)
        {
            string json = JsonConvert.SerializeObject(dsBatchData.BatchTable);
            json = "{\"BatchData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "batch", "DELETE", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static DataTable GetNewBatchID()
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "batch/batch-number", "GET");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }
    }
}
