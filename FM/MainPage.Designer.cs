namespace FM
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trucksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterDailyInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLReportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.builtReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.dailyEntriesToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(640, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trucksToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.recordsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // trucksToolStripMenuItem
            // 
            this.trucksToolStripMenuItem.Name = "trucksToolStripMenuItem";
            this.trucksToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.trucksToolStripMenuItem.Text = "Trucks";
            this.trucksToolStripMenuItem.Click += new System.EventHandler(this.trucksToolStripMenuItem_Click);
            // 
            // dailyEntriesToolStripMenuItem
            // 
            this.dailyEntriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterDailyInfoToolStripMenuItem});
            this.dailyEntriesToolStripMenuItem.Name = "dailyEntriesToolStripMenuItem";
            this.dailyEntriesToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.dailyEntriesToolStripMenuItem.Text = "Daily Entries";
            // 
            // enterDailyInfoToolStripMenuItem
            // 
            this.enterDailyInfoToolStripMenuItem.Name = "enterDailyInfoToolStripMenuItem";
            this.enterDailyInfoToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.enterDailyInfoToolStripMenuItem.Text = "Enter Daily Info";
            this.enterDailyInfoToolStripMenuItem.Click += new System.EventHandler(this.enterDailyInfoToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // recordsToolStripMenuItem
            // 
            this.recordsToolStripMenuItem.Name = "recordsToolStripMenuItem";
            this.recordsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.recordsToolStripMenuItem.Text = "Records";
            this.recordsToolStripMenuItem.Click += new System.EventHandler(this.recordsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sQLReportingToolStripMenuItem,
            this.builtReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // sQLReportingToolStripMenuItem
            // 
            this.sQLReportingToolStripMenuItem.Name = "sQLReportingToolStripMenuItem";
            this.sQLReportingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sQLReportingToolStripMenuItem.Text = "SQL Reporting";
            this.sQLReportingToolStripMenuItem.Click += new System.EventHandler(this.sQLReportingToolStripMenuItem_Click);
            // 
            // builtReportsToolStripMenuItem
            // 
            this.builtReportsToolStripMenuItem.Name = "builtReportsToolStripMenuItem";
            this.builtReportsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.builtReportsToolStripMenuItem.Text = "Built Reports";
            this.builtReportsToolStripMenuItem.Click += new System.EventHandler(this.builtReportsToolStripMenuItem_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(640, 415);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPage";
            this.Text = "Fleet Tracking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterDailyInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trucksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sQLReportingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem builtReportsToolStripMenuItem;
    }
}