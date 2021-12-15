using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolManagementSystem
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text.Trim();
            string surname = tb_surname.Text.Trim();
            string email = tb_email.Text.Trim();
            string password = tb_password.Text.Trim();
            string status = person.SelectedValue.Trim().ToLower();
            Database database = new Database();
            database.register(name, surname, email, password, status);
            Response.Write("<script>alert('Registered!')</script>");
            if (status == "student")
                Response.Redirect("loginstudent.aspx");
            else if (status == "teacher")
                Response.Redirect("loginteacher.aspx");
        }
    }
}