namespace Task_Managment_App.Forms
{
    partial class AddCategoryForm
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

            this.lblName = new Label();
            this.txtName = new TextBox();
            this.btnAdd = new Button();

            this.SuspendLayout();

            // lblName
            this.lblName.AutoSize = true;
            this.lblName.Location = new Point(20, 20);
            this.lblName.Text = "Category Name:";

            // txtName
            this.txtName.Location = new Point(20, 50);
            this.txtName.Width = 200;

            // btnAdd
            this.btnAdd.Location = new Point(20, 90);
            this.btnAdd.Text = "Add Category";
            this.btnAdd.Click += BtnAdd_Click;

            // AddCategoryForm
            this.Controls.Add(lblName);
            this.Controls.Add(txtName);
            this.Controls.Add(btnAdd);

            this.Size = new Size(300, 150);
            this.Name = "AddCategoryForm";
            this.Text = "Add Category";

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // ApplyTheme method
        public void ApplyTheme(bool isDark)
        {
            Color back = isDark ? Color.FromArgb(0, 95, 106) : Color.FromArgb(197, 229, 245);
            Color fore = isDark ? Color.White : Color.Black;

            this.BackColor = back;
            lblName.ForeColor = fore;
            txtName.BackColor = Color.White;
            txtName.ForeColor = Color.Black;
            btnAdd.BackColor = back;
            btnAdd.ForeColor = fore;
        }
        #endregion
        private Label lblName;
        private TextBox txtName;
        private Button btnAdd;
    }
}