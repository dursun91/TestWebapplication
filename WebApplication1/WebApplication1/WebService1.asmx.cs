using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;

namespace WebApplication1
{   // connect und disconnect
    // geklappt oder nicht ?!
    // 

    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        [WebMethod(Description ="This is the dataset")]
        public DataTable HelloWorldDataSet()
        {
            DataTable dt = new DataTable("myDataTable");
            dt.Columns.Add("column1", typeof(System.String));
            dt.Columns.Add("column2", typeof(System.String));

            DataRow dr = dt.NewRow();
            dr["column1"] = "Markus blibli";
            dr["column2"] = "idk";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["column1"] = "Edu blabla";
            dr["column2"] = "idk";
            dt.Rows.Add(dr);

            dr = dt.NewRow();
            dr["column1"] = "Ayando bloblo";
            dr["column2"] = "idk";
            dt.Rows.Add(dr);

            return dt;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
