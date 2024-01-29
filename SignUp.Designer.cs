namespace Final_Project
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.picBackground2 = new System.Windows.Forms.PictureBox();
            this.pnlSignUp = new System.Windows.Forms.Panel();
            this.lblSignInError = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.butSignUp = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName2 = new System.Windows.Forms.Label();
            this.lblPassword2 = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.butBack = new System.Windows.Forms.Button();
            this.butClose2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground2)).BeginInit();
            this.pnlSignUp.SuspendLayout();
            this.pnlmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBackground2
            // 
            this.picBackground2.Image = ((System.Drawing.Image)(resources.GetObject("picBackground2.Image")));
            this.picBackground2.Location = new System.Drawing.Point(411, 153);
            this.picBackground2.Name = "picBackground2";
            this.picBackground2.Size = new System.Drawing.Size(477, 388);
            this.picBackground2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground2.TabIndex = 4;
            this.picBackground2.TabStop = false;
            // 
            // pnlSignUp
            // 
            this.pnlSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlSignUp.Controls.Add(this.lblSignInError);
            this.pnlSignUp.Controls.Add(this.txtUserName);
            this.pnlSignUp.Controls.Add(this.butSignUp);
            this.pnlSignUp.Controls.Add(this.txtPassword);
            this.pnlSignUp.Controls.Add(this.lblUserName2);
            this.pnlSignUp.Controls.Add(this.lblPassword2);
            this.pnlSignUp.Controls.Add(this.lblSignUp);
            this.pnlSignUp.Location = new System.Drawing.Point(33, 153);
            this.pnlSignUp.Name = "pnlSignUp";
            this.pnlSignUp.Size = new System.Drawing.Size(350, 388);
            this.pnlSignUp.TabIndex = 5;
            // 
            // lblSignInError
            // 
            this.lblSignInError.AutoSize = true;
            this.lblSignInError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSignInError.ForeColor = System.Drawing.Color.White;
            this.lblSignInError.Location = new System.Drawing.Point(91, 335);
            this.lblSignInError.Name = "lblSignInError";
            this.lblSignInError.Size = new System.Drawing.Size(0, 17);
            this.lblSignInError.TabIndex = 28;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtUserName.Location = new System.Drawing.Point(20, 103);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(308, 25);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // butSignUp
            // 
            this.butSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.butSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butSignUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.butSignUp.Location = new System.Drawing.Point(85, 276);
            this.butSignUp.Name = "butSignUp";
            this.butSignUp.Size = new System.Drawing.Size(178, 56);
            this.butSignUp.TabIndex = 2;
            this.butSignUp.Text = "Sign Up";
            this.butSignUp.UseVisualStyleBackColor = false;
            this.butSignUp.Click += new System.EventHandler(this.butSignUp_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtPassword.Location = new System.Drawing.Point(20, 169);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(308, 25);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblUserName2
            // 
            this.lblUserName2.AutoSize = true;
            this.lblUserName2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblUserName2.ForeColor = System.Drawing.Color.White;
            this.lblUserName2.Location = new System.Drawing.Point(19, 82);
            this.lblUserName2.Name = "lblUserName2";
            this.lblUserName2.Size = new System.Drawing.Size(74, 17);
            this.lblUserName2.TabIndex = 6;
            this.lblUserName2.Text = "User Name";
            // 
            // lblPassword2
            // 
            this.lblPassword2.AutoSize = true;
            this.lblPassword2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblPassword2.ForeColor = System.Drawing.Color.White;
            this.lblPassword2.Location = new System.Drawing.Point(19, 149);
            this.lblPassword2.Name = "lblPassword2";
            this.lblPassword2.Size = new System.Drawing.Size(64, 17);
            this.lblPassword2.TabIndex = 7;
            this.lblPassword2.Text = "Password";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblSignUp.ForeColor = System.Drawing.Color.White;
            this.lblSignUp.Location = new System.Drawing.Point(131, 15);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(87, 17);
            this.lblSignUp.TabIndex = 5;
            this.lblSignUp.Text = "Sign Up Page";
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.Black;
            this.pnlmenu.Controls.Add(this.butBack);
            this.pnlmenu.Controls.Add(this.butClose2);
            this.pnlmenu.Location = new System.Drawing.Point(1, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(900, 44);
            this.pnlmenu.TabIndex = 6;
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
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pnlmenu);
            this.Controls.Add(this.pnlSignUp);
            this.Controls.Add(this.picBackground2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground2)).EndInit();
            this.pnlSignUp.ResumeLayout(false);
            this.pnlSignUp.PerformLayout();
            this.pnlmenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBackground2;
        private System.Windows.Forms.Panel pnlSignUp;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button butSignUp;
        private System.Windows.Forms.Label lblUserName2;
        private System.Windows.Forms.Label lblPassword2;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Button butClose2;
        private System.Windows.Forms.Button butBack;
        private System.Windows.Forms.Label lblSignInError;
    }
}