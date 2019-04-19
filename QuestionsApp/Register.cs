using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsApp
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(txtConfPwd.Text))
            {
                RunSqlCommands connection = new RunSqlCommands();

                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string firstName = txtFirstName.Text;
                string middleName = txtMiddleName.Text;
                string lastName = txtLastName.Text;
                string address = txtAddress.Text;
                string city = txtCity.Text;
                string state = cmbState.Text;
                string postalCode = txtPostalCode.Text;

                if (connection.register(username, password, firstName, middleName, lastName, address, city, state, postalCode))
                {
                    MessageBox.Show("Registered Successfully");
                }
            }

            /*         //secure password
                       String password = txtPassword.Text;

                       //create salt vaue with PRNG
                       byte[] salt;
                       new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

                       //create the Rfc2898DeriveBytes and get the hash value
                       var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10000);
                       byte[] hash = pbkdf2.GetBytes(20);

                       //combine the salt and password bytes
                       byte[] hashBytes = new byte[36];
                       Array.Copy(salt, 0, hashBytes, 0, 16);
                       Array.Copy(hash, 0, hashBytes, 16, 20);

                       //convert combined password & salt into string
                       string savedPasswordHash = Convert.ToBase64String(hashBytes);
           //            DBContext.AddUser(new User { ..., Password = savedPasswordHash });
           */
           /*
            string connectionString;
            string sql;
            Boolean addUser = true;
            
            //set connection string
            connectionString = @"Data Source=UMC-1040-1351\SQLEXPRESS;Initial Catalog=QuestionApp;Integrated Security=True";

            //query to check if username exists already
            sql = "SELECT username FROM users where username = @username";

            System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection(connectionString);
            SqlCommand scUserCheck = new SqlCommand(sql, con);
            scUserCheck.Parameters.AddWithValue("@username", txtUsername.Text);

            try
            {
                con.Open();
                var reader = scUserCheck.ExecuteReader();
                if (reader.Read())
                {
                    addUser = false;
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

            //submit user details to database
            //check password fields match, are not empty, and username does not already exist
            if (txtPassword.Text.Equals(txtConfPwd.Text) && !txtPassword.Text.Equals("") && !txtConfPwd.Text.Equals("") && addUser.Equals(true))
            {
                sql = "INSERT INTO users (username,password,first_name,middle_name,last_name,address,city,state_abbr,postal_code)" +
                        "VALUES (@username,@password,@first_name,@middle_name,@last_name,@address,@city,@state,@postal_code)";

                SqlCommand sc = new SqlCommand(sql, con);
                //parameterize values for sql query
                sc.Parameters.AddWithValue("@username", txtUsername.Text);
                sc.Parameters.AddWithValue("@password", txtPassword.Text);
                sc.Parameters.AddWithValue("@first_name", txtFirstName.Text);
                sc.Parameters.AddWithValue("@middle_name", txtMiddleName.Text);
                sc.Parameters.AddWithValue("@last_name", txtLastName.Text);
                sc.Parameters.AddWithValue("@address", txtAddress.Text);
                sc.Parameters.AddWithValue("@city", txtCity.Text);
                sc.Parameters.AddWithValue("@state", cmbState.Text);
                sc.Parameters.AddWithValue("@postal_code", txtPostalCode.Text);

                try
                {
                    con.Open();
                    sc.ExecuteNonQuery();
                    clearForm();
                    ActiveForm.Close();
                    Login login = new Login();
                    login.Show();
                }
                catch (Exception err)
                {
                    Console.Error.WriteLine(err);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                if (addUser.Equals(false)) //username exists
                {
                    MessageBox.Show("Username is already taken.");
                }
                else //password and verify passwor mismatch or blank
                {
                    MessageBox.Show("Passwords do not match or invalid.");
                }
                
            }*/
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //TODO clear textboxes
            clearForm();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //TODO close or hide form
        }

        private void clearForm()
        {
            txtFirstName.Text = "";
            txtMiddleName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            cmbState.Text = "";
            txtPostalCode.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfPwd.Text = "";
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
