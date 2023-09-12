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
    public partial class QuizView : Form
    {
        private int currentIndex = 0;
        private List<QuizData> quizDataList;
        private string connectionString = "Data Source=DESKTOP-UJCPQHJ\\SQLEXPRESS;database=subjectQuiz;Integrated Security=True";

        private string _data;
        public QuizView(string data)
        {
            InitializeComponent();
            _data = data;
        }

        private void updateQuestionBtn_Click(object sender, EventArgs e)
        {
            if (txtHint.Text != "") { 
            SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string updateSql = $"UPDATE {_data} SET question = @question, optionA = @optionA, optionB = @optionB, optionC = @optionC, optionD = @optionD, answer = @answer, hint = @hint WHERE id = @id";
                SqlCommand command = new SqlCommand(updateSql, connection);

                command.Parameters.AddWithValue("@id", txtQuestionNumber.Text);
                command.Parameters.AddWithValue("@question", txtQuestion.Text);
                command.Parameters.AddWithValue("@optionA", txtOptionA.Text);
                command.Parameters.AddWithValue("@optionB", txtOptionB.Text);
                command.Parameters.AddWithValue("@optionC", txtOptionC.Text);
                command.Parameters.AddWithValue("@optionD", txtOptionD.Text);
                command.Parameters.AddWithValue("@answer", txtAnswer.Text);
                command.Parameters.AddWithValue("@hint", txtHint.Text);

                command.ExecuteNonQuery();
                connection.Close();

                RetrieveDataFromDB();
            }
            else
            {
                MessageBox.Show("Please provide a model answer to each question", "Certification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void QuizView_Load(object sender, EventArgs e)
        {
                subjectLabel.Text = _data.ToLower();
                RetrieveDataFromDB();
                DisplayData(1);
        }

        private void nextQuestionBtn_Click(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex == quizDataList.Count)
            {
                currentIndex = 0;
            }
            DisplayData(currentIndex);
        }

        private void previousQuestionBtn_Click(object sender, EventArgs e)
        {
            currentIndex--;
            if (currentIndex < 0)
            {
                currentIndex = quizDataList.Count - 1;
            }
            DisplayData(currentIndex);
        }
        private void RetrieveDataFromDB()
        {
            // Code to retrieve data from the database and store it in a list of objects
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string sqlString = $"SELECT id, question, optionA, optionB, optionC, optionD, hint, answer FROM {_data}";
                SqlCommand command = new SqlCommand(sqlString, connection);
                SqlDataReader reader = command.ExecuteReader();
                quizDataList = new List<QuizData>();
                while (reader.Read())
                {
                QuizData quizData = new QuizData();
                quizData.Id = reader.GetInt32(0);
                quizData.Question = reader.GetString(1);
                quizData.OptionA = reader.GetString(2);
                quizData.OptionB = reader.GetString(3);
                quizData.OptionC = reader.GetString(4);
                quizData.OptionD = reader.GetString(5);
                quizData.Hint = reader.GetString(6);
                quizData.Answer = reader.GetString(7);
                quizDataList.Add(quizData);
            }

        }

        private void DisplayData(int index)
        {

            txtQuestionNumber.Text = quizDataList[index].Id.ToString();
            txtQuestion.Text = quizDataList[index].Question;
            txtOptionA.Text = quizDataList[index].OptionA;
            txtOptionB.Text = quizDataList[index].OptionB;
            txtOptionC.Text = quizDataList[index].OptionC;
            txtOptionD.Text = quizDataList[index].OptionD;
            txtHint.Text = quizDataList[index].Hint;
            txtAnswer.Text = quizDataList[index].Answer;

        }

        private void finishQuizBtn_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.Show();
            this.Hide();
        }
    }
}
