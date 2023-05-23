using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROG123.Models
{
    public class ProductModel
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public String PID { get; set; }
        public Double Price { get; set; }
        public int InventoryAmount { get; set; }
    }
}
