namespace HostelManagmentProject
{
    partial class adrromallotment
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
            this.txtregistrationnumber = new System.Windows.Forms.TextBox();
            this.combolistofhostels = new System.Windows.Forms.ComboBox();
            this.combolistofrooms = new System.Windows.Forms.ComboBox();
            this.cmdallot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip2.SuspendLayout();
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
            this.menuStrip2.TabIndex = 198;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem2.Text = "Admin";
            // 
            // txtregistrationnumber
            // 
            this.txtregistrationnumber.Location = new System.Drawing.Point(366, 105);
            this.txtregistrationnumber.Name = "txtregistrationnumber";
            this.txtregistrationnumber.Size = new System.Drawing.Size(122, 20);
            this.txtregistrationnumber.TabIndex = 199;
            // 
            // combolistofhostels
            // 
            this.combolistofhostels.FormattingEnabled = true;
            this.combolistofhostels.Location = new System.Drawing.Point(366, 167);
            this.combolistofhostels.Name = "combolistofhostels";
            this.combolistofhostels.Size = new System.Drawing.Size(121, 21);
            this.combolistofhostels.TabIndex = 0;
            this.combolistofhostels.SelectedIndexChanged += new System.EventHandler(this.combolistofhostels_SelectedIndexChanged);
            // 
            // combolistofrooms
            // 
            this.combolistofrooms.FormattingEnabled = true;
            this.combolistofrooms.Location = new System.Drawing.Point(366, 249);
            this.combolistofrooms.Name = "combolistofrooms";
            this.combolistofrooms.Size = new System.Drawing.Size(121, 21);
            this.combolistofrooms.TabIndex = 1;
            this.combolistofrooms.SelectedIndexChanged += new System.EventHandler(this.combolistofrooms_SelectedIndexChanged);
            // 
            // cmdallot
            // 
            this.cmdallot.Location = new System.Drawing.Point(385, 354);
            this.cmdallot.Name = "cmdallot";
            this.cmdallot.Size = new System.Drawing.Size(75, 23);
            this.cmdallot.TabIndex = 2;
            this.cmdallot.Text = "allot";
            this.cmdallot.UseVisualStyleBackColor = true;
            this.cmdallot.Click += new System.EventHandler(this.cmdallot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 203;
            this.label1.Text = "Registration Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 204;
            this.label2.Text = "List of vacant rooms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 205;
            this.label3.Text = "List of hostels";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(176, 364);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Go to Previous page";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // adrromallotment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 516);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdallot);
            this.Controls.Add(this.combolistofrooms);
            this.Controls.Add(this.combolistofhostels);
            this.Controls.Add(this.txtregistrationnumber);
            this.Controls.Add(this.menuStrip2);
            this.Name = "adrromallotment";
            this.Text = "adrromallotment";
            this.Load += new System.EventHandler(this.adrromallotment_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.TextBox txtregistrationnumber;
        private System.Windows.Forms.ComboBox combolistofhostels;
        private System.Windows.Forms.ComboBox combolistofrooms;
        private System.Windows.Forms.Button cmdallot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}