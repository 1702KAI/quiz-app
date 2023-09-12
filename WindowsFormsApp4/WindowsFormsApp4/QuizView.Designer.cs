namespace WindowsFormsApp4
{
    partial class QuizView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizView));
            this.nextQuestionBtn = new System.Windows.Forms.Button();
            this.previousQuestionBtn = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHint = new System.Windows.Forms.TextBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuestionNumber = new System.Windows.Forms.Label();
            this.updateQuestionBtn = new System.Windows.Forms.Button();
            this.finishQuizBtn = new System.Windows.Forms.Button();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextQuestionBtn
            // 
            this.nextQuestionBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextQuestionBtn.Location = new System.Drawing.Point(1075, 474);
            this.nextQuestionBtn.Name = "nextQuestionBtn";
            this.nextQuestionBtn.Size = new System.Drawing.Size(125, 44);
            this.nextQuestionBtn.TabIndex = 1;
            this.nextQuestionBtn.Text = "Next ";
            this.nextQuestionBtn.UseVisualStyleBackColor = true;
            this.nextQuestionBtn.Click += new System.EventHandler(this.nextQuestionBtn_Click);
            // 
            // previousQuestionBtn
            // 
            this.previousQuestionBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousQuestionBtn.Location = new System.Drawing.Point(931, 474);
            this.previousQuestionBtn.Name = "previousQuestionBtn";
            this.previousQuestionBtn.Size = new System.Drawing.Size(125, 44);
            this.previousQuestionBtn.TabIndex = 8;
            this.previousQuestionBtn.Text = "Previous";
            this.previousQuestionBtn.UseVisualStyleBackColor = true;
            this.previousQuestionBtn.Click += new System.EventHandler(this.previousQuestionBtn_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(85, 128);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(592, 26);
            this.txtQuestion.TabIndex = 9;
            // 
            // txtOptionA
            // 
            this.txtOptionA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionA.Location = new System.Drawing.Point(85, 196);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.Size = new System.Drawing.Size(592, 26);
            this.txtOptionA.TabIndex = 10;
            // 
            // txtOptionB
            // 
            this.txtOptionB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionB.Location = new System.Drawing.Point(85, 257);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.Size = new System.Drawing.Size(592, 26);
            this.txtOptionB.TabIndex = 11;
            // 
            // txtOptionC
            // 
            this.txtOptionC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionC.Location = new System.Drawing.Point(85, 330);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.Size = new System.Drawing.Size(592, 26);
            this.txtOptionC.TabIndex = 12;
            // 
            // txtOptionD
            // 
            this.txtOptionD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionD.Location = new System.Drawing.Point(85, 405);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.Size = new System.Drawing.Size(592, 26);
            this.txtOptionD.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(82, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(82, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "Option A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Option B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(82, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Option C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(82, 379);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Option D";
            // 
            // txtHint
            // 
            this.txtHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHint.Location = new System.Drawing.Point(757, 276);
            this.txtHint.Name = "txtHint";
            this.txtHint.Size = new System.Drawing.Size(463, 26);
            this.txtHint.TabIndex = 19;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(757, 196);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(463, 26);
            this.txtAnswer.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(754, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Answer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(754, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Hint";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(754, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Question Number";
            // 
            // txtQuestionNumber
            // 
            this.txtQuestionNumber.AutoSize = true;
            this.txtQuestionNumber.BackColor = System.Drawing.Color.Transparent;
            this.txtQuestionNumber.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestionNumber.ForeColor = System.Drawing.Color.White;
            this.txtQuestionNumber.Location = new System.Drawing.Point(754, 128);
            this.txtQuestionNumber.Name = "txtQuestionNumber";
            this.txtQuestionNumber.Size = new System.Drawing.Size(21, 23);
            this.txtQuestionNumber.TabIndex = 24;
            this.txtQuestionNumber.Text = "1";
            // 
            // updateQuestionBtn
            // 
            this.updateQuestionBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateQuestionBtn.Location = new System.Drawing.Point(931, 409);
            this.updateQuestionBtn.Name = "updateQuestionBtn";
            this.updateQuestionBtn.Size = new System.Drawing.Size(269, 44);
            this.updateQuestionBtn.TabIndex = 25;
            this.updateQuestionBtn.Text = "Update Question";
            this.updateQuestionBtn.UseVisualStyleBackColor = true;
            this.updateQuestionBtn.Click += new System.EventHandler(this.updateQuestionBtn_Click);
            // 
            // finishQuizBtn
            // 
            this.finishQuizBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishQuizBtn.Location = new System.Drawing.Point(931, 543);
            this.finishQuizBtn.Name = "finishQuizBtn";
            this.finishQuizBtn.Size = new System.Drawing.Size(269, 44);
            this.finishQuizBtn.TabIndex = 26;
            this.finishQuizBtn.Text = "Finish ";
            this.finishQuizBtn.UseVisualStyleBackColor = true;
            this.finishQuizBtn.Click += new System.EventHandler(this.finishQuizBtn_Click);
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.BackColor = System.Drawing.Color.Transparent;
            this.subjectLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.ForeColor = System.Drawing.Color.White;
            this.subjectLabel.Location = new System.Drawing.Point(83, 44);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(79, 23);
            this.subjectLabel.TabIndex = 27;
            this.subjectLabel.Text = "Subject";
            // 
            // QuizView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1275, 685);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.finishQuizBtn);
            this.Controls.Add(this.updateQuestionBtn);
            this.Controls.Add(this.txtQuestionNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.txtHint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOptionD);
            this.Controls.Add(this.txtOptionC);
            this.Controls.Add(this.txtOptionB);
            this.Controls.Add(this.txtOptionA);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.previousQuestionBtn);
            this.Controls.Add(this.nextQuestionBtn);
            this.Name = "QuizView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizView";
            this.Load += new System.EventHandler(this.QuizView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button nextQuestionBtn;
        private System.Windows.Forms.Button previousQuestionBtn;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHint;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtQuestionNumber;
        private System.Windows.Forms.Button updateQuestionBtn;
        private System.Windows.Forms.Button finishQuizBtn;
        private System.Windows.Forms.Label subjectLabel;
    }
}