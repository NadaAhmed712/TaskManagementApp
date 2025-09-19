using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_Managment_App.Models;

namespace Task_Managment_App.Forms
{
    public partial class LoginForm : Form
    {
        public bool IsLoggedIn { get; private set; } = false;
        public string CurrentUserName { get; private set; } = "";
        public int CurrentUserId { get; private set; } = -1;
        private bool isDarkMode;
        public LoginForm(bool darkMode)
        {
            InitializeComponent();
            isDarkMode = darkMode;
            ApplyTheme(isDarkMode);
        }
        public LoginForm()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (var db = new TaskManagementAppDbContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == txtEmail.Text);
                if (user != null && BCrypt.Net.BCrypt.Verify(txtPassword.Text, user.PasswordHash))
                {
                    IsLoggedIn = true;
                    CurrentUserName = user.Name;
                    CurrentUserId = user.Id;
                    HomeForm home = new HomeForm(user.Id);
                    home.TopLevel = false;
                    home.FormBorderStyle = FormBorderStyle.None;
                    home.Dock = DockStyle.Fill;

                    MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
                    mainForm.ContentPanel.Controls.Clear();
                    mainForm.ContentPanel.Controls.Add(home);
                    this.Close();
                    home.Show();
                    
                }
                else
                {
                    MessageBox.Show("Invalid email or password!");
                }
            }
        }
        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            RegisterForm regForm = new RegisterForm(isDarkMode);
            regForm.TopLevel = false;
            regForm.FormBorderStyle = FormBorderStyle.None;
            regForm.Dock = DockStyle.Fill;

            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            mainForm.ContentPanel.Controls.Clear();
            mainForm.ContentPanel.Controls.Add(regForm);
            regForm.Show();
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
            linkRegister.LinkColor = isDark ? Color.White:Color.Blue;
        }


    }
}
