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
            this.questionsList = new System.Windows.Forms.ListBox();
            this.questionsListLabel = new System.Windows.Forms.Label();
            this.questionPanel = new System.Windows.Forms.Panel();
            this.questionName = new System.Windows.Forms.TextBox();
            this.answersList = new System.Windows.Forms.ListBox();
            this.questionNameLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.answerPanel = new System.Windows.Forms.Panel();
            this.possibleAnswerLabel = new System.Windows.Forms.Label();
            this.correctAnswerBox = new System.Windows.Forms.CheckBox();
            this.possibleAnswerTextBox = new System.Windows.Forms.TextBox();
            this.possibleAnswersLabel = new System.Windows.Forms.Label();
            this.editAnswerButton = new System.Windows.Forms.Button();
            this.delAnswer = new System.Windows.Forms.Button();
            this.addAnswer = new System.Windows.Forms.Button();
            this.newQuestionButton = new System.Windows.Forms.Button();
            this.editQuestionButton = new System.Windows.Forms.Button();
            this.delQuestion = new System.Windows.Forms.Button();
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
            this.saveButton.Location = new System.Drawing.Point(828, 709);
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
            this.questionControls.Controls.Add(this.questionsList);
            this.questionControls.Controls.Add(this.questionsListLabel);
            this.questionControls.Controls.Add(this.questionPanel);
            this.questionControls.Location = new System.Drawing.Point(12, 109);
            this.questionControls.Name = "questionControls";
            this.questionControls.Size = new System.Drawing.Size(954, 594);
            this.questionControls.TabIndex = 2;
            // 
            // questionsList
            // 
            this.questionsList.FormattingEnabled = true;
            this.questionsList.ItemHeight = 20;
            this.questionsList.Location = new System.Drawing.Point(3, 52);
            this.questionsList.Name = "questionsList";
            this.questionsList.Size = new System.Drawing.Size(235, 504);
            this.questionsList.TabIndex = 9;
            this.questionsList.SelectedIndexChanged += new System.EventHandler(this.questionsList_SelectedIndexChanged);
            // 
            // questionsListLabel
            // 
            this.questionsListLabel.AutoSize = true;
            this.questionsListLabel.Location = new System.Drawing.Point(3, 29);
            this.questionsListLabel.Name = "questionsListLabel";
            this.questionsListLabel.Size = new System.Drawing.Size(132, 20);
            this.questionsListLabel.TabIndex = 2;
            this.questionsListLabel.Text = "List of Questions:";
            // 
            // questionPanel
            // 
            this.questionPanel.Controls.Add(this.questionName);
            this.questionPanel.Controls.Add(this.answersList);
            this.questionPanel.Controls.Add(this.questionNameLabel);
            this.questionPanel.Controls.Add(this.questionTextLabel);
            this.questionPanel.Controls.Add(this.answerPanel);
            this.questionPanel.Controls.Add(this.possibleAnswersLabel);
            this.questionPanel.Controls.Add(this.editAnswerButton);
            this.questionPanel.Controls.Add(this.delAnswer);
            this.questionPanel.Controls.Add(this.addAnswer);
            this.questionPanel.Controls.Add(this.newQuestionButton);
            this.questionPanel.Controls.Add(this.editQuestionButton);
            this.questionPanel.Controls.Add(this.delQuestion);
            this.questionPanel.Controls.Add(this.saveQuestion);
            this.questionPanel.Controls.Add(this.questionTextBox);
            this.questionPanel.Location = new System.Drawing.Point(244, 3);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(705, 586);
            this.questionPanel.TabIndex = 0;
            // 
            // questionName
            // 
            this.questionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionName.Location = new System.Drawing.Point(439, 3);
            this.questionName.Name = "questionName";
            this.questionName.Size = new System.Drawing.Size(263, 35);
            this.questionName.TabIndex = 10;
            // 
            // answersList
            // 
            this.answersList.FormattingEnabled = true;
            this.answersList.ItemHeight = 20;
            this.answersList.Location = new System.Drawing.Point(7, 346);
            this.answersList.Name = "answersList";
            this.answersList.Size = new System.Drawing.Size(319, 224);
            this.answersList.TabIndex = 9;
            this.answersList.SelectedIndexChanged += new System.EventHandler(this.answersList_SelectedIndexChanged);
            // 
            // questionNameLabel
            // 
            this.questionNameLabel.AutoSize = true;
            this.questionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNameLabel.Location = new System.Drawing.Point(258, 6);
            this.questionNameLabel.Name = "questionNameLabel";
            this.questionNameLabel.Size = new System.Drawing.Size(187, 29);
            this.questionNameLabel.TabIndex = 2;
            this.questionNameLabel.Text = "Question Name:";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Location = new System.Drawing.Point(3, 26);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(111, 20);
            this.questionTextLabel.TabIndex = 2;
            this.questionTextLabel.Text = "Question Text:";
            // 
            // answerPanel
            // 
            this.answerPanel.Controls.Add(this.possibleAnswerLabel);
            this.answerPanel.Controls.Add(this.correctAnswerBox);
            this.answerPanel.Controls.Add(this.possibleAnswerTextBox);
            this.answerPanel.Location = new System.Drawing.Point(332, 311);
            this.answerPanel.Name = "answerPanel";
            this.answerPanel.Size = new System.Drawing.Size(370, 100);
            this.answerPanel.TabIndex = 8;
            // 
            // possibleAnswerLabel
            // 
            this.possibleAnswerLabel.AutoSize = true;
            this.possibleAnswerLabel.Location = new System.Drawing.Point(3, 12);
            this.possibleAnswerLabel.Name = "possibleAnswerLabel";
            this.possibleAnswerLabel.Size = new System.Drawing.Size(211, 20);
            this.possibleAnswerLabel.TabIndex = 6;
            this.possibleAnswerLabel.Text = "Enter Possible Answer Here:";
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
            // possibleAnswerTextBox
            // 
            this.possibleAnswerTextBox.Location = new System.Drawing.Point(7, 35);
            this.possibleAnswerTextBox.Name = "possibleAnswerTextBox";
            this.possibleAnswerTextBox.Size = new System.Drawing.Size(347, 26);
            this.possibleAnswerTextBox.TabIndex = 5;
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
            // editAnswerButton
            // 
            this.editAnswerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAnswerButton.Location = new System.Drawing.Point(339, 456);
            this.editAnswerButton.Name = "editAnswerButton";
            this.editAnswerButton.Size = new System.Drawing.Size(172, 38);
            this.editAnswerButton.TabIndex = 2;
            this.editAnswerButton.Text = "Edit Answer";
            this.editAnswerButton.UseVisualStyleBackColor = true;
            this.editAnswerButton.Click += new System.EventHandler(this.editAnswer_Click);
            // 
            // delAnswer
            // 
            this.delAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delAnswer.Location = new System.Drawing.Point(339, 500);
            this.delAnswer.Name = "delAnswer";
            this.delAnswer.Size = new System.Drawing.Size(172, 38);
            this.delAnswer.TabIndex = 2;
            this.delAnswer.Text = "Delete Answer";
            this.delAnswer.UseVisualStyleBackColor = true;
            this.delAnswer.Click += new System.EventHandler(this.delAnswer_Click);
            // 
            // addAnswer
            // 
            this.addAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnswer.Location = new System.Drawing.Point(339, 544);
            this.addAnswer.Name = "addAnswer";
            this.addAnswer.Size = new System.Drawing.Size(172, 38);
            this.addAnswer.TabIndex = 2;
            this.addAnswer.Text = "Add Answer";
            this.addAnswer.UseVisualStyleBackColor = true;
            this.addAnswer.Click += new System.EventHandler(this.addAnswer_Click);
            // 
            // newQuestionButton
            // 
            this.newQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuestionButton.Location = new System.Drawing.Point(530, 406);
            this.newQuestionButton.Name = "newQuestionButton";
            this.newQuestionButton.Size = new System.Drawing.Size(172, 42);
            this.newQuestionButton.TabIndex = 1;
            this.newQuestionButton.Text = "New Question";
            this.newQuestionButton.UseVisualStyleBackColor = true;
            this.newQuestionButton.Click += new System.EventHandler(this.newQuestion_Click);
            // 
            // editQuestionButton
            // 
            this.editQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editQuestionButton.Location = new System.Drawing.Point(530, 454);
            this.editQuestionButton.Name = "editQuestionButton";
            this.editQuestionButton.Size = new System.Drawing.Size(172, 42);
            this.editQuestionButton.TabIndex = 1;
            this.editQuestionButton.Text = "Edit Question";
            this.editQuestionButton.UseVisualStyleBackColor = true;
            this.editQuestionButton.Click += new System.EventHandler(this.editQuestion_Click);
            // 
            // delQuestion
            // 
            this.delQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delQuestion.Location = new System.Drawing.Point(530, 498);
            this.delQuestion.Name = "delQuestion";
            this.delQuestion.Size = new System.Drawing.Size(172, 42);
            this.delQuestion.TabIndex = 1;
            this.delQuestion.Text = "Delete Question";
            this.delQuestion.UseVisualStyleBackColor = true;
            this.delQuestion.Click += new System.EventHandler(this.delQuestion_Click);
            // 
            // saveQuestion
            // 
            this.saveQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveQuestion.Location = new System.Drawing.Point(530, 544);
            this.saveQuestion.Name = "saveQuestion";
            this.saveQuestion.Size = new System.Drawing.Size(172, 38);
            this.saveQuestion.TabIndex = 1;
            this.saveQuestion.Text = "Save Question";
            this.saveQuestion.UseVisualStyleBackColor = true;
            this.saveQuestion.Click += new System.EventHandler(this.saveQuestion_Click);
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(3, 51);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(699, 254);
            this.questionTextBox.TabIndex = 0;
            this.questionTextBox.Text = "";
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(592, 709);
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
            this.ClientSize = new System.Drawing.Size(978, 771);
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
        private System.Windows.Forms.Label possibleAnswerLabel;
        private System.Windows.Forms.TextBox possibleAnswerTextBox;
        private System.Windows.Forms.Label possibleAnswersLabel;
        private System.Windows.Forms.Button addAnswer;
        private System.Windows.Forms.Button saveQuestion;
        private System.Windows.Forms.RichTextBox questionTextBox;
        private System.Windows.Forms.Panel answerPanel;
        private System.Windows.Forms.CheckBox correctAnswerBox;
        private System.Windows.Forms.Label questionsListLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ListBox questionsList;
        private System.Windows.Forms.ListBox answersList;
        private System.Windows.Forms.TextBox questionName;
        private System.Windows.Forms.Label questionNameLabel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Button delAnswer;
        private System.Windows.Forms.Button delQuestion;
        private System.Windows.Forms.Button editAnswerButton;
        private System.Windows.Forms.Button editQuestionButton;
        private System.Windows.Forms.Button newQuestionButton;
    }
}