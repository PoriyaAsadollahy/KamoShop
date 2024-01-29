namespace Final_Project
{
    partial class UpdateProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateProduct));
            this.pnlmenuAd = new System.Windows.Forms.Panel();
            this.butBack = new System.Windows.Forms.Button();
            this.butClose4 = new System.Windows.Forms.Button();
            this.lblQuantityError = new System.Windows.Forms.Label();
            this.lblPriceError = new System.Windows.Forms.Label();
            this.lblColorError = new System.Windows.Forms.Label();
            this.lblCategoryError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.txtProductDetails = new System.Windows.Forms.RichTextBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.butTakePic = new System.Windows.Forms.Button();
            this.butImportImg = new System.Windows.Forms.Button();
            this.picProduct = new System.Windows.Forms.PictureBox();
            this.butAddProduct = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProductColor = new System.Windows.Forms.Label();
            this.lblProductCategory = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pnlmenuAd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmenuAd
            // 
            this.pnlmenuAd.BackColor = System.Drawing.Color.Black;
            this.pnlmenuAd.Controls.Add(this.butBack);
            this.pnlmenuAd.Controls.Add(this.butClose4);
            this.pnlmenuAd.Location = new System.Drawing.Point(2, 1);
            this.pnlmenuAd.Name = "pnlmenuAd";
            this.pnlmenuAd.Size = new System.Drawing.Size(900, 44);
            this.pnlmenuAd.TabIndex = 8;
            // 
            // butBack
            // 
            this.butBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butBack.BackgroundImage")));
            this.butBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butBack.Location = new System.Drawing.Point(3, 3);
            this.butBack.Name = "butBack";
            this.butBack.Size = new System.Drawing.Size(40, 38);
            this.butBack.TabIndex = 1;
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butClose4
            // 
            this.butClose4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butClose4.BackgroundImage")));
            this.butClose4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butClose4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose4.Location = new System.Drawing.Point(857, 3);
            this.butClose4.Name = "butClose4";
            this.butClose4.Size = new System.Drawing.Size(40, 38);
            this.butClose4.TabIndex = 0;
            this.butClose4.UseVisualStyleBackColor = true;
            this.butClose4.Click += new System.EventHandler(this.butClose4_Click);
            // 
            // lblQuantityError
            // 
            this.lblQuantityError.AutoSize = true;
            this.lblQuantityError.Location = new System.Drawing.Point(587, 488);
            this.lblQuantityError.Name = "lblQuantityError";
            this.lblQuantityError.Size = new System.Drawing.Size(0, 13);
            this.lblQuantityError.TabIndex = 55;
            // 
            // lblPriceError
            // 
            this.lblPriceError.AutoSize = true;
            this.lblPriceError.Location = new System.Drawing.Point(587, 415);
            this.lblPriceError.Name = "lblPriceError";
            this.lblPriceError.Size = new System.Drawing.Size(0, 13);
            this.lblPriceError.TabIndex = 54;
            // 
            // lblColorError
            // 
            this.lblColorError.AutoSize = true;
            this.lblColorError.Location = new System.Drawing.Point(587, 342);
            this.lblColorError.Name = "lblColorError";
            this.lblColorError.Size = new System.Drawing.Size(0, 13);
            this.lblColorError.TabIndex = 53;
            // 
            // lblCategoryError
            // 
            this.lblCategoryError.AutoSize = true;
            this.lblCategoryError.Location = new System.Drawing.Point(587, 269);
            this.lblCategoryError.Name = "lblCategoryError";
            this.lblCategoryError.Size = new System.Drawing.Size(0, 13);
            this.lblCategoryError.TabIndex = 52;
            // 
            // lblNameError
            // 
            this.lblNameError.AutoSize = true;
            this.lblNameError.Location = new System.Drawing.Point(587, 123);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(0, 13);
            this.lblNameError.TabIndex = 50;
            // 
            // txtProductDetails
            // 
            this.txtProductDetails.Location = new System.Drawing.Point(111, 462);
            this.txtProductDetails.Name = "txtProductDetails";
            this.txtProductDetails.Size = new System.Drawing.Size(310, 66);
            this.txtProductDetails.TabIndex = 49;
            this.txtProductDetails.Text = "";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(108, 444);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(82, 13);
            this.lblDetails.TabIndex = 48;
            this.lblDetails.Text = "Product Details:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(584, 462);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(215, 20);
            this.txtQuantity.TabIndex = 47;
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.ForeColor = System.Drawing.Color.White;
            this.lblProductQuantity.Location = new System.Drawing.Point(584, 443);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(89, 13);
            this.lblProductQuantity.TabIndex = 46;
            this.lblProductQuantity.Text = "Product Quantity:";
            // 
            // butTakePic
            // 
            this.butTakePic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.butTakePic.Location = new System.Drawing.Point(280, 361);
            this.butTakePic.Name = "butTakePic";
            this.butTakePic.Size = new System.Drawing.Size(149, 35);
            this.butTakePic.TabIndex = 45;
            this.butTakePic.Text = "Take Picture";
            this.butTakePic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butTakePic.UseVisualStyleBackColor = false;
            // 
            // butImportImg
            // 
            this.butImportImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.butImportImg.Location = new System.Drawing.Point(101, 361);
            this.butImportImg.Name = "butImportImg";
            this.butImportImg.Size = new System.Drawing.Size(149, 35);
            this.butImportImg.TabIndex = 44;
            this.butImportImg.Text = "Import Picture";
            this.butImportImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.butImportImg.UseVisualStyleBackColor = false;
            this.butImportImg.Click += new System.EventHandler(this.butImportImg_Click);
            // 
            // picProduct
            // 
            this.picProduct.Location = new System.Drawing.Point(101, 98);
            this.picProduct.Name = "picProduct";
            this.picProduct.Size = new System.Drawing.Size(328, 254);
            this.picProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProduct.TabIndex = 43;
            this.picProduct.TabStop = false;
            // 
            // butAddProduct
            // 
            this.butAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.butAddProduct.Location = new System.Drawing.Point(603, 518);
            this.butAddProduct.Name = "butAddProduct";
            this.butAddProduct.Size = new System.Drawing.Size(158, 54);
            this.butAddProduct.TabIndex = 42;
            this.butAddProduct.Text = "Edit Product";
            this.butAddProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.butAddProduct.UseVisualStyleBackColor = false;
            this.butAddProduct.Click += new System.EventHandler(this.butAddProduct_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(584, 389);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(215, 20);
            this.txtPrice.TabIndex = 41;
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.ForeColor = System.Drawing.Color.White;
            this.lblProductPrice.Location = new System.Drawing.Point(584, 371);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(74, 13);
            this.lblProductPrice.TabIndex = 40;
            this.lblProductPrice.Text = "Product Price:";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(584, 316);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(215, 20);
            this.txtColor.TabIndex = 39;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(584, 243);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(215, 20);
            this.txtCategory.TabIndex = 38;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(584, 170);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(215, 20);
            this.txtProductID.TabIndex = 37;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(584, 97);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(215, 20);
            this.txtProductName.TabIndex = 36;
            // 
            // lblProductColor
            // 
            this.lblProductColor.AutoSize = true;
            this.lblProductColor.ForeColor = System.Drawing.Color.White;
            this.lblProductColor.Location = new System.Drawing.Point(584, 298);
            this.lblProductColor.Name = "lblProductColor";
            this.lblProductColor.Size = new System.Drawing.Size(74, 13);
            this.lblProductColor.TabIndex = 35;
            this.lblProductColor.Text = "Product Color:";
            // 
            // lblProductCategory
            // 
            this.lblProductCategory.AutoSize = true;
            this.lblProductCategory.ForeColor = System.Drawing.Color.White;
            this.lblProductCategory.Location = new System.Drawing.Point(584, 225);
            this.lblProductCategory.Name = "lblProductCategory";
            this.lblProductCategory.Size = new System.Drawing.Size(92, 13);
            this.lblProductCategory.TabIndex = 34;
            this.lblProductCategory.Text = "Product Category:";
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.ForeColor = System.Drawing.Color.White;
            this.lblProductID.Location = new System.Drawing.Point(584, 152);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 13);
            this.lblProductID.TabIndex = 33;
            this.lblProductID.Text = "Product ID:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(584, 79);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 32;
            this.lblProductName.Text = "Product Name:";
            // 
            // UpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.lblQuantityError);
            this.Controls.Add(this.lblPriceError);
            this.Controls.Add(this.lblColorError);
            this.Controls.Add(this.lblCategoryError);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.txtProductDetails);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblProductQuantity);
            this.Controls.Add(this.butTakePic);
            this.Controls.Add(this.butImportImg);
            this.Controls.Add(this.picProduct);
            this.Controls.Add(this.butAddProduct);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductColor);
            this.Controls.Add(this.lblProductCategory);
            this.Controls.Add(this.lblProductID);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pnlmenuAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateProduct";
            this.Text = "Form1";
            this.pnlmenuAd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlmenuAd;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butClose4;
        private System.Windows.Forms.Label lblQuantityError;
        private System.Windows.Forms.Label lblPriceError;
        private System.Windows.Forms.Label lblColorError;
        private System.Windows.Forms.Label lblCategoryError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.RichTextBox txtProductDetails;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Button butTakePic;
        private System.Windows.Forms.Button butImportImg;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button butAddProduct;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProductColor;
        private System.Windows.Forms.Label lblProductCategory;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
    }
}