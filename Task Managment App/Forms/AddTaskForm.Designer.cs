namespace Task_Managment_App.Forms
{
    partial class AddTaskForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private TextBox txtTitle;
        private Label lblDesc;
        private TextBox txtDesc;
        private Label lblDueDate;
        private DateTimePicker dtpDueDate;
        private Label lblPriority;
        private ComboBox cbPriority;
        private Label lblStatus;
        private ComboBox cbStatus;
        private Label lblCategory;
        private ComboBox cbCategory;
        private Button btnAdd;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.lblTitle = new Label();
            this.txtTitle = new TextBox();
            this.lblDesc = new Label();
            this.txtDesc = new TextBox();
            this.lblDueDate = new Label();
            this.dtpDueDate = new DateTimePicker();
            this.lblPriority = new Label();
            this.cbPriority = new ComboBox();
            this.lblStatus = new Label();
            this.cbStatus = new ComboBox();
            this.lblCategory = new Label();
            this.cbCategory = new ComboBox();
            this.btnAdd = new Button();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Text = "Title:";

            // txtTitle
            this.txtTitle.Location = new System.Drawing.Point(120, 20);
            this.txtTitle.Width = 200;

            // lblDesc
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(20, 60);
            this.lblDesc.Text = "Description:";

            // txtDesc
            this.txtDesc.Location = new System.Drawing.Point(120, 60);
            this.txtDesc.Width = 200;

            // lblDueDate
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Location = new System.Drawing.Point(20, 100);
            this.lblDueDate.Text = "Due Date:";

            // dtpDueDate
            this.dtpDueDate.Location = new System.Drawing.Point(120, 100);

            // lblPriority
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(20, 140);
            this.lblPriority.Text = "Priority:";

            // cbPriority
            this.cbPriority.Location = new System.Drawing.Point(120, 140);
            this.cbPriority.Width = 200;

            // lblStatus
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(20, 180);
            this.lblStatus.Text = "Status:";

            // cbStatus
            this.cbStatus.Location = new System.Drawing.Point(120, 180);
            this.cbStatus.Width = 200;

            // lblCategory
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(20, 220);
            this.lblCategory.Text = "Category:";

            // cbCategory
            this.cbCategory.Location = new System.Drawing.Point(120, 220);
            this.cbCategory.Width = 200;
            this.cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(120, 260);
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.Text = "Add Task";

            // AddTaskForm
            this.ClientSize = new System.Drawing.Size(400, 320);
            this.Controls.AddRange(new Control[] {
                lblTitle, txtTitle, lblDesc, txtDesc,
                lblDueDate, dtpDueDate, lblPriority, cbPriority,
                lblStatus, cbStatus, lblCategory, cbCategory, btnAdd
            });
            this.Name = "AddTaskForm";
            this.Text = "Add Task";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

