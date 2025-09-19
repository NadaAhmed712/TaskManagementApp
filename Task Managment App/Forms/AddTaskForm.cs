using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Task_Managment_App.Models;

namespace Task_Managment_App.Forms
{
    public partial class AddTaskForm : Form
    {
        private int userId;
        private int taskId = 0; 
        public Action OnTaskAdded;
        public Action OnTaskUpdated;

        public AddTaskForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            InitializeControls();
        }

        public AddTaskForm(int userId, int taskId)
        {
            InitializeComponent();
            this.userId = userId;
            this.taskId = taskId;
            InitializeControls();
            LoadTask(taskId);
        }

        private void InitializeControls()
        {
            cbPriority.DataSource = Enum.GetValues(typeof(Priority));
            cbStatus.DataSource = Enum.GetValues(typeof(Status));
            LoadCategories();

            btnAdd.Text = taskId == 0 ? "Add Task" : "Update Task";
            btnAdd.Click += BtnAdd_Click;
        }

        private void LoadCategories()
        {
            using (var db = new TaskManagementAppDbContext())
            {
                var categories = db.Categories.Where(c => c.UserId == userId).ToList();
                cbCategory.DataSource = categories;
                cbCategory.DisplayMember = "Name";
                cbCategory.ValueMember = "Id";
            }
        }

        private void LoadTask(int taskId)
        {
            using (var db = new TaskManagementAppDbContext())
            {
                var task = db.Tasks.Find(taskId);
                if (task != null)
                {
                    txtTitle.Text = task.Title;
                    txtDesc.Text = task.Description;
                    dtpDueDate.Value = task.DueDate;
                    cbPriority.SelectedItem = task.Priority;
                    cbStatus.SelectedItem = task.Status;
                    cbCategory.SelectedValue = task.CategoryId;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string desc = txtDesc.Text.Trim();
            DateTime due = dtpDueDate.Value;
            Priority priority = (Priority)cbPriority.SelectedItem;
            Status status = (Status)cbStatus.SelectedItem;
            int categoryId = (int)cbCategory.SelectedValue;

            if (string.IsNullOrEmpty(title) || categoryId == 0)
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            using (var db = new TaskManagementAppDbContext())
            {
                if (taskId == 0)
                {
                    TaskItem task = new TaskItem
                    {
                        Title = title,
                        Description = desc,
                        DueDate = due,
                        Priority = priority,
                        Status = status,
                        UserId = userId,
                        CategoryId = categoryId,
                        CreatedAt = DateTime.Now
                    };
                    db.Tasks.Add(task);
                    db.SaveChanges();
                    OnTaskAdded?.Invoke();
                    MessageBox.Show("Task added successfully!");
                    txtTitle.Clear();
                    txtDesc.Clear();
                    dtpDueDate.Value = DateTime.Now;
                    cbPriority.SelectedIndex = 0;
                    cbStatus.SelectedIndex = 0;
                    if (cbCategory.Items.Count > 0)
                        cbCategory.SelectedIndex = 0;

                    txtTitle.Focus(); 
                }
                else
                {
                    var task = db.Tasks.Find(taskId);
                    if (task != null)
                    {
                        task.Title = title;
                        task.Description = desc;
                        task.DueDate = due;
                        task.Priority = priority;
                        task.Status = status;
                        task.CategoryId = categoryId;
                        db.SaveChanges();
                        OnTaskUpdated?.Invoke();
                        MessageBox.Show("Task updated successfully!");
                        this.Close();
                    }
                }
            }

            
        }

        public void ApplyTheme(bool isDark)
        {
            Color back = isDark ? Color.FromArgb(0, 95, 106) : Color.FromArgb(197, 229, 245);
            Color fore = isDark ? Color.White : Color.Black;

            this.BackColor = back;
            foreach (Control c in this.Controls)
            {
                switch (c)
                {
                    case Label lbl:
                        lbl.ForeColor = fore;
                        break;
                    case TextBox tb:
                        tb.BackColor = Color.White;
                        tb.ForeColor = Color.Black;
                        break;
                    case ComboBox cb:
                        cb.BackColor = Color.White;
                        cb.ForeColor = Color.Black;
                        break;
                    case DateTimePicker dtp:
                        dtp.CalendarForeColor = fore;
                        dtp.CalendarMonthBackground = Color.White;
                        break;
                    case Button btn:
                        btn.BackColor = back;
                        btn.ForeColor = fore;
                        break;
                }
            }
        }
    }
}
