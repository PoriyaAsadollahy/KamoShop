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
    public partial class inventory : Form
    {
        public inventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProdut page = new AddProdut();
            this.Close();
            page.Show();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn page = new LogIn();
            this.Hide();
            page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Searching page = new Searching();
            this.Close();
            page.Show();
        }

        private void inventory_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            dgvImage.HeaderText = "Image";
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            DataGridViewImageColumn dgvImage2 = new DataGridViewImageColumn();
            dgvImage2.HeaderText = "Image";
            dgvImage2.ImageLayout = DataGridViewImageCellLayout.Zoom;

            DataGridViewTextBoxColumn dgvName = new DataGridViewTextBoxColumn();
            dgvName.HeaderText = "Name";
            dgvName.ReadOnly = true;
            DataGridViewTextBoxColumn dgvName2 = new DataGridViewTextBoxColumn();
            dgvName2.HeaderText = "Name";
            dgvName2.ReadOnly = true;

            DataGridViewTextBoxColumn dgvQuantity = new DataGridViewTextBoxColumn();
            dgvQuantity.HeaderText = "Quantity";
            dgvQuantity.ReadOnly = true;
            DataGridViewTextBoxColumn dgvQuantity2 = new DataGridViewTextBoxColumn();
            dgvQuantity2.HeaderText = "Quantity";
            dgvQuantity2.ReadOnly = true;

            DataGridViewTextBoxColumn dgvPrice = new DataGridViewTextBoxColumn();
            dgvPrice.HeaderText = "Price";
            dgvPrice.ReadOnly = true;
            DataGridViewTextBoxColumn dgvPrice2 = new DataGridViewTextBoxColumn();
            dgvPrice2.HeaderText = "Price";
            dgvPrice2.ReadOnly = true;

            DataGridViewTextBoxColumn dgvID = new DataGridViewTextBoxColumn();
            dgvID.HeaderText = "ID";
            dgvID.ReadOnly = true;
            DataGridViewTextBoxColumn dgvID2 = new DataGridViewTextBoxColumn();
            dgvID2.HeaderText = "ID";
            dgvID2.ReadOnly = true;

            DataGridViewTextBoxColumn dgvCat = new DataGridViewTextBoxColumn();
            dgvCat.HeaderText = "Cat";
            dgvCat.ReadOnly = true;

            DataGridViewTextBoxColumn dgvColor = new DataGridViewTextBoxColumn();
            dgvColor.HeaderText = "Color";
            dgvColor.ReadOnly = true;

            DataGridViewCheckBoxColumn dgvCheckBox = new DataGridViewCheckBoxColumn();
            dgvCheckBox.ValueType = typeof(bool);
            dgvCheckBox.HeaderText = "Delete";

            dgvShowProduct.Columns.Add(dgvImage);
            dgvShowProduct.Columns.Add(dgvName);
            dgvShowProduct.Columns.Add(dgvQuantity);
            dgvShowProduct.Columns.Add(dgvPrice);
            dgvShowProduct.Columns.Add(dgvCat);
            dgvShowProduct.Columns.Add(dgvColor);
            dgvShowProduct.Columns.Add(dgvID);
            dgvShowProduct.Columns.Add(dgvCheckBox);

            dgvSoonFinished.Columns.Add(dgvImage2);
            dgvSoonFinished.Columns.Add(dgvName2);
            dgvSoonFinished.Columns.Add(dgvQuantity2);
            dgvSoonFinished.Columns.Add(dgvPrice2);
            dgvSoonFinished.Columns.Add(dgvID2);

            dgvShowProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvShowProduct.RowTemplate.Height = 35;

            dgvSoonFinished.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSoonFinished.RowTemplate.Height = 35;

            dgvShowProduct.AllowUserToAddRows = false;
            dgvSoonFinished.AllowUserToAddRows = false;

            foreach (Product p in productList.items)
            {
                Image temp = Image.FromFile(p.ImageLocation);
                dgvShowProduct.Rows.Add(temp, p.Name, p.Quantity, p.Price, p.Category, p.Color, p.ProductID, false);
                if(p.Quantity < 5)
                {
                    dgvSoonFinished.Rows.Add(temp, p.Name, p.Quantity, p.Price, p.ProductID);
                }
            }
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowToRemove = dgvShowProduct.CurrentRow;
            string id = rowToRemove.Cells[6].Value.ToString() ?? string.Empty;
            foreach (Product p in productList.items)
            {
                if (id == p.ProductID.ToString())
                {
                    var item = productList.items.SingleOrDefault(x => x.ProductID == p.ProductID);
                    if (item != null)
                    {
                        productList.items.Remove(item);
                        break;
                    }
                }
            }
            dgvShowProduct.Rows.Remove(rowToRemove);
        }

        private void dgvShowProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ID = dgvShowProduct.CurrentRow.Cells[6].Value.ToString() ?? string.Empty;

            foreach(Product p in productList.items)
            {
                if(ID == p.ProductID.ToString())
                {
                    UpdateProduct page = new UpdateProduct(p);
                    this.Close();
                    page.Show();
                    break;
                }
            }
        }
    }
}
