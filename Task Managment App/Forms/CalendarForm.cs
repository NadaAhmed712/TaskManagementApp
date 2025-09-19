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
    public partial class CalendarForm : Form
    {
        private int userId;
        private bool isDarkMode;

        public CalendarForm(int currentUserId, bool darkMode)
        {
            InitializeComponent();
            userId = currentUserId;
            isDarkMode = darkMode;
            ApplyTheme(isDarkMode);
            LoadTasks(monthCalendar.SelectionStart);
        }

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            LoadTasks(e.Start);
        }

        private void LoadTasks(DateTime date)
        {
            lstTasks.Items.Clear();
            using (var db = new TaskManagementAppDbContext())
            {
                var tasks = db.Tasks
                    .Where(t => t.UserId == userId && t.DueDate.Date == date.Date)
                    .ToList();

                foreach (var task in tasks)
                {
                    lstTasks.Items.Add($"{task.Title} - {task.Status} - {task.Priority}");
                }
            }
        }

        public void ApplyTheme(bool isDark)
        {
            this.BackColor = isDark ? Color.FromArgb(0, 95, 106) : Color.FromArgb(197, 229, 245);
            lstTasks.BackColor = isDark ? Color.FromArgb(10, 70, 80) : Color.White;
            lstTasks.ForeColor = isDark ? Color.White : Color.Black;
        }
    }

}
