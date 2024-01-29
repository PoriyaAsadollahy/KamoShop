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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct(Product p)
        {
            InitializeComponent();
            txtProductID.Text = p.ProductID.ToString();
            txtProductID.ReadOnly = true;

            picProduct.ImageLocation = p.ImageLocation;
            txtProductName.Text = p.Name;
            txtProductID.Enabled = false;
            txtCategory.Text = p.Category;
            txtColor.Text = p.Color;
            txtPrice.Text = p.Price.ToString();
            txtQuantity.Text = p.Quantity.ToString();
            txtProductDetails.Text = "";
        }

        private void butImportImg_Click(object sender, EventArgs e)
        {
            string ImageLocation;
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImageLocation = file.FileName;

                    picProduct.ImageLocation = ImageLocation;
                }
            }
            catch
            {
                MessageBox.Show("Only jpg and png are supported", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butAddProduct_Click(object sender, EventArgs e)
        {
            int ProductID = 0;
            decimal ProductPrice = 0.00m;
            int ProductQuantity = 0;
            bool makeObject = true;

            lblNameError.Text = "";
            lblCategoryError.Text = "";
            lblColorError.Text = "";
            lblPriceError.Text = "";
            lblQuantityError.Text = "";

            // Product Name
            if (txtProductName.Text == "")
            {
                lblNameError.ForeColor = Color.Red;
                lblNameError.Text = "Field is empty";
                makeObject = false;
            }

            // Product ID
            ProductID = Int32.Parse(txtProductID.Text);

            // Product Category
            if (txtCategory.Text == "")
            {
                lblCategoryError.ForeColor = Color.Red;
                lblCategoryError.Text = "Field is empty";
                makeObject = false;
            }

            // Product Color
            if (txtColor.Text == "")
            {
                lblColorError.ForeColor = Color.Red;
                lblColorError.Text = "Field is empty";
                makeObject = false;
            }

            // Product Price
            if (txtPrice.Text == "")
            {
                lblPriceError.ForeColor = Color.Red;
                lblPriceError.Text = "Field is empty";
                makeObject = false;
            }
            else
            {
                try
                {
                    ProductPrice = Convert.ToDecimal(txtPrice.Text);
                }
                catch
                {
                    lblPriceError.ForeColor = Color.Red;
                    lblPriceError.Text = "Invalid input";
                    makeObject = false;
                }
            }

            // Product Quantity
            if (txtQuantity.Text == "")
            {
                lblQuantityError.ForeColor = Color.Red;
                lblQuantityError.Text = "Field is empty";
                makeObject = false;
            }
            else
            {
                try
                {
                    ProductQuantity = Int32.Parse(txtQuantity.Text);
                }
                catch
                {
                    lblQuantityError.ForeColor = Color.Red;
                    lblQuantityError.Text = "Invalid input";
                    makeObject = false;
                }
            }

            if (makeObject)
            {
                Product temp = new Product(txtCategory.Text, ProductID, txtProductName.Text, txtProductDetails.Text, ProductPrice, ProductQuantity, txtColor.Text, picProduct.ImageLocation);
                int i = 0;
                foreach(Product p in productList.items)
                {
                    if(temp.ProductID == p.ProductID)
                    {
                        break;
                    }
                    i++;
                }
                productList.items[i] = temp;

                inventory page = new inventory();
                this.Close();
                page.Show();
            }
        }

        private void butClose4_Click(object sender, EventArgs e)
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
            inventory page = new inventory();
            this.Close();
            page.Show();
        }
    }
}
