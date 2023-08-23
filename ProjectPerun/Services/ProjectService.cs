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
    internal class ProjectService
    {
        public static DataTable GetProjectData()
        {
            APIResponseModel response = ProjectDataCalls.GetProjectData();
            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetProjectMaterials(int projectID)
        {
            APIResponseModel response = ProjectDataCalls.GetProjectMaterials(projectID);
            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static DataTable GetMaterialDataNotOnProject(int projectID)
        {
            APIResponseModel response = ProjectDataCalls.GetMaterialDataNotOnProject(projectID);
            return (response.Data == null) ? new DataTable() : response.Data;
        }

        public static APIResponseModel InsertProjectData(DSProjects projectData, DSProjectMaterials projectMaterials)
        {
            APIResponseModel response = ProjectDataCalls.InsertProjectData(projectData, projectMaterials);
            return response;
        }

        public static APIResponseModel UpdateProjectData(DSProjects projectData, DSProjectMaterials projectMaterials)
        {
            APIResponseModel response = ProjectDataCalls.UpdateProjectData(projectData, projectMaterials);
            return response;
        }

        public static APIResponseModel DeleteProjectData(DSProjects projectData)
        {
            APIResponseModel response = ProjectDataCalls.DeleteProjectData(projectData);
            return response;
        }


    }
}
