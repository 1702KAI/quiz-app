namespace WindowsFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateQuiz));
            this.nextForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEnterSubjectName = new System.Windows.Forms.TextBox();
            this.subjectErrorLabel = new System.Windows.Forms.Label();
            this.clearSubjectNameBtn = new System.Windows.Forms.Button();
            this.addSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nextForm
            // 
            this.nextForm.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextForm.Location = new System.Drawing.Point(614, 334);
            this.nextForm.Name = "nextForm";
            this.nextForm.Size = new System.Drawing.Size(109, 38);
            this.nextForm.TabIndex = 0;
            this.nextForm.Text = "Next";
            this.nextForm.UseVisualStyleBackColor = true;
            this.nextForm.Click += new System.EventHandler(this.nextForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(469, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Subject Name";
            // 
            // txtEnterSubjectName
            // 
            this.txtEnterSubjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtEnterSubjectName.Location = new System.Drawing.Point(471, 184);
            this.txtEnterSubjectName.Name = "txtEnterSubjectName";
            this.txtEnterSubjectName.Size = new System.Drawing.Size(277, 32);
            this.txtEnterSubjectName.TabIndex = 2;
            // 
            // subjectErrorLabel
            // 
            this.subjectErrorLabel.AutoSize = true;
            this.subjectErrorLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subjectErrorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subjectErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.subjectErrorLabel.Location = new System.Drawing.Point(522, 236);
            this.subjectErrorLabel.Name = "subjectErrorLabel";
            this.subjectErrorLabel.Size = new System.Drawing.Size(170, 20);
            this.subjectErrorLabel.TabIndex = 3;
            this.subjectErrorLabel.Text = "Subject Already Exists!";
            // 
            // clearSubjectNameBtn
            // 
            this.clearSubjectNameBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearSubjectNameBtn.Location = new System.Drawing.Point(499, 334);
            this.clearSubjectNameBtn.Name = "clearSubjectNameBtn";
            this.clearSubjectNameBtn.Size = new System.Drawing.Size(109, 38);
            this.clearSubjectNameBtn.TabIndex = 4;
            this.clearSubjectNameBtn.Text = "Clear";
            this.clearSubjectNameBtn.UseVisualStyleBackColor = true;
            // 
            // addSubject
            // 
            this.addSubject.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSubject.Location = new System.Drawing.Point(499, 290);
            this.addSubject.Name = "addSubject";
            this.addSubject.Size = new System.Drawing.Size(224, 38);
            this.addSubject.TabIndex = 5;
            this.addSubject.Text = "Add Subject";
            this.addSubject.UseVisualStyleBackColor = true;
            this.addSubject.Click += new System.EventHandler(this.addSubject_Click);
            // 
            // CreateQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1275, 685);
            this.Controls.Add(this.addSubject);
            this.Controls.Add(this.clearSubjectNameBtn);
            this.Controls.Add(this.subjectErrorLabel);
            this.Controls.Add(this.txtEnterSubjectName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nextForm);
            this.Name = "CreateQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateQuiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEnterSubjectName;
        private System.Windows.Forms.Label subjectErrorLabel;
        private System.Windows.Forms.Button clearSubjectNameBtn;
        private System.Windows.Forms.Button addSubject;
    }
}