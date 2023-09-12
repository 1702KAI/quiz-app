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
    public partial class CreateQuiz : Form
    {
        
        public CreateQuiz()
        {
            InitializeComponent();
            subjectErrorLabel.Visible = false;
        }

        private void nextForm_Click(object sender, EventArgs e)
        {
            AddQuestions addQuestions = new AddQuestions(txtEnterSubjectName.Text);
            addQuestions.Show();
            this.Hide();
        }

        private void addSubject_Click(object sender, EventArgs e)
        {
            string tableName = txtEnterSubjectName.Text.ToLower();
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UJCPQHJ\\SQLEXPRESS;database=subjectQuiz;Integrated Security=True");
            con.Open();
            string checkTableExists = "IF EXISTS (SELECT * FROM sys.tables WHERE name = '" + tableName + "') SELECT 1 ELSE SELECT 0";
            SqlCommand cmd = new SqlCommand(checkTableExists, con);
                    int result = (int)cmd.ExecuteScalar();
                    if (result == 1)
                    {
                        subjectErrorLabel.Text = "Subject already exists!";
                        subjectErrorLabel.Visible = true;
                    }
                    else
                    {
                        subjectErrorLabel.Text = $"Subject {tableName} was created!";
                        subjectErrorLabel.Visible = true;
                        string createTable = "CREATE TABLE " + tableName + "(ID int IDENTITY(1,1) PRIMARY KEY, Question nvarchar(500), OptionA nvarchar(500), OptionB nvarchar(500), OptionC nvarchar(500), OptionD nvarchar(500), Hint nvarchar(500), Answer nvarchar(500))";
                        using (SqlCommand cmd2 = new SqlCommand(createTable, con))
                        {
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("Table created!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
            con.Close();
            
        }
    }
}
