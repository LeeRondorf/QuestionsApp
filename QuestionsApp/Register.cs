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

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
