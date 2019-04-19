using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace QuestionsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lnkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*
            string connectionString;
            string sql;

            //set connection string
            connectionString = @"Data Source=UMC-1040-1147\SQLEXPRESS;Initial Catalog=QuestionApp;Integrated Security=True";

            //query to check if username exists already
            sql = "SELECT username, password FROM users where username = @username AND password = @password";

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand scUserCheck = new SqlCommand(sql, con);
            scUserCheck.Parameters.AddWithValue("@username", txtUsername.Text);
            scUserCheck.Parameters.AddWithValue("@password", txtPassword.Text);

            try
            {
                con.Open();
                var reader = scUserCheck.ExecuteReader();
                if (reader.Read())
                {
                    //if general user, open the quiz selection page (something)
                    
                
                    //if admin, open quiz management page


                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

            }
            catch (Exception err)
            {
                Console.Error.WriteLine(err);
            }
            finally
            {
                con.Close();
            }*/

            RunSqlCommands connection = new RunSqlCommands();
            connection.login(txtUsername.Text, txtPassword.Text);

        }
    }
}
