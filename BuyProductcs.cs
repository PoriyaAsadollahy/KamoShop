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
    public partial class BuyProductcs : Form
    {
        private User Person { get; set; }
        private Product Product { get; }
        public BuyProductcs(User person, Product p)
        {
            InitializeComponent();
            Person = person;
            Product = p;
            picProduct.ImageLocation = p.ImageLocation;
            lblNameResult.Text = p.Name;
            lblColorResult.Text = p.Color;
            lblCategoryResult.Text = p.Category;
            lblQuantityResult.Text = p.Quantity.ToString();
            lblDetailsResult.Text = p.Description;
            lblPriceResult.Text = p.Price.ToString();
        }

        private void butAddToCart_Click(object sender, EventArgs e)
        {
            Product temp = new Product(Product);
            int ProductQuantity = Int32.Parse(txtChoseQuantity.Text);
            temp.Quantity = ProductQuantity;

            bool NewProduct = true;
            foreach (Product p in Person.ShoppingCart)
            {
                if (p.ProductID == temp.ProductID)
                {
                    int quantity = temp.Quantity;
                    temp.Quantity += p.Quantity;
                    if(temp.Quantity <= Product.Quantity)
                    {
                        p.Quantity += quantity;
                        NewProduct = false;
                        Shopping page = new Shopping(Person);
                        this.Close();
                        page.Show();
                        break;
                    }
                    else
                    {
                        lblAddError.ForeColor = Color.Red;
                        lblAddError.Text = "Not enough product in inventory";
                    }
                }
            }
            if (NewProduct)
            {
                if (Product.Quantity >= temp.Quantity)
                {
                    Person.ShoppingCart.Add(temp);
                    Shopping page = new Shopping(Person);
                    this.Close();
                    page.Show();
                }
                else
                {
                    lblAddError.ForeColor = Color.Red;
                    lblAddError.Text = "Not enough product in inventory";
                }
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            Shopping page = new Shopping(Person);
            this.Close();
            page.Show();
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
    }
}
