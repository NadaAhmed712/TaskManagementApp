namespace Task_Managment_App
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sidebarPanel = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnHome = new Button();
            btnLogin = new Button();
            btnTasks = new Button();
            btnCategories = new Button();
            btnCalendar = new Button();
            btnAddTask = new Button();
            btnAddCategory = new Button();
            btnChangeTheme = new Button();
            contentPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            sidebarPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = SystemColors.InactiveCaption;
            sidebarPanel.Controls.Add(tableLayoutPanel2);
            sidebarPanel.Dock = DockStyle.Fill;
            sidebarPanel.Location = new Point(3, 3);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(194, 444);
            sidebarPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Lavender;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnHome, 0, 0);
            tableLayoutPanel2.Controls.Add(btnLogin, 0, 1);
            tableLayoutPanel2.Controls.Add(btnTasks, 0, 2);
            tableLayoutPanel2.Controls.Add(btnCategories, 0, 3);
            tableLayoutPanel2.Controls.Add(btnCalendar, 0, 4);
            tableLayoutPanel2.Controls.Add(btnAddTask, 0, 5);
            tableLayoutPanel2.Controls.Add(btnAddCategory, 0, 6);
            tableLayoutPanel2.Controls.Add(btnChangeTheme, 0, 8);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 10;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel2.Size = new Size(194, 444);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Fill;
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(188, 38);
            btnHome.TabIndex = 0;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnLogin
            // 
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.Location = new Point(3, 47);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(188, 38);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnTasks
            // 
            btnTasks.Dock = DockStyle.Fill;
            btnTasks.Location = new Point(3, 91);
            btnTasks.Name = "btnTasks";
            btnTasks.Size = new Size(188, 38);
            btnTasks.TabIndex = 2;
            btnTasks.Text = "Tasks";
            btnTasks.UseVisualStyleBackColor = true;
            btnTasks.Click += btnTasks_Click;
            // 
            // btnCategories
            // 
            btnCategories.Dock = DockStyle.Fill;
            btnCategories.Location = new Point(3, 135);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(188, 38);
            btnCategories.TabIndex = 3;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = true;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnCalendar
            // 
            btnCalendar.Dock = DockStyle.Fill;
            btnCalendar.Location = new Point(3, 179);
            btnCalendar.Name = "btnCalendar";
            btnCalendar.Size = new Size(188, 38);
            btnCalendar.TabIndex = 4;
            btnCalendar.Text = "Calendar";
            btnCalendar.UseVisualStyleBackColor = true;
            btnCalendar.Click += btnCalendar_Click;
            // 
            // btnAddTask
            // 
            btnAddTask.Dock = DockStyle.Fill;
            btnAddTask.Location = new Point(3, 223);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(188, 38);
            btnAddTask.TabIndex = 5;
            btnAddTask.Text = "Add Task";
            btnAddTask.UseVisualStyleBackColor = true;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Dock = DockStyle.Fill;
            btnAddCategory.Location = new Point(3, 267);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(188, 38);
            btnAddCategory.TabIndex = 6;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // btnChangeTheme
            // 
            btnChangeTheme.Dock = DockStyle.Fill;
            btnChangeTheme.Location = new Point(3, 355);
            btnChangeTheme.Name = "btnChangeTheme";
            btnChangeTheme.Size = new Size(188, 38);
            btnChangeTheme.TabIndex = 9;
            btnChangeTheme.Text = "Dark Mode";
            btnChangeTheme.UseVisualStyleBackColor = true;
            btnChangeTheme.Click += btnChangeTheme_Click;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = SystemColors.ButtonFace;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(203, 3);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(594, 444);
            contentPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel1.Controls.Add(sidebarPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(contentPanel, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            sidebarPanel.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebarPanel;
        private Panel contentPanel;
        public Panel ContentPanel => contentPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnHome;
        private Button btnLogin;
        private Button btnTasks;
        private Button btnCategories;
        private Button btnCalendar;
        private Button btnAddTask;
        private Button btnAddCategory;
        private Button btnChangeTheme;
    }
}
