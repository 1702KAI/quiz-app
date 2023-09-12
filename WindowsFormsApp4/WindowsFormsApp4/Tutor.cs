using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Tutor : Form
    {
        public Tutor()
        {
            InitializeComponent();
        }

        private void createQuiz_Click(object sender, EventArgs e)
        {
            CreateQuiz createQuiz = new CreateQuiz();
            createQuiz.Show();
            this.Hide();

        }

        private void viewQuizBtn_Click(object sender, EventArgs e)
        {
            TutorSelectSubject tutorSelectSubject = new TutorSelectSubject();
            tutorSelectSubject.Show();
            this.Hide();
        }

        private void tutorLogOutButton_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
