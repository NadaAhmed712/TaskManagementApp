using Task_Managment_App.Forms;

namespace Task_Managment_App
{
    public partial class MainForm : Form
    {
        private bool isDarkMode = false;
        private int _currentUserId = -1;
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            btnHome.Visible = true;
            btnLogin.Visible = true;
            btnChangeTheme.Visible = true;

            btnCategories.Visible = false;
            btnTasks.Visible = false;
            btnAddCategory.Visible = false;
            btnAddTask.Visible = false;
            btnCalendar.Visible = false;


            ApplyLightTheme(); 
        }

        private void btnChangeTheme_Click(object sender, EventArgs e)
        {
            if (isDarkMode)
            {
                ApplyLightTheme();
            }
            else
            {
                ApplyDarkTheme();
            }
            ApplyThemeToCurrentForm();
           
        }

        private void ApplyLightTheme()
        {
            this.BackColor = Color.FromArgb(220, 235, 235);           
            tableLayoutPanel2.BackColor = Color.FromArgb(0, 95, 106); 
            contentPanel.BackColor = Color.FromArgb(245, 250, 250);   

            foreach (Control ctrl in tableLayoutPanel2.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(235, 245, 245);    
                    btn.ForeColor = Color.FromArgb(0, 64, 72);        
                }
            }
            btnChangeTheme.Text = "Dark Mode";
            isDarkMode = false;
        }

        private void ApplyDarkTheme()
        {
            this.BackColor = Color.FromArgb(20, 40, 45);
            tableLayoutPanel2.BackColor = Color.FromArgb(0, 95, 106); 
            contentPanel.BackColor = Color.FromArgb(30, 40, 45);

            foreach (Control ctrl in tableLayoutPanel2.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.BackColor = Color.FromArgb(50, 80, 90);
                    btn.ForeColor = Color.WhiteSmoke;
                }
            }
            btnChangeTheme.Text = "Light Mode";
            isDarkMode = true;
        }
        public void ApplyThemeToCurrentForm()
        {
            if (contentPanel.Controls.Count > 0)
            {
                foreach (Control ctl in contentPanel.Controls)
                {
                    if (ctl is HomeForm home)
                        home.ApplyTheme(isDarkMode);
                    else if (ctl is LoginForm login)
                        login.ApplyTheme(isDarkMode);
                    else if (ctl is RegisterForm reg)
                        reg.ApplyTheme(isDarkMode);
                    else if (ctl is AddCategoryForm addCat)
                        addCat.ApplyTheme(isDarkMode);
                    else if (ctl is AddTaskForm addTask)
                        addTask.ApplyTheme(isDarkMode);
                    else if (ctl is CalendarForm cal)
                        cal.ApplyTheme(isDarkMode);
                    else if (ctl is CategoriesForm categories)
                        categories.ApplyTheme(isDarkMode);
                    else if (ctl is TasksForm Tasks)
                        Tasks.ApplyTheme(isDarkMode);
                }
            }
        }
        public void Login(object sender, EventArgs e)
        {
            btnLogin_Click(sender, e);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(btnLogin.Text== "Logout")
            {
                Logout(sender,e);
                return;
            }
            contentPanel.Controls.Clear();
            LoginForm loginForm = new LoginForm(isDarkMode);
            loginForm.TopLevel = false;
            loginForm.FormBorderStyle = FormBorderStyle.None;
            loginForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(loginForm);
            loginForm.Show();
            loginForm.FormClosed += (s, e) =>
            {
                if (loginForm.IsLoggedIn)
                {
                    btnLogin.Text= "Logout";
                    btnTasks.Visible = true;
                    btnCategories.Visible = true;
                    btnAddTask.Visible = true;
                    btnAddCategory.Visible = true;
                    btnCalendar.Visible = true;
                    _currentUserId = loginForm.CurrentUserId;
                    MessageBox.Show($"Welcome {loginForm.CurrentUserName}!");
                }

            };
        }

        private void Logout(object sender, EventArgs e)
        {
            btnTasks.Visible = false;
            btnCategories.Visible = false;
            btnAddTask.Visible = false;
            btnAddCategory.Visible = false;
            btnCalendar.Visible = false;
            btnLogin.Text = "Login";
            contentPanel.Controls.Clear();
            MessageBox.Show("You have been logged out.");
            btnLogin_Click(sender, e);

        }



        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategoryForm catForm = new AddCategoryForm(_currentUserId);
            catForm.TopLevel = false;
            catForm.FormBorderStyle = FormBorderStyle.None;
            catForm.Dock = DockStyle.Fill;

            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(catForm);
            catForm.Show();
            catForm.ApplyTheme(isDarkMode); 
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskForm taskForm = new AddTaskForm(_currentUserId);
            taskForm.TopLevel = false;
            taskForm.FormBorderStyle = FormBorderStyle.None;
            taskForm.Dock = DockStyle.Fill;

            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(taskForm);
            taskForm.Show();
            taskForm.ApplyTheme(isDarkMode); 
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            CalendarForm calendarForm = new CalendarForm(_currentUserId, isDarkMode);
            calendarForm.TopLevel = false;
            calendarForm.FormBorderStyle = FormBorderStyle.None;
            calendarForm.Dock = DockStyle.Fill;

            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(calendarForm);
            calendarForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm(_currentUserId, isDarkMode);
            homeForm.TopLevel = false;
            homeForm.FormBorderStyle = FormBorderStyle.None;
            homeForm.Dock = DockStyle.Fill;

            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(homeForm);
            homeForm.Show();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            CategoriesForm catForm = new CategoriesForm(_currentUserId, isDarkMode);
            catForm.TopLevel = false;
            catForm.FormBorderStyle = FormBorderStyle.None;
            catForm.Dock = DockStyle.Fill;

            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(catForm);
            catForm.Show();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            TasksForm taskForm = new TasksForm(_currentUserId, isDarkMode);
            taskForm.TopLevel = false;
            taskForm.FormBorderStyle = FormBorderStyle.None;
            taskForm.Dock = DockStyle.Fill;

            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(taskForm);
            taskForm.Show();
        }
    }
}
