namespace HostelManagmentProject
{
    partial class adshowhostels
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
            this.GVshowhostels = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GVshowhostels)).BeginInit();
            this.SuspendLayout();
            // 
            // GVshowhostels
            // 
            this.GVshowhostels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVshowhostels.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.GVshowhostels.Location = new System.Drawing.Point(45, 100);
            this.GVshowhostels.Name = "GVshowhostels";
            this.GVshowhostels.Size = new System.Drawing.Size(698, 311);
            this.GVshowhostels.TabIndex = 0;
            this.GVshowhostels.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GVshowhostels_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "See Details";
            this.Column1.Name = "Column1";
            this.Column1.Text = "Click Here";
            this.Column1.UseColumnTextForLinkValue = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(42, 472);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 13);
            this.linkLabel1.TabIndex = 202;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to Previous page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // adshowhostels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 516);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.GVshowhostels);
            this.Name = "adshowhostels";
            this.Text = "showahostels";
            this.Load += new System.EventHandler(this.showhostels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVshowhostels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GVshowhostels;
        private System.Windows.Forms.DataGridViewLinkColumn Column1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}