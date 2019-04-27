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
        public string account { get; set; }

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

            var result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                account = login.username;
                loggedInButtonChanges();
            }
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Register register = new Register();

            var result = register.ShowDialog();
            if (result == DialogResult.OK)
            {
                account = register.name;
                loggedInButtonChanges();
            }
        }

        private void quizToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CreateQuiz createQuiz = new CreateQuiz();
            createQuiz.MdiParent = this;
            createQuiz.Show();
        }

        private void quizToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectQuiz selectQuiz = new SelectQuiz(account);
            selectQuiz.MdiParent = this;
            selectQuiz.Show();
        }

        private void loggedInButtonChanges()
        {
            quizToolStripMenuItem1.Enabled = true;
            loginToolStripMenuItem.Enabled = false;
            registerToolStripMenuItem.Enabled = false;
            quizReportToolStripMenuItem.Enabled = true;
        }

        private void quizReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuizReport quizReport = new QuizReport();
            quizReport.MdiParent = this;
            quizReport.Show();
        }

        private void quizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.MdiParent = this;
            about.Show();
        }
    }
}
