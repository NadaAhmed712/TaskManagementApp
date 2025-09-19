namespace Task_Managment_App.Forms
{
    partial class HomeForm
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

            this.lblTotalTasks = new Label();
            this.lblPendingTasks = new Label();
            this.lblInProgressTasks = new Label();
            this.lblCompletedTasks = new Label();
            this.SuspendLayout();

            // lblTotalTasks
            this.lblTotalTasks.AutoSize = true;
            this.lblTotalTasks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalTasks.Location = new System.Drawing.Point(20, 20);
            this.lblTotalTasks.Text = "Total Tasks: 0";

            // lblPendingTasks
            this.lblPendingTasks.AutoSize = true;
            this.lblPendingTasks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblPendingTasks.Location = new System.Drawing.Point(20, 50);
            this.lblPendingTasks.Text = "Pending: 0";

            // lblInProgressTasks
            this.lblInProgressTasks.AutoSize = true;
            this.lblInProgressTasks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblInProgressTasks.Location = new System.Drawing.Point(20, 80);
            this.lblInProgressTasks.Text = "In Progress: 0";

            // lblCompletedTasks
            this.lblCompletedTasks.AutoSize = true;
            this.lblCompletedTasks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular);
            this.lblCompletedTasks.Location = new System.Drawing.Point(20, 110);
            this.lblCompletedTasks.Text = "Completed: 0";

            // HomeForm
            this.Controls.Add(this.lblTotalTasks);
            this.Controls.Add(this.lblPendingTasks);
            this.Controls.Add(this.lblInProgressTasks);
            this.Controls.Add(this.lblCompletedTasks);

            this.Size = new System.Drawing.Size(600, 450);
            this.Name = "HomeForm";
            this.Text = "Home Dashboard";
            
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private Label lblTotalTasks;
        private Label lblPendingTasks;
        private Label lblInProgressTasks;
        private Label lblCompletedTasks;

    }

}