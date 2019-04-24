using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsApp
{
    public partial class Response : Form
    {
        public Response()
        {
            InitializeComponent();
            showResponse();
        }

        private void Response_Load(object sender, EventArgs e)
        {
            
        }

        private void showResponse()
        {
            RunSqlCommands command = new RunSqlCommands();
            txtQzResp.Text = command.getResponses("lee", 1016);
            //txtQzResp.Text = "Hello World";
        }
    }
}
