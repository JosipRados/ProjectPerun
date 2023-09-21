using Newtonsoft.Json;
using ProjectPerun.APICalls;
using ProjectPerun.DataSets;
using ProjectPerun.Models;
using ProjectPerunDesktop.DataCalls;
using ProjectPerunDesktop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerunDesktop.Services
{
    internal class StorageService
    {
        public static DataTable GetStorageData()
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "storage/all/1", "GET", "", "STO_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetLastMaterialNumber()
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "storage/material-number", "GET");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static APIResponseModel InsertStorageData(DSTransactionStorage storageData)
        {
            string json = JsonConvert.SerializeObject(storageData.TransactionTable);
            json = "{ \"StorageData\" : " + json + " }";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "storage", "POST", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static DataTable GetOrderMaterials(int orderID)
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "storage/order/" + orderID.ToString(), "GET", "", "OST_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetAvailableMaterialsForOrder(int orderID)
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "storage/available-for-order/" + orderID.ToString(), "GET", "", "OST_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }
    }
}
