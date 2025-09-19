using System;
using System.Linq;
using System.Windows.Forms;
using Task_Managment_App.Models;

namespace Task_Managment_App.Forms
{
    public partial class AddCategoryForm : Form
    {
        private int _userId;
        private string _existingCategoryName = null;

        public AddCategoryForm(int userId, string categoryName = null)
        {
            InitializeComponent();
            _userId = userId;
            _existingCategoryName = categoryName;

            if (!string.IsNullOrEmpty(_existingCategoryName))
            {
                txtName.Text = _existingCategoryName;
                btnAdd.Text = "Update Category";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Category name cannot be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var db = new TaskManagementAppDbContext())
            {
                if (string.IsNullOrEmpty(_existingCategoryName))
                {
                    var category = new Category { Name = name, UserId = _userId };
                    db.Categories.Add(category);
                    db.SaveChanges();
                    MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var category = db.Categories.FirstOrDefault(c => c.Name == _existingCategoryName && c.UserId == _userId);
                    if (category != null)
                    {
                        category.Name = name;
                        db.SaveChanges();
                        MessageBox.Show("Category updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }
    }
}
