using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class LogIn : Form
    {
        private User temp;

        public LogIn()
        {
            InitializeComponent();
        }

        public LogIn(string username)
        {
            InitializeComponent();
            txtUserName.Text = username;
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Do you want to exit?", "Exit Page", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void butLogin_EnabledChanged(object sender, EventArgs e)
        {
          
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            butLogin.Enabled = false;
        }

        private void llblSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp page = new SignUp();
            this.Hide();
            page.Show();
        }

        private void txtUserName_TextChanged_1(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                butLogin.Enabled = true;
            }
            else
            {
                butLogin.Enabled = false;
            }
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            if(txtUserName.Text == "Admin" && txtPassword.Text == "Admin")
            {
                inventory page = new inventory();
                this.Hide();
                page.Show();
            }

            foreach(User Person in UserList.users)
            {
                if(Person == UserList.users[0])
                {
                    continue;
                }
                if(Person.Name == txtUserName.Text && Person.Password == txtPassword.Text)
                {
                    Person.ShoppingCart.Clear();
                    Shopping page = new Shopping(Person);
                    this.Hide();
                    page.Show();
                }
            }

            lblLogInError.ForeColor = Color.Red;
            lblLogInError.Text = "Username or password is incorrect";
        }
    }
}
