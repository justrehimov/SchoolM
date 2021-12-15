using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolManagementSystem
{
    public partial class loginstudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Abandon();
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text.Trim();
            string password = tb_password.Text.Trim();
            Database database = new Database();
            if (database.login(email, password, "student"))
            {
                Session["user"] = email;
                Response.Redirect("student.aspx");
            }
               
            else
                Response.Write("<script>alert('Email or password is invalid')</script>");
        }
    }
}