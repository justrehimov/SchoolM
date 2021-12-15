using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SchoolManagementSystem
{
    public partial class resetpassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            person.Enabled = true;
            Database database = new Database();
            database.SendEmail(tb_email.Text.Trim());
            Session["code"] = database.getcode().ToString();
            Session.Timeout = 3;
            person.Enabled = false;
            tb_code.Enabled = true;
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            string email = tb_email.Text.Trim();
            string password = tb_password.Text.Trim();
            string code = tb_code.Text.Trim();
            string status = person.SelectedValue.Trim();
            if(code == Session["code"].ToString())
            {
                database.changePass(password, email, status);
                if (status == "student")
                    Response.Redirect("loginstudent.aspx");
                else if (status == "teacher")
                    Response.Redirect("loginteacher.aspx");
            }
            else
            {
                Response.Write("<script>alert('Confirm code is not true')</script>");
            }
        }
    }
}