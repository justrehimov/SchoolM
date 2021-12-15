using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace SchoolManagementSystem
{
    public class Database
    {
        
        public Database()
        {
            con = new MySqlConnection(connection);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = String.Format("Create table if not exists students(name varchar(30),surname varchar(40),email varchar(30),password varchar(20))");
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            cmd.CommandText = String.Format("Create table if not exists teachers(name varchar(30),surname varchar(40),email varchar(30),password varchar(20))");
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }
        string connection = "server=localhost;uid=root;pwd=123456789;database=schooldb";
        MySqlConnection con;
        MySqlCommand cmd;
        private int code;
        Random random = new Random();

        public bool login(string email, string password,string status)
        {
            if(status == "student")
                cmd.CommandText = "select * from students";
            else if(status == "teacher")
                cmd.CommandText = "select * from teachers";
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (reader.GetString("email") == email && reader.GetString("password") == password)
                {
                    cmd.Dispose();
                    return true;
                }
            }
            return false;
        }


        public void register(string name, string surname, string email, string password,string status)
        {
            if (status == "student")
                cmd.CommandText = String.Format("insert into students(name,surname,email,password) values('{0}','{1}','{2}','{3}');", name, surname, email, password);
            else if (status == "teacher")
                cmd.CommandText = String.Format("insert into teachers(name,surname,email,password) values('{0}','{1}','{2}','{3}');", name, surname, email, password);
            cmd.ExecuteNonQuery();
            cmd.Dispose();

        }


        public MySqlDataAdapter getAdapter()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(String.Format("select * from students;"), con);
            return adapter;
        }
  

        public void changePass(string password, string email,string status)
        {
            if (status == "student")
                cmd.CommandText = String.Format("update students set password = '{0}' where email = '{1}';", password, email);
            else if (status == "teacher")
                cmd.CommandText = String.Format("update teachers set password = '{0}' where email = '{1}';", password, email);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        public int getcode()
        {
            return code;
        }
        public  void SendEmail(string emailToAddress)
        {
            
            using (MailMessage mail = new MailMessage())
            {
                code = random.Next(10000, 99999);
                mail.From = new MailAddress("confirmmailadress@gmail.com");
                mail.To.Add(emailToAddress);
                mail.Subject = "School Management System";
                mail.Body = "Confirm code:" + code;
                mail.IsBodyHtml = true;
                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("confirmmailadress@gmail.com", "cxwwfvqqoecsvtwu");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}