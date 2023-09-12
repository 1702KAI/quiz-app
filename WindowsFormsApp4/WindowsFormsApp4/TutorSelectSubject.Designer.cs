namespace WindowsFormsApp4
{
    partial class TutorSelectSubject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorSelectSubject));
            this.viewQuizBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectViewComboBox = new System.Windows.Forms.ComboBox();
            this.deleteQuizBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewQuizBtn
            // 
            this.viewQuizBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuizBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.viewQuizBtn.Location = new System.Drawing.Point(525, 279);
            this.viewQuizBtn.Name = "viewQuizBtn";
            this.viewQuizBtn.Size = new System.Drawing.Size(224, 38);
            this.viewQuizBtn.TabIndex = 11;
            this.viewQuizBtn.Text = "Certify Quiz";
            this.viewQuizBtn.UseVisualStyleBackColor = true;
            this.viewQuizBtn.Click += new System.EventHandler(this.viewQuizBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Subject";
            // 
            // subjectViewComboBox
            // 
            this.subjectViewComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subjectViewComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.subjectViewComboBox.FormattingEnabled = true;
            this.subjectViewComboBox.Location = new System.Drawing.Point(505, 227);
            this.subjectViewComboBox.Name = "subjectViewComboBox";
            this.subjectViewComboBox.Size = new System.Drawing.Size(257, 28);
            this.subjectViewComboBox.TabIndex = 12;
            this.subjectViewComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectViewComboBox_SelectedIndexChanged);
            // 
            // deleteQuizBtn
            // 
            this.deleteQuizBtn.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteQuizBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deleteQuizBtn.Location = new System.Drawing.Point(525, 333);
            this.deleteQuizBtn.Name = "deleteQuizBtn";
            this.deleteQuizBtn.Size = new System.Drawing.Size(224, 38);
            this.deleteQuizBtn.TabIndex = 13;
            this.deleteQuizBtn.Text = "Delete Quiz";
            this.deleteQuizBtn.UseVisualStyleBackColor = true;
            // 
            // TutorSelectSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1275, 685);
            this.Controls.Add(this.deleteQuizBtn);
            this.Controls.Add(this.subjectViewComboBox);
            this.Controls.Add(this.viewQuizBtn);
            this.Controls.Add(this.label1);
            this.Name = "TutorSelectSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewQuiz";
            this.Load += new System.EventHandler(this.ViewQuiz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewQuizBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox subjectViewComboBox;
        private System.Windows.Forms.Button deleteQuizBtn;
    }
}