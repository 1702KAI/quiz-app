namespace WindowsFormsApp4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.studentPanel = new System.Windows.Forms.Panel();
            this.studentRegistrationBtn = new System.Windows.Forms.Button();
            this.studentLoginBtn = new System.Windows.Forms.Button();
            this.studentId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tutorPanel = new System.Windows.Forms.Panel();
            this.tutorLoginBtn = new System.Windows.Forms.Button();
            this.showHidePassword = new System.Windows.Forms.CheckBox();
            this.WrongLabel = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectUserType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.managePanel = new System.Windows.Forms.Panel();
            this.managerLogin = new System.Windows.Forms.Button();
            this.showHidePassword2 = new System.Windows.Forms.CheckBox();
            this.wrongLabel2 = new System.Windows.Forms.Label();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.txtUsername2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.studentPanel.SuspendLayout();
            this.tutorPanel.SuspendLayout();
            this.managePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentPanel
            // 
            this.studentPanel.BackColor = System.Drawing.Color.Transparent;
            this.studentPanel.Controls.Add(this.studentRegistrationBtn);
            this.studentPanel.Controls.Add(this.studentLoginBtn);
            this.studentPanel.Controls.Add(this.tutorPanel);
            this.studentPanel.Controls.Add(this.studentId);
            this.studentPanel.Controls.Add(this.label9);
            this.studentPanel.Controls.Add(this.label10);
            this.studentPanel.Location = new System.Drawing.Point(29, 59);
            this.studentPanel.Name = "studentPanel";
            this.studentPanel.Size = new System.Drawing.Size(480, 395);
            this.studentPanel.TabIndex = 15;
            // 
            // studentRegistrationBtn
            // 
            this.studentRegistrationBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.studentRegistrationBtn.Location = new System.Drawing.Point(191, 230);
            this.studentRegistrationBtn.Name = "studentRegistrationBtn";
            this.studentRegistrationBtn.Size = new System.Drawing.Size(95, 36);
            this.studentRegistrationBtn.TabIndex = 10;
            this.studentRegistrationBtn.Text = "Register";
            this.studentRegistrationBtn.UseVisualStyleBackColor = true;
            this.studentRegistrationBtn.Click += new System.EventHandler(this.studentRegistrationBtn_Click);
            // 
            // studentLoginBtn
            // 
            this.studentLoginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.studentLoginBtn.Location = new System.Drawing.Point(191, 185);
            this.studentLoginBtn.Name = "studentLoginBtn";
            this.studentLoginBtn.Size = new System.Drawing.Size(95, 36);
            this.studentLoginBtn.TabIndex = 9;
            this.studentLoginBtn.Text = "Login";
            this.studentLoginBtn.UseVisualStyleBackColor = true;
            this.studentLoginBtn.Click += new System.EventHandler(this.studentLoginBtn_Click);
            // 
            // studentId
            // 
            this.studentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentId.Location = new System.Drawing.Point(106, 115);
            this.studentId.Name = "studentId";
            this.studentId.Size = new System.Drawing.Size(267, 29);
            this.studentId.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(102, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "Enter Student ID";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(142, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(188, 32);
            this.label10.TabIndex = 4;
            this.label10.Text = "Student Login";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tutorPanel
            // 
            this.tutorPanel.BackColor = System.Drawing.Color.Transparent;
            this.tutorPanel.Controls.Add(this.tutorLoginBtn);
            this.tutorPanel.Controls.Add(this.showHidePassword);
            this.tutorPanel.Controls.Add(this.WrongLabel);
            this.tutorPanel.Controls.Add(this.txtPassword);
            this.tutorPanel.Controls.Add(this.txtUsername);
            this.tutorPanel.Controls.Add(this.label5);
            this.tutorPanel.Controls.Add(this.label4);
            this.tutorPanel.Controls.Add(this.label3);
            this.tutorPanel.Location = new System.Drawing.Point(19, 24);
            this.tutorPanel.Name = "tutorPanel";
            this.tutorPanel.Size = new System.Drawing.Size(480, 395);
            this.tutorPanel.TabIndex = 14;
            // 
            // tutorLoginBtn
            // 
            this.tutorLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorLoginBtn.Location = new System.Drawing.Point(191, 273);
            this.tutorLoginBtn.Name = "tutorLoginBtn";
            this.tutorLoginBtn.Size = new System.Drawing.Size(75, 34);
            this.tutorLoginBtn.TabIndex = 9;
            this.tutorLoginBtn.Text = "Login";
            this.tutorLoginBtn.UseVisualStyleBackColor = true;
            this.tutorLoginBtn.Click += new System.EventHandler(this.tutorLoginBtn_Click);
            // 
            // showHidePassword
            // 
            this.showHidePassword.AutoSize = true;
            this.showHidePassword.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.showHidePassword.ForeColor = System.Drawing.Color.White;
            this.showHidePassword.Location = new System.Drawing.Point(177, 236);
            this.showHidePassword.Name = "showHidePassword";
            this.showHidePassword.Size = new System.Drawing.Size(129, 21);
            this.showHidePassword.TabIndex = 4;
            this.showHidePassword.Text = "Show password";
            this.showHidePassword.UseVisualStyleBackColor = true;
            this.showHidePassword.CheckedChanged += new System.EventHandler(this.showHidePassword_CheckedChanged);
            // 
            // WrongLabel
            // 
            this.WrongLabel.AutoSize = true;
            this.WrongLabel.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.WrongLabel.ForeColor = System.Drawing.Color.Red;
            this.WrongLabel.Location = new System.Drawing.Point(125, 310);
            this.WrongLabel.Name = "WrongLabel";
            this.WrongLabel.Size = new System.Drawing.Size(223, 17);
            this.WrongLabel.TabIndex = 8;
            this.WrongLabel.Text = "Username or password is invalid";
            this.WrongLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(106, 189);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(267, 29);
            this.txtPassword.TabIndex = 7;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(106, 115);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(267, 29);
            this.txtUsername.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(147, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Enter Password";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(147, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter Username";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(149, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tutor Login";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // selectUserType
            // 
            this.selectUserType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectUserType.FormattingEnabled = true;
            this.selectUserType.Items.AddRange(new object[] {
            "Student Login",
            "Tutor Login",
            "Manager Login"});
            this.selectUserType.Location = new System.Drawing.Point(638, 128);
            this.selectUserType.Name = "selectUserType";
            this.selectUserType.Size = new System.Drawing.Size(242, 32);
            this.selectUserType.TabIndex = 13;
            this.selectUserType.SelectedIndexChanged += new System.EventHandler(this.selectUserType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(439, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select User Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(547, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 77);
            this.label1.TabIndex = 11;
            this.label1.Text = "Quizz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // managePanel
            // 
            this.managePanel.BackColor = System.Drawing.Color.Transparent;
            this.managePanel.Controls.Add(this.managerLogin);
            this.managePanel.Controls.Add(this.showHidePassword2);
            this.managePanel.Controls.Add(this.wrongLabel2);
            this.managePanel.Controls.Add(this.txtPassword2);
            this.managePanel.Controls.Add(this.txtUsername2);
            this.managePanel.Controls.Add(this.label7);
            this.managePanel.Controls.Add(this.label8);
            this.managePanel.Controls.Add(this.label11);
            this.managePanel.Location = new System.Drawing.Point(515, 185);
            this.managePanel.Name = "managePanel";
            this.managePanel.Size = new System.Drawing.Size(480, 395);
            this.managePanel.TabIndex = 15;
            // 
            // managerLogin
            // 
            this.managerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLogin.Location = new System.Drawing.Point(191, 273);
            this.managerLogin.Name = "managerLogin";
            this.managerLogin.Size = new System.Drawing.Size(75, 34);
            this.managerLogin.TabIndex = 9;
            this.managerLogin.Text = "Login";
            this.managerLogin.UseVisualStyleBackColor = true;
            this.managerLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // showHidePassword2
            // 
            this.showHidePassword2.AutoSize = true;
            this.showHidePassword2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.showHidePassword2.ForeColor = System.Drawing.Color.White;
            this.showHidePassword2.Location = new System.Drawing.Point(177, 236);
            this.showHidePassword2.Name = "showHidePassword2";
            this.showHidePassword2.Size = new System.Drawing.Size(129, 21);
            this.showHidePassword2.TabIndex = 4;
            this.showHidePassword2.Text = "Show password";
            this.showHidePassword2.UseVisualStyleBackColor = true;
            this.showHidePassword2.CheckedChanged += new System.EventHandler(this.showHidePassword2_CheckedChanged);
            // 
            // wrongLabel2
            // 
            this.wrongLabel2.AutoSize = true;
            this.wrongLabel2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.wrongLabel2.ForeColor = System.Drawing.Color.Red;
            this.wrongLabel2.Location = new System.Drawing.Point(125, 310);
            this.wrongLabel2.Name = "wrongLabel2";
            this.wrongLabel2.Size = new System.Drawing.Size(223, 17);
            this.wrongLabel2.TabIndex = 8;
            this.wrongLabel2.Text = "Username or password is invalid";
            this.wrongLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword2.Location = new System.Drawing.Point(106, 189);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.PasswordChar = '*';
            this.txtPassword2.Size = new System.Drawing.Size(267, 29);
            this.txtPassword2.TabIndex = 7;
            // 
            // txtUsername2
            // 
            this.txtUsername2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername2.Location = new System.Drawing.Point(106, 115);
            this.txtUsername2.Name = "txtUsername2";
            this.txtUsername2.Size = new System.Drawing.Size(267, 29);
            this.txtUsername2.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(147, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 5;
            this.label7.Text = "Enter Password";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(147, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "Enter Username";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(122, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(211, 32);
            this.label11.TabIndex = 4;
            this.label11.Text = "Manager Login";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1275, 685);
            this.Controls.Add(this.managePanel);
            this.Controls.Add(this.studentPanel);
            this.Controls.Add(this.selectUserType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.studentPanel.ResumeLayout(false);
            this.studentPanel.PerformLayout();
            this.tutorPanel.ResumeLayout(false);
            this.tutorPanel.PerformLayout();
            this.managePanel.ResumeLayout(false);
            this.managePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel studentPanel;
        private System.Windows.Forms.Button studentRegistrationBtn;
        private System.Windows.Forms.Button studentLoginBtn;
        private System.Windows.Forms.TextBox studentId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel tutorPanel;
        private System.Windows.Forms.Button tutorLoginBtn;
        private System.Windows.Forms.CheckBox showHidePassword;
        private System.Windows.Forms.Label WrongLabel;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox selectUserType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel managePanel;
        private System.Windows.Forms.Button managerLogin;
        private System.Windows.Forms.CheckBox showHidePassword2;
        private System.Windows.Forms.Label wrongLabel2;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.TextBox txtUsername2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
    }
}

