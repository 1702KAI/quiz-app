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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectUserType.SelectedIndex == 0)
            {
                studentPanel.Visible = true;
                tutorPanel.Visible = false;
                managePanel.Visible = false;
            }
            else if (selectUserType.SelectedIndex == 1)
            {
                tutorPanel.Visible = true;
                studentPanel.Visible = false;
                managePanel.Visible = false;

            }else if (selectUserType.SelectedIndex == 2)
            {
                managePanel.Visible = true;
                studentPanel.Visible = false;
                tutorPanel.Visible=false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentPanel.Visible = false;
            tutorPanel.Visible = false;
            managePanel.Visible = false;
            WrongLabel.Visible = false;
            wrongLabel2.Visible = false;

        }

        private void showHidePassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showHidePassword.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                showHidePassword.Text = "Hide password";

            }
            else
            {
                txtPassword.PasswordChar = '*';
                showHidePassword.Text = "Show password";
            }
        }

        private void tutorLoginBtn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "imeth" && txtPassword.Text == "imeth")
            {
                WrongLabel.Visible = false;
                Tutor tutor = new Tutor();
                tutor.Show();
                this.Hide();
            }
            else
            {
                WrongLabel.Visible = true;
            }
        }

        private void studentRegistrationBtn_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Show();
            this.Hide();
        }

        private void studentLoginBtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername2.Text == "imeth" && txtPassword2.Text == "imeth")
            {
                wrongLabel2.Visible = false;
                Tutor tutor = new Tutor();
                tutor.Show();
                this.Hide();
            }
            else
            {
                wrongLabel2.Visible = true;
            }
        }

        private void showHidePassword2_CheckedChanged(object sender, EventArgs e)
        {
            if (showHidePassword2.Checked == true)
            {
                txtPassword2.PasswordChar = '\0';
                showHidePassword2.Text = "Hide password";

            }
            else
            {
                txtPassword2.PasswordChar = '*';
                showHidePassword2.Text = "Show password";
            }
        }
    }
}
