using Newtonsoft.Json;
using ProjectPerunDesktop.Models;
using ProjectPerunDesktop;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ProjectPerun.DataSets;
using ProjectPerun.Models;

namespace ProjectPerun.APICalls
{
    internal class ProjectDataCalls
    {
        internal static APIResponseModel GetProjectData()
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "projects");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result.Replace("PRO_", ""));
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        internal static APIResponseModel InsertProjectData(DSProjects projectData, DSProjectMaterials projectMaterials)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "projects");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string jsonFirst = JsonConvert.SerializeObject(projectData.Projects);
                    jsonFirst = "\"Projects\" : " + jsonFirst;
                    string jsonSecond = JsonConvert.SerializeObject(projectMaterials.ProjectMaterials);
                    jsonSecond = "\"Materials\" : " + jsonSecond;

                    string json = "{ " + jsonFirst + "," + jsonSecond + "} "; 
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result);
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        internal static APIResponseModel GetProjectMaterials(int projectID)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "projects/project-materials/" + projectID.ToString());
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result.Replace("PMT_", ""));
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        internal static APIResponseModel GetMaterialDataNotOnProject(int projectID)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "projects/materials-data/" + projectID.ToString());
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "GET";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result.Replace("MAT_", ""));
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        internal static APIResponseModel UpdateProjectData(DSProjects projectData, DSProjectMaterials projectMaterials)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "projects");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string jsonFirst = JsonConvert.SerializeObject(projectData.Projects);
                    jsonFirst = "\"Projects\" : " + jsonFirst;
                    string jsonSecond = JsonConvert.SerializeObject(projectMaterials.ProjectMaterials);
                    jsonSecond = "\"Materials\" : " + jsonSecond;

                    string json = "{ " + jsonFirst + "," + jsonSecond + "} ";
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result);
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }

        internal static APIResponseModel DeleteProjectData(DSProjects projectData)
        {
            try
            {
                string result;
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Global.basePath + "projects");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "DELETE";

                using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                {
                    string jsonFirst = JsonConvert.SerializeObject(projectData.Projects);
                    jsonFirst = "\"Projects\" : " + jsonFirst;

                    string json = "{ " + jsonFirst + "} ";
                    streamWriter.Write(json);
                }

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }

                return JsonConvert.DeserializeObject<APIResponseModel>(result);
            }
            catch (Exception ex)
            {
                return new APIResponseModel(false, ex.Message, new DataTable());
            }
        }
    }
}
