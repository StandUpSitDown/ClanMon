namespace ClanMon
{
    partial class frmClanMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClanMon));
            this.lblCpuReading = new System.Windows.Forms.Label();
            this.lblMemoryReading = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmenAppExit = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCpuReading
            // 
            this.lblCpuReading.AutoSize = true;
            this.lblCpuReading.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpuReading.Location = new System.Drawing.Point(13, 13);
            this.lblCpuReading.Name = "lblCpuReading";
            this.lblCpuReading.Size = new System.Drawing.Size(126, 19);
            this.lblCpuReading.TabIndex = 0;
            this.lblCpuReading.Text = "CPU Usage: 0%";
            // 
            // lblMemoryReading
            // 
            this.lblMemoryReading.AutoSize = true;
            this.lblMemoryReading.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoryReading.Location = new System.Drawing.Point(13, 55);
            this.lblMemoryReading.Name = "lblMemoryReading";
            this.lblMemoryReading.Size = new System.Drawing.Size(153, 19);
            this.lblMemoryReading.TabIndex = 1;
            this.lblMemoryReading.Text = "Memory Usage: 0%";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmenAppExit,
            this.aboutToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // tsmenAppExit
            // 
            this.tsmenAppExit.Name = "tsmenAppExit";
            this.tsmenAppExit.Size = new System.Drawing.Size(107, 22);
            this.tsmenAppExit.Text = "Exit";
            this.tsmenAppExit.Click += new System.EventHandler(this.tsmenAppExit_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmClanMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(185, 95);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lblMemoryReading);
            this.Controls.Add(this.lblCpuReading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(1450, 720);
            this.Name = "frmClanMon";
            this.Opacity = 0.5D;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ClanMon";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmClanMon_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmClanMon_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmClanMon_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCpuReading;
        private System.Windows.Forms.Label lblMemoryReading;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmenAppExit;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

