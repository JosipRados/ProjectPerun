using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPerun.Models
{
    internal class MaterialDataModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Number { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public bool OnProject { get; set; }
        public string ProjectID { get; set; }
        public string WarehouseID { get; set; }
        public string Type { get; set; }
        public bool Reserved { get; set; }


        //public int ID { get; set; }
        //public string Name { get; set; }
        //public string Code { get; set; }
        //public int Number { get; set; }
        //public int Quantity { get; set; }
        //public decimal Price { get; set; }
        //public bool OnProject { get; set; }
        //public int ProjectID { get; set; }
        //public int WarehouseID { get; set; }
        //public string Type { get; set; }
        //public bool Reserved { get; set; }
    }
}
