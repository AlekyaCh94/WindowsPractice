namespace GridviewExample
{
    partial class ForgotPassword
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
            this.textUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.comboBoxSecurityQuestion = new System.Windows.Forms.ComboBox();
            this.textAnswer = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.btnGetAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.Location = new System.Drawing.Point(470, 70);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(118, 26);
            this.textUserName.TabIndex = 11;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(109, 78);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 20);
            this.lblUserName.TabIndex = 10;
            this.lblUserName.Text = "UserName";
            // 
            // comboBoxSecurityQuestion
            // 
            this.comboBoxSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSecurityQuestion.FormattingEnabled = true;
            this.comboBoxSecurityQuestion.Items.AddRange(new object[] {
            "What is your pet name ?",
            "Who is your fav teacher?",
            "What is your school name?",
            "What is your mother\'s middle name?",
            "Which is the city you were born?"});
            this.comboBoxSecurityQuestion.Location = new System.Drawing.Point(377, 164);
            this.comboBoxSecurityQuestion.Name = "comboBoxSecurityQuestion";
            this.comboBoxSecurityQuestion.Size = new System.Drawing.Size(411, 28);
            this.comboBoxSecurityQuestion.TabIndex = 24;
            // 
            // textAnswer
            // 
            this.textAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAnswer.Location = new System.Drawing.Point(467, 258);
            this.textAnswer.Name = "textAnswer";
            this.textAnswer.Size = new System.Drawing.Size(121, 26);
            this.textAnswer.TabIndex = 23;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(109, 258);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(68, 20);
            this.lblAnswer.TabIndex = 22;
            this.lblAnswer.Text = "Answer";
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecurityQuestion.Location = new System.Drawing.Point(109, 173);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(146, 20);
            this.lblSecurityQuestion.TabIndex = 21;
            this.lblSecurityQuestion.Text = "SecurityQuestion";
            // 
            // btnGetAnswer
            // 
            this.btnGetAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAnswer.ForeColor = System.Drawing.Color.Blue;
            this.btnGetAnswer.Location = new System.Drawing.Point(330, 338);
            this.btnGetAnswer.Name = "btnGetAnswer";
            this.btnGetAnswer.Size = new System.Drawing.Size(130, 46);
            this.btnGetAnswer.TabIndex = 25;
            this.btnGetAnswer.Text = "GetPassword";
            this.btnGetAnswer.UseVisualStyleBackColor = true;
            this.btnGetAnswer.Click += new System.EventHandler(this.btnGetAnswer_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetAnswer);
            this.Controls.Add(this.comboBoxSecurityQuestion);
            this.Controls.Add(this.textAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblSecurityQuestion);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.lblUserName);
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ComboBox comboBoxSecurityQuestion;
        private System.Windows.Forms.TextBox textAnswer;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.Button btnGetAnswer;
    }
}