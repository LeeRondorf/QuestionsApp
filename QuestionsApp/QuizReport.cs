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
    public partial class QuizReport : Form
    {
        public QuizReport()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuizReport_Load(object sender, EventArgs e)
        {
            RunSqlCommands command = new RunSqlCommands();
            //add list of users from query to List users
            List<String> users = command.returnUserList();
            //Add each user item in list users to combobox
            foreach (var user in users)
            {
                cmbUsers.Items.Add(user.ToString()); 
            }
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {//TODO: queries for total, average, max, min
            Double max=0.0;
            Double min =0.0;
            Double avg =0.0;
            Double total =0.0;
            String user = cmbUsers.SelectedItem.ToString();
            RunSqlCommands command = new RunSqlCommands();
            List<int> quizes =command.returnQuizesTakenByUser(user);
            int quizesTakenCount = quizes.Count;

            foreach (var quiz in quizes)
            {
                //execute query for total questions
                int numQuestions = command.totalQuestionsInQuiz(quiz, user);
                //correct questions
                int correctQuestions = command.totalCorrectInQuiz(quiz, user);
                //incorrect questions
                // int incorrectQuestions = command.totalIncorrectInQuiz(quiz, user);
                //calultate score
                double score = (Double)correctQuestions / numQuestions;

                max = Math.Max(max, score);
                
                min = Math.Min(min, score);

                total = total + (int)score;

            }
            if (quizesTakenCount > 0)
            {
                avg = total / quizesTakenCount;
            }

            min = min * 100;
            max = max * 100;
            avg = avg * 100;
            //set labels to values
            lblQuizTaken.Text = quizesTakenCount.ToString();
            lblAvgScore.Text = avg.ToString() + "%";
            lblHighScore.Text = max.ToString() + "%";
            lblLowScore.Text = min.ToString() + "%";
        }
    }
}
