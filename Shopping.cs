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
    public partial class Shopping : Form
    {
        private User Person { get; set; }
        public Shopping(User person)
        {
            InitializeComponent();
            Person = person;

            int count = 0;
            foreach(MyPictureBox pb in this.pnlMain.Controls.OfType<MyPictureBox>())
            {

                if (count >= productList.items.Count)
                {
                    pb.Hide();
                }
                else
                {
                    pb.ImageProduct = productList.items[count];
                    pb.ImageLocation = productList.items[count++].ImageLocation;
                }
            }
        }

        private void pnlCategory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void butClose3_Click_1(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Do you want to exit?", "Exit Page", MessageBoxButtons.YesNo);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void butCart_Click(object sender, EventArgs e)
        {
            Cart page = new Cart(Person);
            this.Close();
            page.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn page = new LogIn();
            this.Close();
            page.Show();
        }

        private void picSale1_Click(object sender, EventArgs e)
        {
            BuyProductcs page = new BuyProductcs(Person, picSale1.ImageProduct);
            this.Close();
            page.Show();
        }

        private void picSale2_Click(object sender, EventArgs e)
        {
            BuyProductcs page = new BuyProductcs(Person, picSale2.ImageProduct);
            this.Close();
            page.Show();
        }

        private void pic1_Click(object sender, EventArgs e)
        {
            BuyProductcs page = new BuyProductcs(Person, pic1.ImageProduct);
            this.Close();
            page.Show();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            BuyProductcs page = new BuyProductcs(Person, pic2.ImageProduct);
            this.Close();
            page.Show();
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            BuyProductcs page = new BuyProductcs(Person, pic3.ImageProduct);
            this.Close();
            page.Show();
        }

        private void pic4_Click(object sender, EventArgs e)
        {
            BuyProductcs page = new BuyProductcs(Person, pic4.ImageProduct);
            this.Close();
            page.Show();
        }

        private void pic5_Click(object sender, EventArgs e)
        {
            BuyProductcs page = new BuyProductcs(Person, pic5.ImageProduct);
            this.Close();
            page.Show();
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            BuyProductcs page = new BuyProductcs(Person, pic6.ImageProduct);
            this.Close();
            page.Show();
        }

        private void pic7_Click(object sender, EventArgs e)
        {
            BuyProductcs page = new BuyProductcs(Person, pic7.ImageProduct);
            this.Close();
            page.Show();
        }

        private void pic8_Click(object sender, EventArgs e)
        {
            BuyProductcs page = new BuyProductcs(Person, pic8.ImageProduct);
            this.Close();
            page.Show();
        }

        private void pic9_Click(object sender, EventArgs e)
        {
            BuyProductcs page = new BuyProductcs(Person, pic9.ImageProduct);
            this.Close();
            page.Show();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            Searching page = new Searching(Person);
            this.Close();
            page.Show();
        }
    }
    public class MyPictureBox : PictureBox
    {
        public Product ImageProduct { get; set; }
    }
}
