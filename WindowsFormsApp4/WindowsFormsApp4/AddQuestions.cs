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
    public partial class AddQuestions : Form
    {
        private string _data;
        private int _counter = 1;

        public AddQuestions(string data)
        {
            InitializeComponent();
            _data = data;
            
            questionNumberLabel.Text = "1";

        }

        private void addQuestionBtn_Click(object sender, EventArgs e)
        {

            string question = txtQuestion.Text;
            string optionA = txtOptionA.Text;
            string optionB = txtOptionB.Text;
            string optionC = txtOptionC.Text;
            string optionD = txtOptionD.Text;
            string hint = txtHInt.Text;
            string answer = txtAnswer.Text;


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UJCPQHJ\\SQLEXPRESS;database=subjectQuiz;Integrated Security=True");
            con.Open();

            string sqlStr = $"INSERT INTO {_data.ToLower()} (Question, OptionA, OptionB, OptionC, OptionD, Hint, Answer) " +
                                            "VALUES (@question, @optionA, @optionB, @optionC, @optionD, @hint, @answer)";
            SqlCommand cmd = new SqlCommand(sqlStr, con);
            cmd.Parameters.AddWithValue("@question", question);
            cmd.Parameters.AddWithValue("@optionA", optionA);
            cmd.Parameters.AddWithValue("@optionB", optionB);
            cmd.Parameters.AddWithValue("@optionC", optionC);
            cmd.Parameters.AddWithValue("@optionD", optionD);
            cmd.Parameters.AddWithValue("@hint", hint);
            cmd.Parameters.AddWithValue("@answer", answer);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Question added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void AddQuestions_Load(object sender, EventArgs e)
        {
            subjectName.Text = _data;
        }

        private void nextQuestionBtn_Click(object sender, EventArgs e)
        {
            _counter++;
            questionNumberLabel.Text = _counter.ToString();

            txtQuestion.Clear();
            txtOptionA.Clear();
            txtOptionB.Clear();
            txtOptionC.Clear();
            txtOptionD.Clear();
            txtHInt.Clear();
            txtAnswer.Clear();



        }

        private void finishQuizBtn_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.Show();
            this.Hide();

        }
    }
}
