using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class TutorSelectSubject : Form
    {
        public TutorSelectSubject()
        {
            InitializeComponent();
        }

        private void ViewQuiz_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UJCPQHJ\\SQLEXPRESS;database=subjectQuiz;Integrated Security=True");
            con.Open();

            DataTable dt = con.GetSchema("Tables");
            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                subjectViewComboBox.Items.Add(tablename);
            }

            con.Close();
        }

        public string subjectName;
        private void subjectViewComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (subjectViewComboBox.SelectedItem != null)
            {
                subjectName = subjectViewComboBox.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Error: " + subjectViewComboBox.SelectedItem.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void viewQuizBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (subjectName != null)
                {
                QuizView quizView = new QuizView(subjectName);
                quizView.Show();
                this.Hide();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
