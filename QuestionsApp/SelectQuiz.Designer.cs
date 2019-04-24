namespace QuestionsApp
{
    partial class SelectQuiz
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.quizListBox = new System.Windows.Forms.ListBox();
            this.quizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data = new QuestionsApp.QuestionAppDataSet2();
            this.quizTableAdapter = new QuestionsApp.QuestionAppDataSet2TableAdapters.quizTableAdapter();
            this.selectBtn = new System.Windows.Forms.Button();
            this.questionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionTableAdapter = new QuestionsApp.QuestionAppDataSet2TableAdapters.questionTableAdapter();
            this.answerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.answerTableAdapter = new QuestionsApp.QuestionAppDataSet2TableAdapters.answerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(12, 386);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(162, 38);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // quizListBox
            // 
            this.quizListBox.DataSource = this.quizBindingSource;
            this.quizListBox.DisplayMember = "quizName";
            this.quizListBox.FormattingEnabled = true;
            this.quizListBox.ItemHeight = 20;
            this.quizListBox.Location = new System.Drawing.Point(12, 12);
            this.quizListBox.Name = "quizListBox";
            this.quizListBox.Size = new System.Drawing.Size(370, 344);
            this.quizListBox.TabIndex = 1;
            this.quizListBox.SelectedIndexChanged += new System.EventHandler(this.quizListBox_SelectedIndexChanged);
            // 
            // quizBindingSource
            // 
            this.quizBindingSource.DataMember = "quiz";
            this.quizBindingSource.DataSource = this.data;
            // 
            // data
            // 
            this.data.DataSetName = "QuestionAppDataSet2";
            this.data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quizTableAdapter
            // 
            this.quizTableAdapter.ClearBeforeFill = true;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(231, 386);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(151, 38);
            this.selectBtn.TabIndex = 2;
            this.selectBtn.Text = "Select";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // questionBindingSource
            // 
            this.questionBindingSource.DataMember = "question";
            this.questionBindingSource.DataSource = this.data;
            // 
            // questionTableAdapter
            // 
            this.questionTableAdapter.ClearBeforeFill = true;
            // 
            // answerBindingSource
            // 
            this.answerBindingSource.DataMember = "answer";
            this.answerBindingSource.DataSource = this.data;
            // 
            // answerTableAdapter
            // 
            this.answerTableAdapter.ClearBeforeFill = true;
            // 
            // SelectQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 436);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.quizListBox);
            this.Controls.Add(this.cancelBtn);
            this.Name = "SelectQuiz";
            this.Text = "SelectQuiz";
            this.Load += new System.EventHandler(this.SelectQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ListBox quizListBox;
        private QuestionAppDataSet2 data;
        private System.Windows.Forms.BindingSource quizBindingSource;
        private QuestionAppDataSet2TableAdapters.quizTableAdapter quizTableAdapter;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.BindingSource questionBindingSource;
        private QuestionAppDataSet2TableAdapters.questionTableAdapter questionTableAdapter;
        private System.Windows.Forms.BindingSource answerBindingSource;
        private QuestionAppDataSet2TableAdapters.answerTableAdapter answerTableAdapter;
    }
}