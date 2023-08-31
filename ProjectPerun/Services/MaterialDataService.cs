using Newtonsoft.Json;
using ProjectPerun.APICalls;
using ProjectPerun.DataSets;
using ProjectPerun.Models;
using ProjectPerunDesktop;
using ProjectPerunDesktop.DataCalls;
using ProjectPerunDesktop.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerun.Services
{
    internal class MaterialDataService
    {
        public static DataTable GetMaterialData()
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "material-data", "GET", "", "MAT_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static APIResponseModel InsertMaterialData(DSMaterialData materialData)
        {
            string json = JsonConvert.SerializeObject(materialData.MaterialData);
            json = "{\"materialData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "material-data", "POST", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel UpdateMaterialData(DSMaterialData materialData)
        {
            string json = JsonConvert.SerializeObject(materialData.MaterialData);
            json = "{\"materialData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "material-data", "PUT", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel DeleteMaterialData(DSMaterialData materialData)
        {
            string json = JsonConvert.SerializeObject(materialData.MaterialData);
            json = "{\"materialData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "material-data", "DELETE", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }
    }
}
