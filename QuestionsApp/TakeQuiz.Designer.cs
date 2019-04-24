namespace QuestionsApp
{
    partial class TakeQuiz
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
            this.components = new System.ComponentModel.Container();
            this.questionPanel = new System.Windows.Forms.Panel();
            this.questionNameTextBox = new System.Windows.Forms.TextBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.possibleAnswersListBox = new System.Windows.Forms.ListBox();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.data = new QuestionsApp.QuestionAppDataSet2();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new QuestionsApp.QuestionAppDataSet2TableAdapters.usersTableAdapter();
            this.responseTableAdapter = new QuestionsApp.QuestionAppDataSet2TableAdapters.responseTableAdapter();
            this.progressTextBox = new System.Windows.Forms.TextBox();
            this.progressLabel = new System.Windows.Forms.Label();
            this.responseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // questionPanel
            // 
            this.questionPanel.Controls.Add(this.questionNameTextBox);
            this.questionPanel.Controls.Add(this.questionTextBox);
            this.questionPanel.Controls.Add(this.possibleAnswersListBox);
            this.questionPanel.Location = new System.Drawing.Point(12, 12);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(954, 629);
            this.questionPanel.TabIndex = 0;
            // 
            // questionNameTextBox
            // 
            this.questionNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNameTextBox.Location = new System.Drawing.Point(3, 3);
            this.questionNameTextBox.Name = "questionNameTextBox";
            this.questionNameTextBox.ReadOnly = true;
            this.questionNameTextBox.Size = new System.Drawing.Size(948, 89);
            this.questionNameTextBox.TabIndex = 2;
            this.questionNameTextBox.Text = "QuestionName";
            this.questionNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextBox.Location = new System.Drawing.Point(3, 101);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.ReadOnly = true;
            this.questionTextBox.Size = new System.Drawing.Size(948, 247);
            this.questionTextBox.TabIndex = 1;
            // 
            // possibleAnswersListBox
            // 
            this.possibleAnswersListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.possibleAnswersListBox.FormattingEnabled = true;
            this.possibleAnswersListBox.ItemHeight = 25;
            this.possibleAnswersListBox.Location = new System.Drawing.Point(3, 362);
            this.possibleAnswersListBox.Name = "possibleAnswersListBox";
            this.possibleAnswersListBox.Size = new System.Drawing.Size(948, 254);
            this.possibleAnswersListBox.TabIndex = 0;
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestionButton.Location = new System.Drawing.Point(814, 661);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(149, 71);
            this.nextQuestionButton.TabIndex = 1;
            this.nextQuestionButton.Text = "Next Question";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            this.nextQuestionButton.Click += new System.EventHandler(this.nextQuestionButton_Click);
            // 
            // data
            // 
            this.data.DataSetName = "QuestionAppDataSet2";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.data;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // progressTextBox
            // 
            this.progressTextBox.Location = new System.Drawing.Point(681, 686);
            this.progressTextBox.Name = "progressTextBox";
            this.progressTextBox.ReadOnly = true;
            this.progressTextBox.Size = new System.Drawing.Size(100, 26);
            this.progressTextBox.TabIndex = 2;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(599, 689);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(76, 20);
            this.progressLabel.TabIndex = 3;
            this.progressLabel.Text = "Progress:";
            // 
            // responseBindingSource
            // 
            this.responseBindingSource.DataMember = "response";
            this.responseBindingSource.DataSource = this.data;
            // 
            // TakeQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.progressTextBox);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.questionPanel);
            this.Name = "TakeQuiz";
            this.Text = "TakeQuiz";
            this.questionPanel.ResumeLayout(false);
            this.questionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Button nextQuestionButton;
        private QuestionAppDataSet2 data;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private QuestionAppDataSet2TableAdapters.usersTableAdapter usersTableAdapter;
        private QuestionAppDataSet2TableAdapters.responseTableAdapter responseTableAdapter;
        private System.Windows.Forms.ListBox possibleAnswersListBox;
        private System.Windows.Forms.TextBox questionNameTextBox;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox progressTextBox;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.BindingSource responseBindingSource;
    }
}