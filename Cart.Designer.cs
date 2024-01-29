namespace Final_Project
{
    partial class Cart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart));
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.butBack = new System.Windows.Forms.Button();
            this.butClose2 = new System.Windows.Forms.Button();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPayout = new System.Windows.Forms.Label();
            this.lblOff = new System.Windows.Forms.Label();
            this.lblOffCode = new System.Windows.Forms.Label();
            this.txtOfcodeResult = new System.Windows.Forms.TextBox();
            this.lblTotalResult = new System.Windows.Forms.Label();
            this.lblPayoutResult = new System.Windows.Forms.Label();
            this.lblOffResult = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.pnlmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.pnlBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.Black;
            this.pnlmenu.Controls.Add(this.butBack);
            this.pnlmenu.Controls.Add(this.butClose2);
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(900, 44);
            this.pnlmenu.TabIndex = 7;
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
            this.butBack.Text = "\\";
            this.butBack.UseVisualStyleBackColor = true;
            this.butBack.Click += new System.EventHandler(this.butBack_Click);
            // 
            // butClose2
            // 
            this.butClose2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butClose2.BackgroundImage")));
            this.butClose2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butClose2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose2.Location = new System.Drawing.Point(857, 3);
            this.butClose2.Name = "butClose2";
            this.butClose2.Size = new System.Drawing.Size(40, 38);
            this.butClose2.TabIndex = 0;
            this.butClose2.UseVisualStyleBackColor = true;
            this.butClose2.Click += new System.EventHandler(this.butClose2_Click);
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(183, 50);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.Size = new System.Drawing.Size(705, 316);
            this.dgvCart.TabIndex = 8;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(39, 76);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 52);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(409, 184);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(115, 52);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlBill
            // 
            this.pnlBill.Controls.Add(this.lblOffResult);
            this.pnlBill.Controls.Add(this.lblPayoutResult);
            this.pnlBill.Controls.Add(this.lblTotalResult);
            this.pnlBill.Controls.Add(this.txtOfcodeResult);
            this.pnlBill.Controls.Add(this.lblOffCode);
            this.pnlBill.Controls.Add(this.lblOff);
            this.pnlBill.Controls.Add(this.lblPayout);
            this.pnlBill.Controls.Add(this.lblTotal);
            this.pnlBill.Controls.Add(this.btnCheckOut);
            this.pnlBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlBill.Location = new System.Drawing.Point(347, 386);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(541, 252);
            this.pnlBill.TabIndex = 11;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Black;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(19, 28);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 21);
            this.lblTotal.TabIndex = 11;
            this.lblTotal.Text = "Total:";
            // 
            // lblPayout
            // 
            this.lblPayout.AutoSize = true;
            this.lblPayout.BackColor = System.Drawing.Color.Black;
            this.lblPayout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayout.ForeColor = System.Drawing.Color.White;
            this.lblPayout.Location = new System.Drawing.Point(346, 106);
            this.lblPayout.Name = "lblPayout";
            this.lblPayout.Size = new System.Drawing.Size(60, 21);
            this.lblPayout.TabIndex = 12;
            this.lblPayout.Text = "Payout:";
            // 
            // lblOff
            // 
            this.lblOff.AutoSize = true;
            this.lblOff.BackColor = System.Drawing.Color.Black;
            this.lblOff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOff.ForeColor = System.Drawing.Color.White;
            this.lblOff.Location = new System.Drawing.Point(19, 106);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(35, 21);
            this.lblOff.TabIndex = 13;
            this.lblOff.Text = "Off:";
            // 
            // lblOffCode
            // 
            this.lblOffCode.AutoSize = true;
            this.lblOffCode.BackColor = System.Drawing.Color.Black;
            this.lblOffCode.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffCode.ForeColor = System.Drawing.Color.White;
            this.lblOffCode.Location = new System.Drawing.Point(19, 184);
            this.lblOffCode.Name = "lblOffCode";
            this.lblOffCode.Size = new System.Drawing.Size(75, 21);
            this.lblOffCode.TabIndex = 14;
            this.lblOffCode.Text = "Off Code:";
            // 
            // txtOfcodeResult
            // 
            this.txtOfcodeResult.Location = new System.Drawing.Point(100, 184);
            this.txtOfcodeResult.Name = "txtOfcodeResult";
            this.txtOfcodeResult.Size = new System.Drawing.Size(84, 23);
            this.txtOfcodeResult.TabIndex = 15;
            this.txtOfcodeResult.TextChanged += new System.EventHandler(this.txtOfcodeResult_TextChanged);
            // 
            // lblTotalResult
            // 
            this.lblTotalResult.AutoSize = true;
            this.lblTotalResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalResult.ForeColor = System.Drawing.Color.White;
            this.lblTotalResult.Location = new System.Drawing.Point(70, 28);
            this.lblTotalResult.Name = "lblTotalResult";
            this.lblTotalResult.Size = new System.Drawing.Size(16, 21);
            this.lblTotalResult.TabIndex = 16;
            this.lblTotalResult.Text = "-";
            // 
            // lblPayoutResult
            // 
            this.lblPayoutResult.AutoSize = true;
            this.lblPayoutResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayoutResult.ForeColor = System.Drawing.Color.White;
            this.lblPayoutResult.Location = new System.Drawing.Point(412, 106);
            this.lblPayoutResult.Name = "lblPayoutResult";
            this.lblPayoutResult.Size = new System.Drawing.Size(16, 21);
            this.lblPayoutResult.TabIndex = 17;
            this.lblPayoutResult.Text = "-";
            // 
            // lblOffResult
            // 
            this.lblOffResult.AutoSize = true;
            this.lblOffResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffResult.ForeColor = System.Drawing.Color.White;
            this.lblOffResult.Location = new System.Drawing.Point(60, 106);
            this.lblOffResult.Name = "lblOffResult";
            this.lblOffResult.Size = new System.Drawing.Size(16, 21);
            this.lblOffResult.TabIndex = 18;
            this.lblOffResult.Text = "-";
            // 
            // btnBill
            // 
            this.btnBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.Location = new System.Drawing.Point(39, 143);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(115, 52);
            this.btnBill.TabIndex = 19;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = false;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // Cart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.pnlBill);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.pnlmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Cart_Load);
            this.pnlmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.pnlBill.ResumeLayout(false);
            this.pnlBill.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Button butClose2;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtOfcodeResult;
        private System.Windows.Forms.Label lblOffCode;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.Label lblPayout;
        private System.Windows.Forms.Label lblOffResult;
        private System.Windows.Forms.Label lblPayoutResult;
        private System.Windows.Forms.Label lblTotalResult;
        private System.Windows.Forms.Button btnBill;
    }
}