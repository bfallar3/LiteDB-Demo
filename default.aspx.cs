using LiteDB;
using LiteDB_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LiteDB_Demo
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var path = Server.MapPath(@"Data\SalesOrderDetails.lite");
            using (var lite = new LiteEngine(path))
            {
                var collection = lite.GetCollection<SalesOrderDetails>("SalesOrderDetails");
                var results = collection.All();
                grid1.DataSource = results;
                grid1.DataBind();
            }
        }
    }
}