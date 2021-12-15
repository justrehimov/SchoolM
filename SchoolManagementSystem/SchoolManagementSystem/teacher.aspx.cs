using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolManagementSystem
{
    public partial class teacher : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void show_btn_Click(object sender, EventArgs e)
        {
            getData();
        }
        private void getData()
        {
            Database database = new Database();
            MySqlDataAdapter adapter = database.getAdapter();
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gridview.DataSource = dt;
            gridview.DataBind();
        }
    }
}