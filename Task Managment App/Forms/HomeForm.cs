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
    public partial class HomeForm : Form
    {
        private int userId;

        private bool isDarkMode;

        public HomeForm(int userId, bool darkMode)
        {
            InitializeComponent();
            this.userId = userId;
            isDarkMode = darkMode;
            ApplyTheme(isDarkMode);
            LoadSummary(userId);
        }
        public HomeForm(int userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadSummary(userId);
        }
        private void LoadSummary(int userId)
        {
            using (var db = new TaskManagementAppDbContext())
            {
                var tasks = db.Tasks.Where(t => t.UserId == userId).ToList();

                lblTotalTasks.Text = $"Total Tasks: {tasks.Count}";
                lblPendingTasks.Text = $"Pending: {tasks.Count(t => t.Status == Status.Pending)}";
                lblInProgressTasks.Text = $"In Progress: {tasks.Count(t => t.Status == Status.InProgress)}";
                lblCompletedTasks.Text = $"Completed: {tasks.Count(t => t.Status == Status.Completed)}";
            }
        }
        public void ApplyTheme(bool isDark)
        {
            this.BackColor = isDark ? Color.FromArgb(0, 95, 106) : Color.FromArgb(197, 229, 245);

            Color foreColor = isDark ? Color.White : Color.Black;

            lblTotalTasks.ForeColor = foreColor;
            lblPendingTasks.ForeColor = foreColor;
            lblInProgressTasks.ForeColor = foreColor;
            lblCompletedTasks.ForeColor = foreColor;

            foreach (Control c in this.Controls)
            {
                if (c is Panel panel)
                    panel.BackColor = isDark ? Color.FromArgb(0, 80, 90) : Color.White;

                if (c is ListView lv)
                {
                    lv.BackColor = isDark ? Color.FromArgb(10, 70, 80) : Color.White;
                    lv.ForeColor = foreColor;
                }
            }
        }
    }
}
