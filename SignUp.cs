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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void butClose2_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Do you want to exit?", "Exit Page", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            butSignUp.Enabled = false;
        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                butSignUp.Enabled = true;
            }
            else
            {
                butSignUp.Enabled = false;
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            LogIn page = new LogIn();
            this.Hide();
            page.Show();
        }

        private void butSignUp_Click(object sender, EventArgs e)
        {
            bool makeNewUser = true;

            foreach (User person in UserList.users)
            {
                if (txtUserName.Text == person.Name)
                {
                    makeNewUser = false;
                    break;
                }
            }

            if (makeNewUser)
            {
                User temp = new User(txtUserName.Text, txtPassword.Text);
                UserList.users.Add(temp);

                LogIn page = new LogIn(txtUserName.Text);
                this.Hide();
                page.Show();
            }
            else
            {
                lblSignInError.ForeColor = Color.Red;
                lblSignInError.Text = "username is already in use";
            }
        }
    }
}
