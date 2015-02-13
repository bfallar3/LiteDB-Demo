using LiteDB;
using LiteDB_Demo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace LiteDB_Demo
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // initially populate the LiteDB collection.
            // open or create LiteDB for SalesOrderDetails.
            var path = Server.MapPath(@"Data\SalesOrderDetails.lite");
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (var lite = new LiteEngine(path))
            {
                var collection = lite.GetCollection<SalesOrderDetails>("SalesOrderDetails");
                collection.EnsureIndex("ID", true);

                // read SalesOrderDetail from DB.
                using (var context = new Data.AdventureWorks2012Entities())
                {
                    var details = context.SalesOrderDetails
                        .Select(s => new { s.SalesOrderDetailID, s.SalesOrderID, s.rowguid, s.ProductID })
                        .Take(10000)
                        .ToList();

                    var orderDetails = new List<SalesOrderDetails>(details.Count);
                    Parallel.ForEach(details, currentDetails =>
                    {
                        var item = currentDetails;
                        var prod_id = item.ProductID;
                        var id = item.SalesOrderDetailID;
                        var parent_id = item.SalesOrderID;
                        var guid = item.rowguid;

                        var newItem = new SalesOrderDetails
                        {
                            Guid = guid.ToString(),
                            ProductID = prod_id,
                            ID = id,
                            ParentID = parent_id
                        };

                        orderDetails.Add(newItem);
                    });

                    collection.Insert(orderDetails);
                }
            }
        }
    }
}