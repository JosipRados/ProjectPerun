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
            APIResponseModel response = StorageDataCalls.GetStorageData();
            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetLastMaterialNumber()
        {
            APIResponseModel response = StorageDataCalls.GetLastMaterialNumber();
            return (response.Data == null) ? new DataTable() : response.Data;
        }
    }
}
