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
    public partial class SelectQuiz : Form
    {
        string account { get; set; }
        public SelectQuiz(string username)
        {
            InitializeComponent();
            account = username;
        }

        private void quizListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectQuiz_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data.answer' table. You can move, or remove it, as needed.
            this.answerTableAdapter.Fill(this.data.answer);
            // TODO: This line of code loads data into the 'data.question' table. You can move, or remove it, as needed.
            this.questionTableAdapter.Fill(this.data.question);
            quizTableAdapter.Fill(data.quiz);
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            int id = data.quiz.ElementAt(quizListBox.SelectedIndex).quizID;
            
            var quizRow = data.quiz.FindByquizID(id);
            Quiz quiz = new Quiz();
            quiz.id = quizRow.quizID;
            quiz.quizTitle = quizRow.quizName;

            var questionRow = data.question.Select("quizID="+id);

            foreach (var quesRow in questionRow)
            {
                Question question = new Question();
                question.id = Convert.ToInt32(quesRow["questionID"]);
                question.QuestionName = quesRow["questionName"].ToString();
                question.questionText = quesRow["questionText"].ToString();

                var answerRow = data.answer.Select("questionID="+question.id);
                foreach (var ansRow in answerRow)
                {
                    Answer answer = new Answer();
                    answer.id = Convert.ToInt32(ansRow["answerID"]);
                    answer.answerText = ansRow["answerText"].ToString();
                    answer.correct = Convert.ToBoolean(ansRow["answerCorrect"]);
                    question.answers.Add(answer);
                }
                quiz.questions.Add(question);
            }

            TakeQuiz takeQuiz = new TakeQuiz(account, quiz);
            takeQuiz.MdiParent = ActiveForm;
            takeQuiz.Show();
            Close();
        }
    }
}
