using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this;
            login.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.MdiParent = this;
            register.Show();
        }

        private void quizToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CreateQuiz quiz = new CreateQuiz();
            quiz.MdiParent = this;
            quiz.Show();
        }
    }
}
