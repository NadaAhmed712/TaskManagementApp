namespace Task_Managment_App.Forms
{
    partial class TasksForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.ComboBox cbStatusFilter;
        private System.Windows.Forms.ComboBox cbPriorityFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnReport;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.cbStatusFilter = new System.Windows.Forms.ComboBox();
            this.cbPriorityFilter = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.SuspendLayout();

            // -------------------- dataGridViewTasks --------------------
            this.dataGridViewTasks.Location = new System.Drawing.Point(20, 70);
            this.dataGridViewTasks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dataGridViewTasks.ReadOnly = true;
            this.dataGridViewTasks.AllowUserToAddRows = false;
            this.dataGridViewTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTasks_CellClick);

            // Columns
            this.dataGridViewTasks.Columns.Add("Id", "Id");
            this.dataGridViewTasks.Columns["Id"].Visible = false;
            this.dataGridViewTasks.Columns.Add("Title", "Title");
            this.dataGridViewTasks.Columns.Add("Description", "Description");
            this.dataGridViewTasks.Columns.Add("DueDate", "Due Date");
            this.dataGridViewTasks.Columns.Add("Priority", "Priority");
            this.dataGridViewTasks.Columns.Add("Status", "Status");

            var editBtn = new DataGridViewButtonColumn();
            editBtn.Name = "EditBtn";
            editBtn.Text = "Edit";
            editBtn.UseColumnTextForButtonValue = true;

            var deleteBtn = new DataGridViewButtonColumn();
            deleteBtn.Name = "DeleteBtn";
            deleteBtn.Text = "Delete";
            deleteBtn.UseColumnTextForButtonValue = true;

            this.dataGridViewTasks.Columns.Add(editBtn);
            this.dataGridViewTasks.Columns.Add(deleteBtn);

            foreach (DataGridViewColumn col in this.dataGridViewTasks.Columns)
            {
                if (col.Name != "EditBtn" && col.Name != "DeleteBtn")
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                else
                    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            // -------------------- Filters --------------------
            this.cbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbPriorityFilter.DropDownStyle = ComboBoxStyle.DropDownList;

            // Position & Width as percentage
            int filterWidth = (int)(this.ClientSize.Width * 0.15);
            int filterHeight = 25;

            this.cbStatusFilter.Location = new System.Drawing.Point(20, 20);
            this.cbStatusFilter.Size = new System.Drawing.Size(filterWidth, filterHeight);
            this.cbStatusFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            this.cbPriorityFilter.Location = new System.Drawing.Point(180 + filterWidth, 20);
            this.cbPriorityFilter.Size = new System.Drawing.Size(filterWidth, filterHeight);
            this.cbPriorityFilter.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            this.txtSearch.Location = new System.Drawing.Point(320 + filterWidth * 2, 20);
            this.txtSearch.Size = new System.Drawing.Size((int)(this.ClientSize.Width * 0.2), filterHeight);
            this.txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            // -------------------- Buttons --------------------
            int btnWidth = 100, btnHeight = 25;
            this.btnAddTask.Location = new System.Drawing.Point(this.ClientSize.Width - 240, 20);
            this.btnAddTask.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnAddTask.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.Click += new EventHandler(this.btnAddTask_Click);

            this.btnReport.Location = new System.Drawing.Point(this.ClientSize.Width - 120, 20);
            this.btnReport.Size = new System.Drawing.Size(btnWidth, btnHeight);
            this.btnReport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            this.btnReport.Text = "Generate Report";
            this.btnReport.Click += new EventHandler(this.btnReport_Click);

            this.btnPrev.Location = new System.Drawing.Point(20, this.ClientSize.Height - 50);
            this.btnPrev.Size = new System.Drawing.Size(75, btnHeight);
            this.btnPrev.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.btnPrev.Text = "Prev";
            this.btnPrev.Click += new EventHandler(this.btnPrev_Click);

            this.btnNext.Location = new System.Drawing.Point(120, this.ClientSize.Height - 50);
            this.btnNext.Size = new System.Drawing.Size(75, btnHeight);
            this.btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new EventHandler(this.btnNext_Click);

            // -------------------- Form --------------------
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.AddRange(new Control[] {
        dataGridViewTasks, cbStatusFilter, cbPriorityFilter, txtSearch,
        btnPrev, btnNext, btnAddTask, btnReport
    });
            this.Text = "Tasks";
            this.Name = "TasksForm";

            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            // -------------------- Handle Resize --------------------
            this.Resize += TasksForm_Resize;
        }

        // Resize handler
        private void TasksForm_Resize(object sender, EventArgs e)
        {
            int filterWidth = (int)(this.ClientSize.Width * 0.15);
            int filterHeight = 25;

            cbStatusFilter.Size = new System.Drawing.Size(filterWidth, filterHeight);
            cbPriorityFilter.Size = new System.Drawing.Size(filterWidth, filterHeight);
            txtSearch.Size = new System.Drawing.Size((int)(this.ClientSize.Width * 0.2), filterHeight);

            btnAddTask.Location = new System.Drawing.Point(this.ClientSize.Width - 240, 20);
            btnReport.Location = new System.Drawing.Point(this.ClientSize.Width - 120, 20);

            dataGridViewTasks.Size = new System.Drawing.Size(this.ClientSize.Width - 40, this.ClientSize.Height - 120);
            btnPrev.Location = new System.Drawing.Point(20, this.ClientSize.Height - 50);
            btnNext.Location = new System.Drawing.Point(120, this.ClientSize.Height - 50);
        }

        
    }
}
