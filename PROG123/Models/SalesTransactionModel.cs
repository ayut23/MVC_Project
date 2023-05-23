using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROG123.Models
{
    public class SalesTransactionModel
    {

        public string ProductID { get;  set; }
        public string PersonID { get;  set; }
        public DateTime SalesDataTime { get;  set; }
        public int PQuantity { get;  set; }
        public string SalesID { get; set; }
    }
}
