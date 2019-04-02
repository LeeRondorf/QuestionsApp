namespace QuestionsApp
{
    partial class CreateQuiz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quizNameLabel = new System.Windows.Forms.Label();
            this.quizNameBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.questionControls = new System.Windows.Forms.Panel();
            this.questionsListLabel = new System.Windows.Forms.Label();
            this.questionsList = new System.Windows.Forms.ListView();
            this.questionPanel = new System.Windows.Forms.Panel();
            this.answerPanel = new System.Windows.Forms.Panel();
            this.possibleAnswerTextBox = new System.Windows.Forms.Label();
            this.correctAnswerBox = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.possibleAnswersLabel = new System.Windows.Forms.Label();
            this.possibleAnswers = new System.Windows.Forms.ListView();
            this.addAnswer = new System.Windows.Forms.Button();
            this.saveQuestion = new System.Windows.Forms.Button();
            this.questionTextBox = new System.Windows.Forms.RichTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.questionControls.SuspendLayout();
            this.questionPanel.SuspendLayout();
            this.answerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.quizNameLabel);
            this.groupBox1.Controls.Add(this.quizNameBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(954, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quiz Info";
            // 
            // quizNameLabel
            // 
            this.quizNameLabel.AutoSize = true;
            this.quizNameLabel.Location = new System.Drawing.Point(7, 37);
            this.quizNameLabel.Name = "quizNameLabel";
            this.quizNameLabel.Size = new System.Drawing.Size(133, 29);
            this.quizNameLabel.TabIndex = 1;
            this.quizNameLabel.Text = "Quiz Name";
            // 
            // quizNameBox
            // 
            this.quizNameBox.Location = new System.Drawing.Point(146, 34);
            this.quizNameBox.Name = "quizNameBox";
            this.quizNameBox.Size = new System.Drawing.Size(231, 35);
            this.quizNameBox.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(832, 685);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(134, 50);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save Quiz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // questionControls
            // 
            this.questionControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionControls.Controls.Add(this.questionsListLabel);
            this.questionControls.Controls.Add(this.questionsList);
            this.questionControls.Controls.Add(this.questionPanel);
            this.questionControls.Location = new System.Drawing.Point(12, 109);
            this.questionControls.Name = "questionControls";
            this.questionControls.Size = new System.Drawing.Size(954, 571);
            this.questionControls.TabIndex = 2;
            // 
            // questionsListLabel
            // 
            this.questionsListLabel.AutoSize = true;
            this.questionsListLabel.Location = new System.Drawing.Point(7, 9);
            this.questionsListLabel.Name = "questionsListLabel";
            this.questionsListLabel.Size = new System.Drawing.Size(132, 20);
            this.questionsListLabel.TabIndex = 2;
            this.questionsListLabel.Text = "List of Questions:";
            // 
            // questionsList
            // 
            this.questionsList.Location = new System.Drawing.Point(3, 32);
            this.questionsList.Name = "questionsList";
            this.questionsList.Size = new System.Drawing.Size(235, 531);
            this.questionsList.TabIndex = 1;
            this.questionsList.UseCompatibleStateImageBehavior = false;
            // 
            // questionPanel
            // 
            this.questionPanel.Controls.Add(this.answerPanel);
            this.questionPanel.Controls.Add(this.possibleAnswersLabel);
            this.questionPanel.Controls.Add(this.possibleAnswers);
            this.questionPanel.Controls.Add(this.addAnswer);
            this.questionPanel.Controls.Add(this.saveQuestion);
            this.questionPanel.Controls.Add(this.questionTextBox);
            this.questionPanel.Location = new System.Drawing.Point(244, 3);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(705, 563);
            this.questionPanel.TabIndex = 0;
            // 
            // answerPanel
            // 
            this.answerPanel.Controls.Add(this.possibleAnswerTextBox);
            this.answerPanel.Controls.Add(this.correctAnswerBox);
            this.answerPanel.Controls.Add(this.textBox1);
            this.answerPanel.Location = new System.Drawing.Point(332, 311);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.Size = new System.Drawing.Size(370, 100);
            this.answerPanel.TabIndex = 8;
            // 
            // possibleAnswerTextBox
            // 
            this.possibleAnswerTextBox.AutoSize = true;
            this.possibleAnswerTextBox.Location = new System.Drawing.Point(3, 12);
            this.possibleAnswerTextBox.Name = "possibleAnswerTextBox";
            this.possibleAnswerTextBox.Size = new System.Drawing.Size(211, 20);
            this.possibleAnswerTextBox.TabIndex = 6;
            this.possibleAnswerTextBox.Text = "Enter Possible Answer Here:";
            // 
            // correctAnswerBox
            // 
            this.correctAnswerBox.AutoSize = true;
            this.correctAnswerBox.Location = new System.Drawing.Point(7, 67);
            this.correctAnswerBox.Name = "correctAnswerBox";
            this.correctAnswerBox.Size = new System.Drawing.Size(153, 24);
            this.correctAnswerBox.TabIndex = 7;
            this.correctAnswerBox.Text = "Correct Answer?";
            this.correctAnswerBox.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 26);
            this.textBox1.TabIndex = 5;
            // 
            // possibleAnswersLabel
            // 
            this.possibleAnswersLabel.AutoSize = true;
            this.possibleAnswersLabel.Location = new System.Drawing.Point(3, 316);
            this.possibleAnswersLabel.Name = "possibleAnswersLabel";
            this.possibleAnswersLabel.Size = new System.Drawing.Size(137, 20);
            this.possibleAnswersLabel.TabIndex = 4;
            this.possibleAnswersLabel.Text = "Possible Answers:";
            // 
            // possibleAnswers
            // 
            this.possibleAnswers.Location = new System.Drawing.Point(3, 339);
            this.possibleAnswers.Name = "possibleAnswers";
            this.possibleAnswers.Size = new System.Drawing.Size(312, 221);
            this.possibleAnswers.TabIndex = 3;
            this.possibleAnswers.UseCompatibleStateImageBehavior = false;
            // 
            // addAnswer
            // 
            this.addAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnswer.Location = new System.Drawing.Point(517, 474);
            this.addAnswer.Name = "addAnswer";
            this.addAnswer.Size = new System.Drawing.Size(185, 38);
            this.addAnswer.TabIndex = 2;
            this.addAnswer.Text = "Add Answer";
            this.addAnswer.UseVisualStyleBackColor = true;
            this.addAnswer.Click += new System.EventHandler(this.addAnswer_Click);
            // 
            // saveQuestion
            // 
            this.saveQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveQuestion.Location = new System.Drawing.Point(517, 518);
            this.saveQuestion.Name = "saveQuestion";
            this.saveQuestion.Size = new System.Drawing.Size(185, 42);
            this.saveQuestion.TabIndex = 1;
            this.saveQuestion.Text = "Save Question";
            this.saveQuestion.UseVisualStyleBackColor = true;
            this.saveQuestion.Click += new System.EventHandler(this.saveQuestion_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(3, 3);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(699, 302);
            this.questionTextBox.TabIndex = 0;
            this.questionTextBox.Text = "";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(596, 685);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(230, 50);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel (no save)";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // CreateQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.questionControls);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateQuiz";
            this.Text = "CreateQuiz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.questionControls.ResumeLayout(false);
            this.questionControls.PerformLayout();
            this.questionPanel.ResumeLayout(false);
            this.questionPanel.PerformLayout();
            this.answerPanel.ResumeLayout(false);
            this.answerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label quizNameLabel;
        private System.Windows.Forms.TextBox quizNameBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel questionControls;
        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Label possibleAnswerTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label possibleAnswersLabel;
        private System.Windows.Forms.ListView possibleAnswers;
        private System.Windows.Forms.Button addAnswer;
        private System.Windows.Forms.Button saveQuestion;
        private System.Windows.Forms.RichTextBox questionTextBox;
        private System.Windows.Forms.Panel answerPanel;
        private System.Windows.Forms.CheckBox correctAnswerBox;
        private System.Windows.Forms.Label questionsListLabel;
        private System.Windows.Forms.ListView questionsList;
        private System.Windows.Forms.Button cancelButton;
    }
}