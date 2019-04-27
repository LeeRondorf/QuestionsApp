namespace QuestionsApp
{
    partial class QuizReport
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
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.lblQuizTakenLabel = new System.Windows.Forms.Label();
            this.lblQuizTaken = new System.Windows.Forms.Label();
            this.lblAvgScoreLabel = new System.Windows.Forms.Label();
            this.lblHighScoreLabel = new System.Windows.Forms.Label();
            this.lblLowScoreLabel = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblLowScore = new System.Windows.Forms.Label();
            this.lblAvgScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(39, 48);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(85, 17);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Select User:";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbUsers
            // 
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Location = new System.Drawing.Point(160, 48);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(121, 24);
            this.cmbUsers.TabIndex = 1;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            // 
            // lblQuizTakenLabel
            // 
            this.lblQuizTakenLabel.AutoSize = true;
            this.lblQuizTakenLabel.Location = new System.Drawing.Point(39, 91);
            this.lblQuizTakenLabel.Name = "lblQuizTakenLabel";
            this.lblQuizTakenLabel.Size = new System.Drawing.Size(100, 17);
            this.lblQuizTakenLabel.TabIndex = 2;
            this.lblQuizTakenLabel.Text = "Quizes Taken:";
            // 
            // lblQuizTaken
            // 
            this.lblQuizTaken.AutoSize = true;
            this.lblQuizTaken.Location = new System.Drawing.Point(160, 91);
            this.lblQuizTaken.Name = "lblQuizTaken";
            this.lblQuizTaken.Size = new System.Drawing.Size(0, 17);
            this.lblQuizTaken.TabIndex = 3;
            // 
            // lblAvgScoreLabel
            // 
            this.lblAvgScoreLabel.AutoSize = true;
            this.lblAvgScoreLabel.Location = new System.Drawing.Point(39, 134);
            this.lblAvgScoreLabel.Name = "lblAvgScoreLabel";
            this.lblAvgScoreLabel.Size = new System.Drawing.Size(106, 17);
            this.lblAvgScoreLabel.TabIndex = 4;
            this.lblAvgScoreLabel.Text = "Average Score:";
            // 
            // lblHighScoreLabel
            // 
            this.lblHighScoreLabel.AutoSize = true;
            this.lblHighScoreLabel.Location = new System.Drawing.Point(39, 177);
            this.lblHighScoreLabel.Name = "lblHighScoreLabel";
            this.lblHighScoreLabel.Size = new System.Drawing.Size(101, 17);
            this.lblHighScoreLabel.TabIndex = 6;
            this.lblHighScoreLabel.Text = "Highest Score:";
            // 
            // lblLowScoreLabel
            // 
            this.lblLowScoreLabel.AutoSize = true;
            this.lblLowScoreLabel.Location = new System.Drawing.Point(39, 220);
            this.lblLowScoreLabel.Name = "lblLowScoreLabel";
            this.lblLowScoreLabel.Size = new System.Drawing.Size(97, 17);
            this.lblLowScoreLabel.TabIndex = 7;
            this.lblLowScoreLabel.Text = "Lowest Score:";
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Location = new System.Drawing.Point(160, 177);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(0, 17);
            this.lblHighScore.TabIndex = 8;
            // 
            // lblLowScore
            // 
            this.lblLowScore.AutoSize = true;
            this.lblLowScore.Location = new System.Drawing.Point(160, 220);
            this.lblLowScore.Name = "lblLowScore";
            this.lblLowScore.Size = new System.Drawing.Size(0, 17);
            this.lblLowScore.TabIndex = 9;
            // 
            // lblAvgScore
            // 
            this.lblAvgScore.AutoSize = true;
            this.lblAvgScore.Location = new System.Drawing.Point(160, 134);
            this.lblAvgScore.Name = "lblAvgScore";
            this.lblAvgScore.Size = new System.Drawing.Size(0, 17);
            this.lblAvgScore.TabIndex = 5;
            // 
            // QuizReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 307);
            this.Controls.Add(this.lblLowScore);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.lblLowScoreLabel);
            this.Controls.Add(this.lblHighScoreLabel);
            this.Controls.Add(this.lblAvgScore);
            this.Controls.Add(this.lblAvgScoreLabel);
            this.Controls.Add(this.lblQuizTaken);
            this.Controls.Add(this.lblQuizTakenLabel);
            this.Controls.Add(this.cmbUsers);
            this.Controls.Add(this.lblUser);
            this.Name = "QuizReport";
            this.Text = "QuizReport";
            this.Load += new System.EventHandler(this.QuizReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label lblQuizTakenLabel;
        private System.Windows.Forms.Label lblQuizTaken;
        private System.Windows.Forms.Label lblAvgScoreLabel;
        private System.Windows.Forms.Label lblHighScoreLabel;
        private System.Windows.Forms.Label lblLowScoreLabel;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblLowScore;
        private System.Windows.Forms.Label lblAvgScore;
    }
}