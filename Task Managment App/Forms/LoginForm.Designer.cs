namespace Task_Managment_App.Forms
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.txtEmail = new TextBox();
            this.txtPassword = new TextBox();
            this.btnLogin = new Button();
            this.lblEmail = new Label();
            this.lblPassword = new Label();
            this.linkRegister = new LinkLabel();
            this.SuspendLayout();

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(30, 30);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(30, 55);
            this.txtEmail.Size = new System.Drawing.Size(250, 23);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(30, 90);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(30, 115);
            this.txtPassword.Size = new System.Drawing.Size(250, 23);
            this.txtPassword.UseSystemPasswordChar = true;

            // btnLogin
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(30, 155);
            this.btnLogin.Size = new System.Drawing.Size(250, 35);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // linkRegister
            this.linkRegister.Text = "Don't have an account? Register";
            this.linkRegister.Location = new System.Drawing.Point(30, 205);
            this.linkRegister.AutoSize = true;
            this.linkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegister_LinkClicked);

            // LoginForm
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linkRegister);
            this.Size = new System.Drawing.Size(320, 260);
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblEmail;
        private Label lblPassword;
        private LinkLabel linkRegister;
    }
}