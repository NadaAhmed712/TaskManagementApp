using System;
using System.Drawing;
using System.Windows.Forms;

namespace Task_Managment_App.Forms
{
    partial class CalendarForm
    {
        private System.ComponentModel.IContainer components = null;
        private MonthCalendar monthCalendar;
        private ListBox lstTasks;
        private Label lblTasks;
        private Panel pnlTasks;
        private SplitContainer splitContainer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monthCalendar = new MonthCalendar();
            this.lstTasks = new ListBox();
            this.lblTasks = new Label();
            this.pnlTasks = new Panel();
            this.splitContainer = new SplitContainer();

            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();

            // ======= CalendarForm =======
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1000, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "📅 Calendar - Task Management";
            this.BackColor = Color.WhiteSmoke;
            this.MinimumSize = new Size(800, 500);

            // ======= splitContainer =======
            this.splitContainer.Dock = DockStyle.Fill;
            this.splitContainer.Orientation = Orientation.Vertical;
            this.splitContainer.SplitterDistance = 250; 
            this.splitContainer.IsSplitterFixed = false;

            // ======= monthCalendar =======
            this.monthCalendar.CalendarDimensions = new Size(1, 1); 
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.DateSelected += MonthCalendar_DateSelected;
            this.monthCalendar.Size = new Size(250, 200);
            this.monthCalendar.MinimumSize = new Size(250, 200);
            this.monthCalendar.MaximumSize = new Size(250, 200);
            this.monthCalendar.Location = new Point(20, 20);

            // Panel1 (Calendar)
            this.splitContainer.Panel1.BackColor = Color.WhiteSmoke;
            this.splitContainer.Panel1.Controls.Add(this.monthCalendar);

            // ======= pnlTasks =======
            this.pnlTasks.Dock = DockStyle.Fill;
            this.pnlTasks.BackColor = Color.White;
            this.pnlTasks.Padding = new Padding(20);
            this.pnlTasks.BorderStyle = BorderStyle.FixedSingle;

            // ======= lblTasks =======
            this.lblTasks.Text = "📌 Tasks for Selected Date";
            this.lblTasks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.lblTasks.Dock = DockStyle.Top;
            this.lblTasks.ForeColor = Color.DarkSlateGray;
            this.lblTasks.Height = 40;
            this.lblTasks.TextAlign = ContentAlignment.MiddleLeft;

            // ======= lstTasks =======
            this.lstTasks.Dock = DockStyle.Fill;
            this.lstTasks.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            this.lstTasks.BackColor = Color.WhiteSmoke;
            this.lstTasks.BorderStyle = BorderStyle.None;
            this.lstTasks.ItemHeight = 30;
            this.lstTasks.DrawMode = DrawMode.OwnerDrawFixed;
            this.lstTasks.DrawItem += (s, e) =>
            {
                if (e.Index < 0) return;
                e.DrawBackground();

                Color bgColor = (e.Index % 2 == 0) ? Color.AliceBlue : Color.White;
                using (SolidBrush b = new SolidBrush(bgColor))
                    e.Graphics.FillRectangle(b, e.Bounds);

                Rectangle textRect = new Rectangle(e.Bounds.X + 10, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height);

                string text = lstTasks.Items[e.Index].ToString();
                TextRenderer.DrawText(e.Graphics, "• " + text, lstTasks.Font,
                    textRect, Color.Black, TextFormatFlags.Left);

                e.DrawFocusRectangle();
            };

            // Panel2 (Tasks)
            this.pnlTasks.Controls.Add(this.lstTasks);
            this.pnlTasks.Controls.Add(this.lblTasks);
            this.splitContainer.Panel2.Controls.Add(this.pnlTasks);

            // Add controls to Form
            this.Controls.Add(this.splitContainer);

            // ======= Events to keep 25% / 75% =======
            this.Load += (s, e) =>
            {
                splitContainer.SplitterDistance = (int)(this.ClientSize.Width * 0.35);
            };
            this.Resize += (s, e) =>
            {
                splitContainer.SplitterDistance = (int)(this.ClientSize.Width * 0.35);
            };

            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion
    }
}

