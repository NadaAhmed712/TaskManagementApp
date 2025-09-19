namespace Task_Managment_App.Forms
{
    partial class RegisterForm
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
            this.txtName = new TextBox();
            this.txtEmail = new TextBox();
            this.txtPassword = new TextBox();
            this.txtConfirmPassword = new TextBox();
            this.lblName = new Label();
            this.lblEmail = new Label();
            this.lblPassword = new Label();
            this.lblConfirmPassword = new Label();
            this.btnRegister = new Button();
            this.linkLogin = new LinkLabel();
            this.SuspendLayout();

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Text = "Name:";
            this.lblName.Location = new System.Drawing.Point(30, 20);

            // txtName
            this.txtName.Location = new System.Drawing.Point(30, 45);
            this.txtName.Size = new System.Drawing.Size(250, 23);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new System.Drawing.Point(30, 80);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(30, 105);
            this.txtEmail.Size = new System.Drawing.Size(250, 23);

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(30, 140);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(30, 165);
            this.txtPassword.Size = new System.Drawing.Size(250, 23);
            this.txtPassword.UseSystemPasswordChar = true;

            // lblConfirmPassword
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Text = "Confirm Password:";
            this.lblConfirmPassword.Location = new System.Drawing.Point(30, 200);

            // txtConfirmPassword
            this.txtConfirmPassword.Location = new System.Drawing.Point(30, 225);
            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 23);
            this.txtConfirmPassword.UseSystemPasswordChar = true;

            // btnRegister
            this.btnRegister.Text = "Register";
            this.btnRegister.Location = new System.Drawing.Point(30, 260);
            this.btnRegister.Size = new System.Drawing.Size(250, 35);
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // linkLogin
            this.linkLogin.Text = "Already have an account? Login";
            this.linkLogin.Location = new System.Drawing.Point(30, 305);
            this.linkLogin.AutoSize = true;
            this.linkLogin.LinkClicked += (s, e) =>
            {
                // جلب الفورم الرئيسي
                MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
                if (mainForm != null)
                {
                    mainForm.ContentPanel.Controls.Clear();

                    mainForm.Login(s,e);
                }
            };


            // RegisterForm
            this.Text = "RegisterForm";
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.linkLogin);
            this.Size = new System.Drawing.Size(320, 350);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Label lblName;
        private Label lblEmail;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Button btnRegister;
        private LinkLabel linkLogin;
    }
}