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
    internal class ProjectService
    {
        public static DataTable GetProjectData()
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "projects", "GET", "", "PRO_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetProjectMaterials(int projectID)
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "projects/project-materials/" + projectID.ToString(), "GET", "", "PMT_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetMaterialDataNotOnProject(int projectID)
        {
            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "projects/materials-data/" + projectID.ToString(), "GET", "", "MAT_");
            APIResponseModel response = RequestClass.GetRequest(parameters);

            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static APIResponseModel InsertProjectData(DSProjects projectData, DSProjectMaterials projectMaterials)
        {
            string jsonFirst = JsonConvert.SerializeObject(projectData.Projects);
            jsonFirst = "\"Projects\" : " + jsonFirst;
            string jsonSecond = JsonConvert.SerializeObject(projectMaterials.ProjectMaterials);
            jsonSecond = "\"Materials\" : " + jsonSecond;
            string json = "{ " + jsonFirst + "," + jsonSecond + "} ";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "projects", "POST", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel UpdateProjectData(DSProjects projectData, DSProjectMaterials projectMaterials)
        {
            string jsonFirst = JsonConvert.SerializeObject(projectData.Projects);
            jsonFirst = "\"Projects\" : " + jsonFirst;
            string jsonSecond = JsonConvert.SerializeObject(projectMaterials.ProjectMaterials);
            jsonSecond = "\"Materials\" : " + jsonSecond;
            string json = "{ " + jsonFirst + "," + jsonSecond + "} ";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "projects", "PUT", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }

        public static APIResponseModel DeleteProjectData(DSProjects projectData)
        {
            string json = JsonConvert.SerializeObject(projectData.Projects);
            json = "{ \"Projects\" : " + json + " }";

            RequestParametersModel parameters = new RequestParametersModel(Global.basePath + "projects", "DELETE", json);
            APIResponseModel response = RequestClass.Request(parameters);

            return response;
        }


    }
}
