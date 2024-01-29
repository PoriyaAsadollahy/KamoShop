namespace Final_Project
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.butClose = new System.Windows.Forms.Button();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.llblSignUp = new System.Windows.Forms.LinkLabel();
            this.butLogin = new System.Windows.Forms.Button();
            this.llblForget = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblLogInError = new System.Windows.Forms.Label();
            this.pnlmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.Black;
            this.pnlmenu.Controls.Add(this.butClose);
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(900, 44);
            this.pnlmenu.TabIndex = 1;
            // 
            // butClose
            // 
            this.butClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butClose.BackgroundImage")));
            this.butClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.Location = new System.Drawing.Point(857, 3);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(40, 38);
            this.butClose.TabIndex = 0;
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            // 
            // picBackground
            // 
            this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
            this.picBackground.Location = new System.Drawing.Point(411, 153);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(477, 388);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 3;
            this.picBackground.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pnlLogin.Controls.Add(this.lblLogInError);
            this.pnlLogin.Controls.Add(this.txtUserName);
            this.pnlLogin.Controls.Add(this.llblSignUp);
            this.pnlLogin.Controls.Add(this.butLogin);
            this.pnlLogin.Controls.Add(this.llblForget);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.lblUserName);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Location = new System.Drawing.Point(33, 153);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(350, 388);
            this.pnlLogin.TabIndex = 0;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(20, 103);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(308, 25);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged_1);
            // 
            // llblSignUp
            // 
            this.llblSignUp.ActiveLinkColor = System.Drawing.Color.LightCyan;
            this.llblSignUp.AutoSize = true;
            this.llblSignUp.LinkColor = System.Drawing.Color.Gray;
            this.llblSignUp.Location = new System.Drawing.Point(75, 335);
            this.llblSignUp.Name = "llblSignUp";
            this.llblSignUp.Size = new System.Drawing.Size(198, 17);
            this.llblSignUp.TabIndex = 4;
            this.llblSignUp.TabStop = true;
            this.llblSignUp.Text = "Don`t you have account? Sign up";
            this.llblSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblSignUp_LinkClicked);
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(255)))), ((int)(((byte)(248)))));
            this.butLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butLogin.Location = new System.Drawing.Point(85, 276);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(178, 56);
            this.butLogin.TabIndex = 2;
            this.butLogin.Text = "Login";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.EnabledChanged += new System.EventHandler(this.butLogin_EnabledChanged);
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // llblForget
            // 
            this.llblForget.ActiveLinkColor = System.Drawing.Color.LightCyan;
            this.llblForget.AutoSize = true;
            this.llblForget.LinkColor = System.Drawing.Color.Gray;
            this.llblForget.Location = new System.Drawing.Point(138, 215);
            this.llblForget.Name = "llblForget";
            this.llblForget.Size = new System.Drawing.Size(73, 17);
            this.llblForget.TabIndex = 3;
            this.llblForget.TabStop = true;
            this.llblForget.Text = "I need help";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(20, 170);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(308, 25);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtUserName_TextChanged_1);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(19, 82);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(74, 17);
            this.lblUserName.TabIndex = 6;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(19, 149);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(64, 17);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.ForeColor = System.Drawing.Color.White;
            this.lblLogin.Location = new System.Drawing.Point(138, 15);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(73, 17);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Login Page";
            // 
            // lblLogInError
            // 
            this.lblLogInError.AutoSize = true;
            this.lblLogInError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblLogInError.ForeColor = System.Drawing.Color.White;
            this.lblLogInError.Location = new System.Drawing.Point(75, 256);
            this.lblLogInError.Name = "lblLogInError";
            this.lblLogInError.Size = new System.Drawing.Size(0, 17);
            this.lblLogInError.TabIndex = 29;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlmenu);
            this.Controls.Add(this.picBackground);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmenu;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.PictureBox picBackground;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel llblForget;
        private System.Windows.Forms.LinkLabel llblSignUp;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblLogInError;
    }
}

