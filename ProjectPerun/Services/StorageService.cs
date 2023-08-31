using ProjectPerun.APICalls;
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
    }
}
