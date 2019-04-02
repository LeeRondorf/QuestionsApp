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
            this.questionPanel = new System.Windows.Forms.Panel();
            this.possibleAnswers = new System.Windows.Forms.FlowLayoutPanel();
            this.questionTitle = new System.Windows.Forms.Label();
            this.nextQuestionButton = new System.Windows.Forms.Button();
            this.questionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionPanel
            // 
            this.questionPanel.Controls.Add(this.questionTitle);
            this.questionPanel.Controls.Add(this.possibleAnswers);
            this.questionPanel.Location = new System.Drawing.Point(12, 12);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(954, 589);
            this.questionPanel.TabIndex = 0;
            // 
            // possibleAnswers
            // 
            this.possibleAnswers.Location = new System.Drawing.Point(3, 367);
            this.possibleAnswers.Name = "possibleAnswers";
            this.possibleAnswers.Size = new System.Drawing.Size(948, 219);
            this.possibleAnswers.TabIndex = 0;
            // 
            // questionTitle
            // 
            this.questionTitle.AutoSize = true;
            this.questionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTitle.Location = new System.Drawing.Point(14, 10);
            this.questionTitle.Name = "questionTitle";
            this.questionTitle.Size = new System.Drawing.Size(172, 37);
            this.questionTitle.TabIndex = 1;
            this.questionTitle.Text = "Question #";
            // 
            // nextQuestionButton
            // 
            this.nextQuestionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestionButton.Location = new System.Drawing.Point(867, 696);
            this.nextQuestionButton.Name = "nextQuestionButton";
            this.nextQuestionButton.Size = new System.Drawing.Size(96, 36);
            this.nextQuestionButton.TabIndex = 1;
            this.nextQuestionButton.Text = "Next Question";
            this.nextQuestionButton.UseVisualStyleBackColor = true;
            // 
            // TakeQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.nextQuestionButton);
            this.Controls.Add(this.questionPanel);
            this.Name = "TakeQuiz";
            this.Text = "TakeQuiz";
            this.questionPanel.ResumeLayout(false);
            this.questionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Label questionTitle;
        private System.Windows.Forms.FlowLayoutPanel possibleAnswers;
        private System.Windows.Forms.Button nextQuestionButton;
    }
}