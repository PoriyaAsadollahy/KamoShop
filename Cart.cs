using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Cart : Form
    {
        public User Person { get; }
        public Cart(User person)
        {
            InitializeComponent();

            Person = person;
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

        private void Cart_Load(object sender, EventArgs e)
        {
            pnlBill.Visible = false;

            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            dgvImage.HeaderText = "Image";
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewTextBoxColumn dgvName = new DataGridViewTextBoxColumn();
            dgvName.HeaderText = "Name";

            DataGridViewTextBoxColumn dgvQuantity = new DataGridViewTextBoxColumn();
            dgvQuantity.HeaderText = "Quantity";

            DataGridViewTextBoxColumn dgvPrice = new DataGridViewTextBoxColumn();
            dgvPrice.HeaderText = "Price";

            DataGridViewTextBoxColumn dgvID = new DataGridViewTextBoxColumn();
            dgvID.HeaderText = "ID";

            DataGridViewCheckBoxColumn dgvCheckBox = new DataGridViewCheckBoxColumn();
            dgvCheckBox.ValueType = typeof(bool);
            dgvCheckBox.HeaderText = "Delete";
            dgvCheckBox.ReadOnly = false;

            dgvCart.Columns.Add(dgvImage);
            dgvCart.Columns.Add(dgvName);
            dgvCart.Columns.Add(dgvQuantity);
            dgvCart.Columns.Add(dgvPrice);
            dgvCart.Columns.Add(dgvID);
            dgvCart.Columns.Add(dgvCheckBox);

            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.RowTemplate.Height = 40;

            dgvCart.AllowUserToAddRows = false;


            foreach(Product p in Person.ShoppingCart)
            {
                Image temp = Image.FromFile(p.ImageLocation);
                dgvCart.Rows.Add(temp, p.Name, p.Quantity, p.Price, p.ProductID);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = dgvCart.Rows.Count - 1; i >= 0; i--)
            {
                try
                {
                    bool delete = (bool)dgvCart.Rows[i].Cells[5].Value;

                    if (delete)
                    {
                        DataGridViewRow rowToRemove = dgvCart.Rows[i];
                        string id = rowToRemove.Cells[4].Value.ToString() ?? string.Empty;
                        foreach (Product p in Person.ShoppingCart)
                        {
                            if (id == p.ProductID.ToString())
                            {
                                var item = Person.ShoppingCart.SingleOrDefault(x => x.ProductID == p.ProductID);
                                if (item != null)
                                {
                                    Person.ShoppingCart.Remove(item);
                                    break;
                                }
                            }
                        }
                        dgvCart.Rows.Remove(rowToRemove);

                        if(pnlBill.Visible)
                        {
                            pnlBill.Show();
                            decimal total = 0.00M;
                            lblOffResult.Text = "0%";
                            foreach (Product p in Person.ShoppingCart)
                            {
                                total += p.Price * p.Quantity;
                            }
                            lblTotalResult.Text = total.ToString();
                            lblPayoutResult.Text = total.ToString();
                        }
                    }
                }
                catch
                {
                    break;
                }
            }
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            Shopping page = new Shopping(Person);
            this.Close();
            page.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = dgvCart.Rows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow rowToRemove = dgvCart.Rows[i];
                string id = rowToRemove.Cells[4].Value.ToString() ?? string.Empty;
                string quantity = rowToRemove.Cells[2].Value.ToString() ?? string.Empty;
                int ProductQuantity = Int32.Parse(quantity);
                foreach (Product p in productList.items)
                {
                    if (id == p.ProductID.ToString())
                    {
                        p.Quantity = p.Quantity - ProductQuantity;
                        var item = Person.ShoppingCart.SingleOrDefault(x => x.ProductID == p.ProductID);
                        if (item != null)
                        {
                            Person.ShoppingCart.Remove(item);
                            break;
                        }
                    }
                }
                dgvCart.Rows.Remove(rowToRemove);
            }

            DialogResult CheckOut;
            CheckOut = MessageBox.Show("CheckOut was successful", "",MessageBoxButtons.OK);
        }

        private void txtOfcodeResult_TextChanged(object sender, EventArgs e)
        {
            if (txtOfcodeResult.Text == "Off")
            {
                lblOffResult.Text = "10%";
                double payout = double.Parse(lblTotalResult.Text);
                lblPayoutResult.Text = (payout - (payout * 0.1)).ToString() + "$";
            }
            else
            {
                lblOffResult.Text = "0%";
                double payout = double.Parse(lblTotalResult.Text);
                lblPayoutResult.Text = (payout).ToString() + "$";
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            pnlBill.Show();
            decimal total = 0.00M;
            lblOffResult.Text = "0%";
            foreach (Product p in Person.ShoppingCart)
            {
                total += p.Price * p.Quantity;
            }
            lblTotalResult.Text = total.ToString();
            lblPayoutResult.Text = total.ToString();
        }
    }
}
