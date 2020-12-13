using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Load_XML_Data_Into_Table_Using_sqlBulkCopy_ASP.Net
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;

            using(SqlConnection con = new SqlConnection(cs))
            {
                DataSet ds = new DataSet();
                ds.ReadXml(Server.MapPath("~/data.xml"));
            }
        }
    }
}