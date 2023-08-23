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
    internal class BatchService
    {
        public static DataTable GetBatchData()
        {
            APIResponseModel response = BatchDataCalls.GetBatchData();
            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetOneBatchData(int batchID)
        {
            APIResponseModel response = BatchDataCalls.GetOneBatchData(batchID);
            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static APIResponseModel InsertBatchData(DSBatchData dsBatchData)
        {
            APIResponseModel response = BatchDataCalls.InsertBatchData(dsBatchData);
            return response;
        }

        public static APIResponseModel UpdateBatchData(DSBatchData dsBatchData)
        {
            APIResponseModel response = BatchDataCalls.UpdateBatchData(dsBatchData);
            return response;
        }

        public static APIResponseModel DeleteBatchData(DSBatchData dsBatchData)
        {
            APIResponseModel response = BatchDataCalls.DeleteBatchData(dsBatchData);
            return response;
        }

        public static DataTable GetNewBatchID()
        {
            APIResponseModel response = BatchDataCalls.GetNewBatchID();
            return (response.Data == null) ? new DataTable() : response.Data;
        }
    }
}
