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
    internal class OrdersService
    {
        public static DataTable GetOrderData(string filter)
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "orders/" + filter, "GET", "", "ORD_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetOneOrderData(int orderID)
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "orders/one/" + orderID.ToString(), "GET", "", "ORD_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static APIResponseModel InsertOrderData(DSOrderData dsOrderData)
        {
            string json = JsonConvert.SerializeObject(dsOrderData.OrderTable);
            json = "{\"OrderData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "orders", "POST", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel UpdateOrderData(DSOrderData dsOrderData)
        {
            string json = JsonConvert.SerializeObject(dsOrderData.OrderTable);
            json = "{\"OrderData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "orders", "PUT", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel DeleteOrderData(DSOrderData dsOrderData)
        {
            string json = JsonConvert.SerializeObject(dsOrderData.OrderTable);
            json = "{\"OrderData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "order", "DELETE", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }
        public static APIResponseModel DeleteOrderData(int orderID)
        {
            string json = JsonConvert.SerializeObject(orderID);
            //json = "{\"OrderData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "order", "DELETE", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        internal static APIResponseModel FinishOrder(int orderID)
        {
            string json = JsonConvert.SerializeObject(orderID);

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "orders/finished", "PUT", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        internal static APIResponseModel AddStorageMaterialsToOrder(DSStorage dsSeparatedMaterial, DSOrderStorage dsOrderMaterial)
        {
            string separatedMaterialJson = JsonConvert.SerializeObject(dsSeparatedMaterial.Storage);
            string orderMaterialJson = JsonConvert.SerializeObject(dsOrderMaterial.OrderStorageTable);
            string json = "{\"SeparatedMaterial\" : " + separatedMaterialJson + ", \"OrderMaterial\" : " + orderMaterialJson + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "orders/separate-material", "POST", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }
    }
}
