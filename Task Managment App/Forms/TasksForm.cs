using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Task_Managment_App.Models;

namespace Task_Managment_App.Forms
{
    public partial class TasksForm : Form
    {
        private int userId;
        private bool isDarkMode;
        private int currentPage = 1;
        private int pageSize = 5;
        private string searchPlaceholder = "Search by name/desc";

        public TasksForm(int currentUserId, bool darkMode)
        {
            InitializeComponent();
            userId = currentUserId;
            isDarkMode = darkMode;

            InitializeFilters();
            InitializeSearchPlaceholder();
            LoadTasks();
            ApplyTheme(isDarkMode);
        }

        private void InitializeFilters()
        {
            cbStatusFilter.Items.Add("All");
            cbStatusFilter.Items.AddRange(Enum.GetNames(typeof(Status)));
            cbStatusFilter.SelectedIndex = 0;

            cbPriorityFilter.Items.Add("All");
            cbPriorityFilter.Items.AddRange(Enum.GetNames(typeof(Priority)));
            cbPriorityFilter.SelectedIndex = 0;

            cbStatusFilter.SelectedIndexChanged += FilterChanged;
            cbPriorityFilter.SelectedIndexChanged += FilterChanged;
        }

        private void InitializeSearchPlaceholder()
        {
            txtSearch.Text = searchPlaceholder;
            txtSearch.ForeColor = isDarkMode ? Color.White : Color.Black;

            txtSearch.Enter += (s, e) =>
            {
                if (txtSearch.Text == searchPlaceholder)
                    txtSearch.Text = "";
                txtSearch.ForeColor = isDarkMode ? Color.White : Color.Black;
            };

            txtSearch.Leave += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.Text = searchPlaceholder;
                    txtSearch.ForeColor = isDarkMode ? Color.White : Color.Black;
                }
            };

            txtSearch.TextChanged += (s, e) => LoadTasks();
        }

        private void LoadTasks()
        {
            dataGridViewTasks.Rows.Clear();

            using (var db = new TaskManagementAppDbContext())
            {
                var tasks = db.Tasks.Where(t => t.UserId == userId).AsQueryable();

                if (cbStatusFilter.SelectedIndex > 0)
                {
                    var selectedStatus = (Status)Enum.Parse(typeof(Status), cbStatusFilter.SelectedItem.ToString());
                    tasks = tasks.Where(t => t.Status == selectedStatus);
                }

                if (cbPriorityFilter.SelectedIndex > 0)
                {
                    var selectedPriority = (Priority)Enum.Parse(typeof(Priority), cbPriorityFilter.SelectedItem.ToString());
                    tasks = tasks.Where(t => t.Priority == selectedPriority);
                }

                string search = txtSearch.Text.Trim().ToLower();
                if (!string.IsNullOrEmpty(search) && search != searchPlaceholder.ToLower())
                {
                    tasks = tasks.Where(t => t.Title.ToLower().Contains(search) || t.Description.ToLower().Contains(search));
                }

                var pagedTasks = tasks
                    .OrderBy(t => t.DueDate)
                    .Skip((currentPage - 1) * pageSize)
                    .Take(pageSize)
                    .ToList();

                foreach (var task in pagedTasks)
                {
                    dataGridViewTasks.Rows.Add(
                        task.Id,
                        task.Title,
                        task.Description,
                        task.DueDate.ToShortDateString(),
                        task.Priority.ToString(),
                        task.Status.ToString(),
                        "Edit",
                        "Delete"
                    );
                }
            }
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadTasks();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadTasks();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentPage++;
            LoadTasks();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            AddTaskForm taskForm = new AddTaskForm(userId);
            taskForm.OnTaskAdded = () => LoadTasks();
            taskForm.ApplyTheme(isDarkMode);
            taskForm.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            using (var db = new TaskManagementAppDbContext())
            {
                int completed = db.Tasks.Count(t => t.UserId == userId && t.Status == Status.Completed);
                int pending = db.Tasks.Count(t => t.UserId == userId && t.Status != Status.Completed);
                int InProgress = db.Tasks.Count(t => t.UserId == userId && t.Status == Status.InProgress);
                MessageBox.Show($"Completed: {completed}\nPending: {pending}\nInProgress: {InProgress}", "Tasks Report");
            }
        }

        private void dataGridViewTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int taskId = (int)dataGridViewTasks.Rows[e.RowIndex].Cells["Id"].Value;

            if (dataGridViewTasks.Columns[e.ColumnIndex].Name == "EditBtn")
            {
                AddTaskForm editForm = new AddTaskForm(userId, taskId);
                editForm.OnTaskUpdated = () => LoadTasks();
                editForm.ApplyTheme(isDarkMode);
                editForm.ShowDialog();
            }
            else if (dataGridViewTasks.Columns[e.ColumnIndex].Name == "DeleteBtn")
            {
                DialogResult result = MessageBox.Show(
        "Are you sure you want to delete this task?",
        "Confirm Delete",
        MessageBoxButtons.OKCancel,
        MessageBoxIcon.Warning
    );
                if (result == DialogResult.OK) // المستخدم ضغط OK
                {
                    using (var db = new TaskManagementAppDbContext())
                    {
                        var task = db.Tasks.Find(taskId);
                        if (task != null)
                        {
                            db.Tasks.Remove(task);
                            db.SaveChanges();
                        }
                    }
                    LoadTasks();
                }
            }
        }

        public void ApplyTheme(bool isDark)
        {
            Color backColor = isDark ? Color.FromArgb(10, 70, 80) : Color.White;
            Color foreColor = isDark ? Color.White : Color.Black;
            Color headerBack = isDark ? Color.FromArgb(0, 95, 106) : Color.FromArgb(120, 180, 190);
            Color headerFore = foreColor;

            this.BackColor = isDark ? Color.FromArgb(0, 95, 106) : Color.FromArgb(197, 229, 245);

            cbStatusFilter.BackColor = backColor;
            cbStatusFilter.ForeColor = foreColor;
            cbPriorityFilter.BackColor = backColor;
            cbPriorityFilter.ForeColor = foreColor;
            txtSearch.BackColor = backColor;
            txtSearch.ForeColor = foreColor;

            dataGridViewTasks.BackgroundColor = backColor;
            dataGridViewTasks.ForeColor = foreColor;
            dataGridViewTasks.EnableHeadersVisualStyles = false;
            dataGridViewTasks.ColumnHeadersDefaultCellStyle.BackColor = headerBack;
            dataGridViewTasks.ColumnHeadersDefaultCellStyle.ForeColor = headerFore;
            dataGridViewTasks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridViewTasks.RowHeadersVisible = false;

            dataGridViewTasks.RowsDefaultCellStyle.BackColor = backColor;
            dataGridViewTasks.RowsDefaultCellStyle.ForeColor = foreColor;
            dataGridViewTasks.AlternatingRowsDefaultCellStyle.BackColor = isDark ? Color.FromArgb(15, 80, 90) : Color.AliceBlue;
            dataGridViewTasks.AlternatingRowsDefaultCellStyle.ForeColor = foreColor;
        }
    }
}
