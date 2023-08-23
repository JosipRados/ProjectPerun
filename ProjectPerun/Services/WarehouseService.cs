using ProjectPerun.APICalls;
using ProjectPerun.DataSets;
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
            APIResponseModel response = WarehouseDataCalls.GetWarehouseData();
            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetOneWarehouseData(int WarehouseID)
        {
            APIResponseModel response = WarehouseDataCalls.GetOneWarehouseData(WarehouseID);
            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static APIResponseModel InsertWarehouseData(DSWarehouse dsWarehouseData)
        {
            APIResponseModel response = WarehouseDataCalls.InsertWarehouseData(dsWarehouseData);
            return response;
        }

        public static APIResponseModel UpdateWarehouseData(DSWarehouse dsWarehouseData)
        {
            APIResponseModel response = WarehouseDataCalls.UpdateWarehouseData(dsWarehouseData);
            return response;
        }

        public static APIResponseModel DeleteWarehouseData(DSWarehouse dsWarehouseData)
        {
            APIResponseModel response = WarehouseDataCalls.DeleteWarehouseData(dsWarehouseData);
            return response;
        }
    }
}
