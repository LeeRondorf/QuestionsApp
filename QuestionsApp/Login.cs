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
           try
            {
                con.Open();
                var reader = scUserCheck.ExecuteReader();
                if (reader.Read())
                {
                    //if general user, open the quiz selection page (something)

                    MessageBox.Show("Success");
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
            }
            */
            RunSqlCommands connection = new RunSqlCommands();
            if (connection.login(txtUsername.Text, txtPassword.Text).Equals(true))
            {
                MessageBox.Show("Login Successful.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }
    }
}
