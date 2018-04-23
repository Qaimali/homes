namespace HostelManagmentProject
{
    partial class rtNotifications
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.complaintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compliantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GVRtNotification = new System.Windows.Forms.DataGridView();
            this.menuStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVRtNotification)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip2.TabIndex = 503;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(96, 20);
            this.toolStripMenuItem2.Text = "Resident Tutor";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.complaintsToolStripMenuItem,
            this.compliantsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 61);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 30);
            this.menuStrip1.TabIndex = 519;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // complaintsToolStripMenuItem
            // 
            this.complaintsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.complaintsToolStripMenuItem.Name = "complaintsToolStripMenuItem";
            this.complaintsToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.complaintsToolStripMenuItem.Text = "Notication";
            this.complaintsToolStripMenuItem.Click += new System.EventHandler(this.complaintsToolStripMenuItem_Click);
            // 
            // compliantsToolStripMenuItem
            // 
            this.compliantsToolStripMenuItem.Name = "compliantsToolStripMenuItem";
            this.compliantsToolStripMenuItem.Size = new System.Drawing.Size(80, 26);
            this.compliantsToolStripMenuItem.Text = "Comlpaints";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // GVRtNotification
            // 
            this.GVRtNotification.AllowUserToOrderColumns = true;
            this.GVRtNotification.BackgroundColor = System.Drawing.Color.White;
            this.GVRtNotification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVRtNotification.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GVRtNotification.Location = new System.Drawing.Point(138, 118);
            this.GVRtNotification.Name = "GVRtNotification";
            this.GVRtNotification.RowHeadersWidth = 141;
            this.GVRtNotification.Size = new System.Drawing.Size(744, 364);
            this.GVRtNotification.TabIndex = 525;
            // 
            // rtNotifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 516);
            this.Controls.Add(this.GVRtNotification);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "rtNotifications";
            this.Text = "rtNotifications";
            this.Load += new System.EventHandler(this.rtNotifications_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVRtNotification)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem complaintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem compliantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.DataGridView GVRtNotification;
    }
}