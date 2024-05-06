using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signup_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Signupbtn_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                User newuser = new User
                {
                    FirstName = Fname_Box.Text,
                    LastName = Lname_Box.Text,
                    DateofBirth = DOB_Box.Text,
                    Email = Email_Box.Text,
                    username = UserN_Box.Text,
                    password = Pass_Box.Text,
                };

                Form2 welcome = new Form2(newuser);
                welcome.Show();
                this.Hide();
            }

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            Fname_Box.Text = "";
            Lname_Box.Text = "";
            DOB_Box.Text = "";
            Email_Box.Text = "";
            UserN_Box.Text = "";
            Pass_Box.Text = "";


        }

        public bool validation()
        {
            if(string.IsNullOrEmpty(Fname_Box.Text))
            {
                MessageBox.Show("Enter Your First Name");
                return false; 
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
