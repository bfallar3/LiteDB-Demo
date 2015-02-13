using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiteDB_Demo.Models
{
    public class SalesOrderDetails
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public int ProductID { get; set; }
        public string Guid { get; set; }
    }
}