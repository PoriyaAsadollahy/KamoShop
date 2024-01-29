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
    public partial class Searching : Form
    {
        private User Person { get; set; }
        private Product Product { get; }
        public Searching(User person)
        {
            InitializeComponent();
            Person = person;
            lblNotFound.Hide();
            lblSearchName.Hide();
            lblSearchID.Hide();
        }

        public Searching()
        {
            InitializeComponent();
            Person = null;
            lblNotFound.Hide();
            lblSearchName.Hide();
            lblSearchID.Hide();
        }

        private void butClose9_Click(object sender, EventArgs e)
        {

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

        private void butBack_Click(object sender, EventArgs e)
        {
            if(Person == null)
            {
                inventory page = new inventory();
                this.Close();
                page.Show();
            }
            else
            {
                Shopping page = new Shopping(Person);
                this.Close();
                page.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;
            string id = txtSearch.Text;
            foreach(Product p in productList.items)
            {
                if(id == p.ProductID.ToString())
                {
                    picSearch.Show();
                    lblSearchName.Show();
                    lblSearchID.Show();
                    picSearch.ImageLocation = p.ImageLocation;
                    picSearch.ImageProduct = p;
                    lblSearchNameResult.Text = p.Name;
                    lblSearchNameResult.Show();
                    lblSearchIDReasult.Text = p.ProductID.ToString();
                    lblSearchIDReasult.Show();
                    lblNotFound.Hide();
                    found = true;
                }
            }
            if(!found)
            {
                lblNotFound.Show();
                picSearch.Hide();
                lblSearchID.Hide();
                lblSearchNameResult.Hide();
                lblSearchName.Hide();
                lblSearchIDReasult.Hide();
            }
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            if (Person == null)
            {

            }
            else
            {
                BuyProductcs page = new BuyProductcs(Person, picSearch.ImageProduct);
                this.Close();
                page.Show();
            }
        }
    }
}
