using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Signup_App
{
    public partial class Form2 : Form
    {
        private User user;

        public Form2(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            WelcomeLabel.Text = "Welcome:" + user.FirstName + " " + user.LastName;
            UserLable.Text = "User Name:" + user.username;
            EmailLable.Text = "Email:" + user.Email;
            DobLable.Text = "Date of Birth:" + user.DateofBirth;

        }
    }
}
