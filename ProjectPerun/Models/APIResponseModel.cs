using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerunDesktop.Models
{
    internal class APIResponseModel
    {
        public bool Success { get; set; }
        public string Error { get; set; }
        public DataTable Data { get; set; }

        public APIResponseModel() { }

        public APIResponseModel(bool success, string error, DataTable data)
        {
            Success = success;
            Error = error;
            Data = data;
        }
    }
}
