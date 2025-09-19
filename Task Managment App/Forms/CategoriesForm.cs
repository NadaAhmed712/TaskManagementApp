using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Task_Managment_App.Models;

namespace Task_Managment_App.Forms
{
    public partial class CategoriesForm : Form
    {
        private int userId;
        private bool isDarkMode;

        public CategoriesForm(int currentUserId, bool darkMode)
        {
            InitializeComponent();
            userId = currentUserId;
            isDarkMode = darkMode;

            ApplyTheme(isDarkMode);
            LoadCategories();
        }

        private void LoadCategories()
        {
            dgvCategories.Rows.Clear();
            dgvCategories.Columns.Clear();

            dgvCategories.Columns.Add("Name", "Category Name");
            dgvCategories.Columns.Add("TaskCount", "Tasks Count");

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.Name = "Edit";
            editButton.HeaderText = "";
            editButton.Text = "Edit";
            editButton.UseColumnTextForButtonValue = true;
            dgvCategories.Columns.Add(editButton);

            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "Delete";
            deleteButton.HeaderText = "";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            dgvCategories.Columns.Add(deleteButton);

            using (var db = new TaskManagementAppDbContext())
            {
                var categories = db.Categories
                    .Where(c => c.UserId == userId)
                    .Include(c => c.Tasks)
                    .ToList();

                foreach (var cat in categories)
                {
                    dgvCategories.Rows.Add(cat.Name, cat.Tasks.Count);
                }
            }

            dgvCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            foreach (DataGridViewColumn col in dgvCategories.Columns)
            {
                col.FillWeight = 25;
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvCategories.Rows[e.RowIndex];
            string categoryName = row.Cells["Name"].Value.ToString();

            if (dgvCategories.Columns[e.ColumnIndex].Name == "Edit")
            {
                var addForm = new AddCategoryForm(userId, categoryName);
                addForm.ShowDialog();
                LoadCategories();
            }
            else if (dgvCategories.Columns[e.ColumnIndex].Name == "Delete")
            {
                var confirm = MessageBox.Show($"Are you sure you want to delete '{categoryName}'?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (var db = new TaskManagementAppDbContext())
                    {
                        var cat = db.Categories.FirstOrDefault(c => c.Name == categoryName && c.UserId == userId);
                        if (cat != null)
                        {
                            db.Categories.Remove(cat);
                            db.SaveChanges();
                        }
                    }
                    LoadCategories();
                }
            }
        }

        public void ApplyTheme(bool isDark)
        {
            this.BackColor = isDark ? Color.FromArgb(0, 95, 106) : Color.FromArgb(197, 229, 245);
            dgvCategories.BackgroundColor = isDark ? Color.FromArgb(10, 70, 80) : Color.White;
            dgvCategories.ForeColor = Color.Black;
            dgvCategories.ColumnHeadersDefaultCellStyle.BackColor = isDark ? Color.FromArgb(0, 80, 90) : Color.LightGray;
            dgvCategories.EnableHeadersVisualStyles = false;
        }
    }
}

