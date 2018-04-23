namespace HostelManagmentProject
{
    partial class showhostels
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
            ((System.ComponentModel.ISupportInitialize)(this.GVshowhostels)).BeginInit();
            this.SuspendLayout();
            // 
            // GVshowhostels
            // 
            this.GVshowhostels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVshowhostels.Location = new System.Drawing.Point(45, 100);
            this.GVshowhostels.Name = "GVshowhostels";
            this.GVshowhostels.Size = new System.Drawing.Size(698, 311);
            this.GVshowhostels.TabIndex = 0;
            // 
            // showhostels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 452);
            this.Controls.Add(this.GVshowhostels);
            this.Name = "showhostels";
            this.Text = "showahostels";
            this.Load += new System.EventHandler(this.showhostels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GVshowhostels)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GVshowhostels;
    }
}