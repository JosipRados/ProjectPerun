using ProjectPerun.APICalls;
using ProjectPerun.DataSets;
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
            APIResponseModel response = MaterialDataCalls.GetMaterialData();
            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static APIResponseModel InsertMaterialData(DSMaterialData materialData)
        {
            APIResponseModel response = MaterialDataCalls.InsertMaterialData(materialData);
            return response;
        }

        public static APIResponseModel UpdateMaterialData(DSMaterialData materialData)
        {
            APIResponseModel response = MaterialDataCalls.UpdateMaterialData(materialData);
            return response;
        }

        public static APIResponseModel DeleteMaterialData(DSMaterialData materialData)
        {
            APIResponseModel response = MaterialDataCalls.DeleteMaterialData(materialData);
            return response;
        }
    }
}
