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
    internal class WarehouseService
    {
        public static DataTable GetWarehouseData()
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "Warehouse", "GET", "", "WAR_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetOneWarehouseData(int WarehouseID)
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "Warehouse/" + WarehouseID.ToString(), "GET", "", "WAR_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static APIResponseModel InsertWarehouseData(DSWarehouse dsWarehouseData)
        {
            string json = JsonConvert.SerializeObject(dsWarehouseData.Warehouse);
            json = "{\"WarehouseData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "Warehouse", "POST", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel UpdateWarehouseData(DSWarehouse dsWarehouseData)
        {
            string json = JsonConvert.SerializeObject(dsWarehouseData.Warehouse);
            json = "{\"WarehouseData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "Warehouse", "PUT", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel DeleteWarehouseData(DSWarehouse dsWarehouseData)
        {
            string json = JsonConvert.SerializeObject(dsWarehouseData.Warehouse);
            json = "{\"WarehouseData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "Warehouse", "DELETE", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }
    }
}
