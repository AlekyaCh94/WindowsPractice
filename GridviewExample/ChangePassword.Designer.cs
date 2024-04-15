namespace GridviewExample
{
    partial class ChangePassword
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
            this.textNewPassword = new System.Windows.Forms.TextBox();
            this.textCurrentPassword = new System.Windows.Forms.TextBox();
            this.textUserName = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.textConfirmedPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmedPassword = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lnkLogOut = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textNewPassword
            // 
            this.textNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNewPassword.Location = new System.Drawing.Point(518, 245);
            this.textNewPassword.Name = "textNewPassword";
            this.textNewPassword.Size = new System.Drawing.Size(100, 26);
            this.textNewPassword.TabIndex = 17;
            // 
            // textCurrentPassword
            // 
            this.textCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCurrentPassword.Location = new System.Drawing.Point(518, 168);
            this.textCurrentPassword.Name = "textCurrentPassword";
            this.textCurrentPassword.Size = new System.Drawing.Size(100, 26);
            this.textCurrentPassword.TabIndex = 16;
            // 
            // textUserName
            // 
            this.textUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUserName.Location = new System.Drawing.Point(518, 99);
            this.textUserName.Name = "textUserName";
            this.textUserName.Size = new System.Drawing.Size(100, 26);
            this.textUserName.TabIndex = 15;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.Location = new System.Drawing.Point(160, 253);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(120, 20);
            this.lblNewPassword.TabIndex = 14;
            this.lblNewPassword.Text = "NewPassword";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.Location = new System.Drawing.Point(160, 176);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(151, 20);
            this.lblCurrentPassword.TabIndex = 13;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(157, 107);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(93, 20);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "UserName";
            // 
            // textConfirmedPassword
            // 
            this.textConfirmedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmedPassword.Location = new System.Drawing.Point(518, 333);
            this.textConfirmedPassword.Name = "textConfirmedPassword";
            this.textConfirmedPassword.Size = new System.Drawing.Size(100, 26);
            this.textConfirmedPassword.TabIndex = 19;
            // 
            // lblConfirmedPassword
            // 
            this.lblConfirmedPassword.AutoSize = true;
            this.lblConfirmedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmedPassword.Location = new System.Drawing.Point(160, 341);
            this.lblConfirmedPassword.Name = "lblConfirmedPassword";
            this.lblConfirmedPassword.Size = new System.Drawing.Size(148, 20);
            this.lblConfirmedPassword.TabIndex = 18;
            this.lblConfirmedPassword.Text = "ConfirmPassword";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Blue;
            this.btnUpdate.Location = new System.Drawing.Point(319, 430);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 81);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lnkLogOut
            // 
            this.lnkLogOut.AutoSize = true;
            this.lnkLogOut.Location = new System.Drawing.Point(763, 39);
            this.lnkLogOut.Name = "lnkLogOut";
            this.lnkLogOut.Size = new System.Drawing.Size(42, 13);
            this.lnkLogOut.TabIndex = 21;
            this.lnkLogOut.TabStop = true;
            this.lnkLogOut.Text = "LogOut";
            this.lnkLogOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLogOut_LinkClicked);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 543);
            this.Controls.Add(this.lnkLogOut);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textConfirmedPassword);
            this.Controls.Add(this.lblConfirmedPassword);
            this.Controls.Add(this.textNewPassword);
            this.Controls.Add(this.textCurrentPassword);
            this.Controls.Add(this.textUserName);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.lblUserName);
            this.Name = "ChangePassword";
            this.Text = "ChangePassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textNewPassword;
        private System.Windows.Forms.TextBox textCurrentPassword;
        private System.Windows.Forms.TextBox textUserName;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox textConfirmedPassword;
        private System.Windows.Forms.Label lblConfirmedPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.LinkLabel lnkLogOut;
    }
}