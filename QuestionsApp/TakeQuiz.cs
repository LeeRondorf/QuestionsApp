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
    public partial class TakeQuiz : Form
    {
        string name { get; set; }
        Quiz activeQuiz { get; set; }
        int counter { get; set; }

        public TakeQuiz(string username, Quiz quiz)
        {
            InitializeComponent();
            name = username;
            activeQuiz = quiz;
            counter = 0;
            cycleQuestions();
        }

        private void cycleQuestions()
        {
            questionNameTextBox.Text = activeQuiz.questions[counter].QuestionName;
            questionTextBox.Text = activeQuiz.questions[counter].questionText;

            possibleAnswersListBox.Items.Clear();
            foreach (Answer ans in activeQuiz.questions[counter].answers)
            {
                possibleAnswersListBox.Items.Add(ans.answerText);
            }

            progressTextBox.Text = counter+1 + " / " + activeQuiz.questions.Count;
        }

        private void nextQuestionButton_Click(object sender, EventArgs e)
        {

            int answerIndex = possibleAnswersListBox.SelectedIndex;
            string username = name;
            int answerID = activeQuiz.questions[counter].answers[answerIndex].id;
            int questionID = activeQuiz.questions[counter].id;
            int quizID = activeQuiz.id;

            counter++;
            responseTableAdapter.Insert(username, quizID, questionID, answerID);

            if (counter < activeQuiz.questions.Count)
            {
                cycleQuestions();
            }
            else
            {
                //data.response.AcceptChanges();
                MessageBox.Show("Quiz completed.");
                Close();
            }
            
        }
    }
}
