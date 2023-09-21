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
    internal class UsersService
    {
        public static DataTable GetUserData()
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "shift", "GET", "", "SHI_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetOneUserData(int shiftID)
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "shift/" + shiftID.ToString(), "GET", "", "SHI_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static APIResponseModel InsertUserData(DSUserData dsUserData)
        {
            string json = JsonConvert.SerializeObject(dsUserData.UserTable);
            json = "{\"UserData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "user", "POST", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel UpdateUserData(DSBatchData dsUserData)
        {
            string json = JsonConvert.SerializeObject(dsUserData.BatchTable);
            json = "{\"UserData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "user", "PUT", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel DeleteUserData(DSBatchData dsUserData)
        {
            string json = JsonConvert.SerializeObject(dsUserData.BatchTable);
            json = "{\"UserData\" : " + json + "}";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "user", "DELETE", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel ChangeUserPasword(ChangePasswordModel changeData)
        {
            string json = JsonConvert.SerializeObject(changeData);

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "user/change-password", "PUT", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel LoginUser(LoginModel loginData)
        {
            string json = JsonConvert.SerializeObject(loginData);

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "user/login", "PUT", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }
    }
}
