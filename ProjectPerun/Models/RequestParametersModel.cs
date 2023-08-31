using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerun.Models
{
    internal class RequestParametersModel
    {
        public string Path { get; set; }
        public string RequestType { get; set; }
        public string RequestJSON { get; set; }
        public string Substring { get; set; }

        internal RequestParametersModel() { }

        internal RequestParametersModel(string path, string requestType, string requestJSON = "", string substring = "")
        {
            Path = path;
            RequestType = requestType;
            RequestJSON = requestJSON;
            Substring = substring;
        }

    }
}
