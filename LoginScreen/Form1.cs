using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        // global variables - can be used in both 
        // button click events
        string username;
        string password;

        public Form1()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            username = usernameInput.Text;
            password = passwordInput.Text;

            // welcome the user with their name
            outputLabel.Text = $"Welcome {username}";
        }

        private void adminButton_Click(object sender, EventArgs e)
        {

            // welcome the user with their name
            outputLabel.Text = $"Welcome ADMIN user {username}";
        }
    }
}
