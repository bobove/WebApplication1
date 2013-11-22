using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class StartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



            string conn = ConfigurationManager.ConnectionStrings["ErikDB"].ToString();
            using (SqlDataAdapter dataAdapter
                    = new SqlDataAdapter("SELECT * FROM Erik_Test_Table1", conn))
            {
                // create the DataSet 
                DataSet dataSet = new DataSet();
                // fill the DataSet using our DataAdapter 
                dataAdapter.Fill(dataSet);
                this.GridView1.DataSource = dataSet;
                this.GridView1.DataBind();
            }
        }
    }
}