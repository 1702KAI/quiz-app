namespace WindowsFormsApp4
{
    partial class Tutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tutor));
            this.createQuiz = new System.Windows.Forms.Button();
            this.viewQuizBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tutorLogOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createQuiz
            // 
            this.createQuiz.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createQuiz.Location = new System.Drawing.Point(432, 260);
            this.createQuiz.Name = "createQuiz";
            this.createQuiz.Size = new System.Drawing.Size(235, 99);
            this.createQuiz.TabIndex = 0;
            this.createQuiz.Text = "Create Quiz";
            this.createQuiz.UseVisualStyleBackColor = true;
            this.createQuiz.Click += new System.EventHandler(this.createQuiz_Click);
            // 
            // viewQuizBtn
            // 
            this.viewQuizBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuizBtn.Location = new System.Drawing.Point(673, 260);
            this.viewQuizBtn.Name = "viewQuizBtn";
            this.viewQuizBtn.Size = new System.Drawing.Size(235, 99);
            this.viewQuizBtn.TabIndex = 1;
            this.viewQuizBtn.Text = "View Quiz";
            this.viewQuizBtn.UseVisualStyleBackColor = true;
            this.viewQuizBtn.Click += new System.EventHandler(this.viewQuizBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(480, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "What would you like to do?";
            // 
            // tutorLogOutButton
            // 
            this.tutorLogOutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutorLogOutButton.Location = new System.Drawing.Point(622, 400);
            this.tutorLogOutButton.Name = "tutorLogOutButton";
            this.tutorLogOutButton.Size = new System.Drawing.Size(95, 42);
            this.tutorLogOutButton.TabIndex = 4;
            this.tutorLogOutButton.Text = "Log Out";
            this.tutorLogOutButton.UseVisualStyleBackColor = true;
            this.tutorLogOutButton.Click += new System.EventHandler(this.tutorLogOutButton_Click);
            // 
            // Tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1275, 685);
            this.Controls.Add(this.tutorLogOutButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.viewQuizBtn);
            this.Controls.Add(this.createQuiz);
            this.Name = "Tutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createQuiz;
        private System.Windows.Forms.Button viewQuizBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tutorLogOutButton;
    }
}