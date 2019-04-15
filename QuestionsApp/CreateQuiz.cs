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
    public partial class CreateQuiz : Form
    {
        Quiz quiz = new Quiz();

        public CreateQuiz()
        {
            InitializeComponent();
        }

        private void saveQuestion_Click(object sender, EventArgs e)
        {
            Question question = new Question();
            question.questionText = questionTextBox.Text;
            quiz.questions.Add(question);
        }

        private void addAnswer_Click(object sender, EventArgs e)
        {
            Answer answer = new Answer();
            answer.answerText = possibleAnswerTextBox.Text;
            answer.correct = correctAnswerBox.Checked;
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            quiz.quizTitle = quizNameBox.Text;
        }
    }

    class Quiz
    {
        public string quizTitle { get; set; }
        public List<Question> questions = new List<Question>();
    }

    class Question
    {
        public string questionText { get; set; }
        public List<Answer> answers = new List<Answer>();
    }

    class Answer
    {
        public string answerText { get; set; }
        public bool correct { get; set; }
    }
}
