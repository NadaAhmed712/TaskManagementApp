using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Task_Managment_App.Models;

namespace Task_Managment_App.Forms
{
    public partial class RegisterForm : Form
    {
        private bool isDarkMode;
        public RegisterForm(bool darkMode)
        {
            InitializeComponent();
            isDarkMode = darkMode;
            ApplyTheme(isDarkMode);
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match!");
                return;
            }

            using (var db = new TaskManagementAppDbContext())
            {
                if (db.Users.Any(u => u.Email == txtEmail.Text))
                {
                    MessageBox.Show("Email already registered!");
                    return;
                }

                var newUser = new User
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    PasswordHash = BCrypt.Net.BCrypt.HashPassword(txtPassword.Text)
                };

                db.Users.Add(newUser);
                db.SaveChanges();
            }

            MessageBox.Show("Account created successfully!");
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];


            mainForm.Login(sender,e);
           
            this.Close(); 
        }
        public void ApplyTheme(bool isDark)
        {
            this.BackColor = isDark ? Color.FromArgb(0, 95, 106) : Color.FromArgb(197, 229, 245);

            foreach (Control ctl in this.Controls)
            {
                if (ctl is Label || ctl is LinkLabel)
                {
                    ctl.ForeColor = isDark ? Color.White : Color.Black;
                }
                else if (ctl is TextBox)
                {
                    ctl.BackColor = isDark ? Color.FromArgb(10, 70, 80) : Color.White;
                    ctl.ForeColor = isDark ? Color.White : Color.Black;
                }
                else if (ctl is Button)
                {
                    ctl.BackColor = isDark ? Color.FromArgb(0, 70, 80) : Color.FromArgb(197, 229, 245);
                    ctl.ForeColor = isDark ? Color.White : Color.Black;
                }
            }
            linkLogin.LinkColor = isDark ? Color.White : Color.Blue;
        }

    }
}
