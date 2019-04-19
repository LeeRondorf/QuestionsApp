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
        Question question = new Question();

        public CreateQuiz()
        {
            InitializeComponent();
        }

        private void editQuestion_Click(object sender, EventArgs e)
        {
            int selectedIndex = questionsList.SelectedIndex;
            quiz.questions[questionsList.SelectedIndex].QuestionName = questionName.Text;
            quiz.questions[questionsList.SelectedIndex].questionText = questionTextBox.Text;
            refreshQuestionsList();
        }

        private void delQuestion_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void saveQuestion_Click(object sender, EventArgs e)
        {
            question.QuestionName = questionName.Text;
            question.questionText = questionTextBox.Text;
            quiz.questions.Add(question);
            //questionsList.Items.Add(question.QuestionName);
            resetQuestionBoxes();
            refreshQuestionsList();
            question = new Question();
        }

        private void addAnswer_Click(object sender, EventArgs e)
        {
            Answer answer = new Answer();
            answer.answerText = possibleAnswerTextBox.Text;
            answer.correct = correctAnswerBox.Checked;
            question.answers.Add(answer);
            answersList.Items.Add(answer.answerText);
            //refreshAnswersList();
        }

        private void editAnswer_Click(object sender, EventArgs e)
        {
            int selectedIndex = answersList.SelectedIndex;
            quiz.questions[questionsList.SelectedIndex].answers[selectedIndex].answerText = possibleAnswerTextBox.Text;
            quiz.questions[questionsList.SelectedIndex].answers[selectedIndex].correct = correctAnswerBox.Checked;
            refreshAnswersList();
        }

        private void delAnswer_Click(object sender, EventArgs e)
        {
            int selectedIndex = answersList.SelectedIndex;
            quiz.questions[questionsList.SelectedIndex].answers.RemoveAt(selectedIndex);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            quiz.quizTitle = quizNameBox.Text;

            RunSqlCommands connection = new RunSqlCommands();
            connection.saveQuizData(quiz);
        }

        private void answersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = answersList.SelectedIndex;
            Answer selectedAnswer = quiz.questions[questionsList.SelectedIndex].answers[selectedIndex];

            possibleAnswerTextBox.Text = selectedAnswer.answerText;
            correctAnswerBox.Checked = selectedAnswer.correct;
        }

        private void questionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = questionsList.SelectedIndex;
            Question selectedQuestion = quiz.questions[selectedIndex];

            questionName.Text = selectedQuestion.QuestionName;
            questionTextBox.Text = selectedQuestion.questionText;
            refreshAnswersList();
        }

        private void newQuestion_Click(object sender, EventArgs e)
        {
            resetQuestionBoxes();
        }

        private void resetQuestionBoxes()
        {
            questionName.Text = "";
            questionTextBox.Text = "";
            resetAnswerBoxes();
        }

        private void resetAnswerBoxes()
        {
            answersList.Items.Clear();
            possibleAnswerTextBox.Text = "";
            correctAnswerBox.Checked = false;
        }

        private void refreshQuestionsList()
        {
            questionsList.Items.Clear();
            foreach  (Question ques in quiz.questions)
            {
                questionsList.Items.Add(ques.QuestionName);
            }
        }

        private void refreshAnswersList()
        {
            answersList.Items.Clear();
            foreach (Answer ans in quiz.questions[questionsList.SelectedIndex].answers)
            {
                answersList.Items.Add(ans.answerText);
            }
        }



        private void print(string txt)
        {
            System.Diagnostics.Debug.WriteLine(txt);
        }
    }

    class Quiz
    {
        public string quizTitle { get; set; }
        public List<Question> questions = new List<Question>();
    }

    class Question
    {
        private string questionName;
        public string QuestionName
        {
            get { return questionName; }
            set
            {
                if (value == "")
                    questionName = "Unnamed Question";
                else
                    questionName = value;
            }
        }
        
        public string questionText { get; set; }
        public List<Answer> answers = new List<Answer>();
    }

    class Answer
    {
        public string answerText { get; set; }
        public bool correct { get; set; }
    }
}