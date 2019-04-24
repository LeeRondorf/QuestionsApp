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
        public string username { get; set; }

        public Login()
        {
            InitializeComponent();
        }

        private void lnkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            RunSqlCommands connection = new RunSqlCommands();
            if (connection.login(txtUsername.Text, txtPassword.Text).Equals(true))
            {
                MessageBox.Show("Login Successful.");
                username = txtUsername.Text;
                DialogResult = DialogResult.OK;
                Close();


            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }
    }
}
