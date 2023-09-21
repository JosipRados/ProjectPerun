using Newtonsoft.Json;
using ProjectPerun.APICalls;
using ProjectPerun.DataSets;
using ProjectPerun.Models;
using ProjectPerunDesktop.Models;
using ProjectPerunDesktop;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerun.Services
{
    internal class ShiftService
    {
        public static DataTable GetShiftData()
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "shift", "GET", "", "SHI_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetOneShiftData(int shiftID)
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "shift/" + shiftID.ToString(), "GET", "", "SHI_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetShiftsByOrderID(int orderID)
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "shift/by-order/" + orderID.ToString(), "GET", "", "SHI_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static APIResponseModel InsertShiftData(DSBatchData dsShiftData)
        {
            string json = JsonConvert.SerializeObject(dsShiftData.BatchTable);
            json = "{\"ShiftData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "shift", "POST", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel UpdateShiftData(DSBatchData dsShiftData)
        {
            string json = JsonConvert.SerializeObject(dsShiftData.BatchTable);
            json = "{\"ShiftData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "shift", "PUT", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel DeleteShiftData(DSBatchData dsShiftData)
        {
            string json = JsonConvert.SerializeObject(dsShiftData.BatchTable);
            json = "{\"ShiftData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "shift", "DELETE", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }
    }
}
