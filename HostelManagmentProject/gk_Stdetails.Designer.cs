namespace HostelManagmentProject
{
    partial class gk_Stdetails
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.checkInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorCheckInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitorCheckOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.studentVisitorDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip4 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.gvcheckout = new System.Windows.Forms.DataGridView();
            this.studentcheckoutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cstudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvvheckin = new System.Windows.Forms.DataGridView();
            this.studentcheckinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtStiname = new System.Windows.Forms.TextBox();
            this.txtstregno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.menuStrip5 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.txtstroomnu = new System.Windows.Forms.TextBox();
            this.labelkeepername = new System.Windows.Forms.Label();
            this.labelhostelname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.menuStrip3.SuspendLayout();
            this.menuStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvcheckout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentcheckoutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cstudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvvheckin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentcheckinBindingSource)).BeginInit();
            this.menuStrip5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkInToolStripMenuItem,
            this.checkOutToolStripMenuItem,
            this.visitorCheckInToolStripMenuItem,
            this.visitorCheckOutToolStripMenuItem,
            this.studentDetailToolStripMenuItem,
            this.toolStripMenuItem1,
            this.studentVisitorDetailToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 80);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip1.TabIndex = 561;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // checkInToolStripMenuItem
            // 
            this.checkInToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkInToolStripMenuItem.Name = "checkInToolStripMenuItem";
            this.checkInToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.checkInToolStripMenuItem.Text = "Check in";
            this.checkInToolStripMenuItem.Click += new System.EventHandler(this.checkInToolStripMenuItem_Click);
            // 
            // checkOutToolStripMenuItem
            // 
            this.checkOutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkOutToolStripMenuItem.Name = "checkOutToolStripMenuItem";
            this.checkOutToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.checkOutToolStripMenuItem.Text = "Check Out";
            this.checkOutToolStripMenuItem.Click += new System.EventHandler(this.checkOutToolStripMenuItem_Click);
            // 
            // visitorCheckInToolStripMenuItem
            // 
            this.visitorCheckInToolStripMenuItem.Name = "visitorCheckInToolStripMenuItem";
            this.visitorCheckInToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.visitorCheckInToolStripMenuItem.Text = "Visitor Check In";
            this.visitorCheckInToolStripMenuItem.Click += new System.EventHandler(this.visitorCheckInToolStripMenuItem_Click);
            // 
            // visitorCheckOutToolStripMenuItem
            // 
            this.visitorCheckOutToolStripMenuItem.Name = "visitorCheckOutToolStripMenuItem";
            this.visitorCheckOutToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.visitorCheckOutToolStripMenuItem.Text = "Visitor Check Out";
            this.visitorCheckOutToolStripMenuItem.Click += new System.EventHandler(this.visitorCheckOutToolStripMenuItem_Click_1);
            // 
            // studentDetailToolStripMenuItem
            // 
            this.studentDetailToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentDetailToolStripMenuItem.Name = "studentDetailToolStripMenuItem";
            this.studentDetailToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.studentDetailToolStripMenuItem.Text = "Student Detail";
            this.studentDetailToolStripMenuItem.Click += new System.EventHandler(this.studentDetailToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 20);
            this.toolStripMenuItem1.Text = "Notifications";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // studentVisitorDetailToolStripMenuItem
            // 
            this.studentVisitorDetailToolStripMenuItem.Name = "studentVisitorDetailToolStripMenuItem";
            this.studentVisitorDetailToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.studentVisitorDetailToolStripMenuItem.Text = "Student Visitor Detail";
            this.studentVisitorDetailToolStripMenuItem.Click += new System.EventHandler(this.studentVisitorDetailToolStripMenuItem_Click_1);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1038, 24);
            this.menuStrip2.TabIndex = 560;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(79, 20);
            this.toolStripMenuItem2.Text = "GateKeeper";
            // 
            // menuStrip3
            // 
            this.menuStrip3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip3.AutoSize = false;
            this.menuStrip3.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3});
            this.menuStrip3.Location = new System.Drawing.Point(573, 269);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(368, 26);
            this.menuStrip3.TabIndex = 569;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(75, 22);
            this.toolStripMenuItem3.Text = "Check Out";
            // 
            // menuStrip4
            // 
            this.menuStrip4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip4.AutoSize = false;
            this.menuStrip4.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.menuStrip4.Location = new System.Drawing.Point(170, 269);
            this.menuStrip4.Name = "menuStrip4";
            this.menuStrip4.Size = new System.Drawing.Size(346, 26);
            this.menuStrip4.TabIndex = 568;
            this.menuStrip4.Text = "menuStrip4";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripMenuItem4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(65, 22);
            this.toolStripMenuItem4.Text = "Check In";
            // 
            // gvcheckout
            // 
            this.gvcheckout.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvcheckout.BackgroundColor = System.Drawing.Color.White;
            this.gvcheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvcheckout.Location = new System.Drawing.Point(573, 292);
            this.gvcheckout.Name = "gvcheckout";
            this.gvcheckout.Size = new System.Drawing.Size(368, 150);
            this.gvcheckout.TabIndex = 567;
            this.gvcheckout.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvcheckout_CellContentClick);
            // 
            // studentcheckoutBindingSource
            // 
            this.studentcheckoutBindingSource.DataMember = "Student_checkout";
            this.studentcheckoutBindingSource.DataSource = this.cstudentBindingSource;
            // 
            // cstudentBindingSource
            // 
            this.cstudentBindingSource.DataSource = typeof(HostelManagmentProject.localhost.Cstudent);
            // 
            // gvvheckin
            // 
            this.gvvheckin.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvvheckin.BackgroundColor = System.Drawing.Color.White;
            this.gvvheckin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvvheckin.Location = new System.Drawing.Point(170, 292);
            this.gvvheckin.Name = "gvvheckin";
            this.gvvheckin.Size = new System.Drawing.Size(346, 150);
            this.gvvheckin.TabIndex = 566;
            // 
            // studentcheckinBindingSource
            // 
            this.studentcheckinBindingSource.DataMember = "Student_checkin";
            this.studentcheckinBindingSource.DataSource = this.cstudentBindingSource;
            // 
            // txtStiname
            // 
            this.txtStiname.Location = new System.Drawing.Point(352, 173);
            this.txtStiname.Name = "txtStiname";
            this.txtStiname.Size = new System.Drawing.Size(200, 20);
            this.txtStiname.TabIndex = 0;
            // 
            // txtstregno
            // 
            this.txtstregno.Location = new System.Drawing.Point(741, 173);
            this.txtstregno.Name = "txtstregno";
            this.txtstregno.Size = new System.Drawing.Size(200, 20);
            this.txtstregno.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(570, 174);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 16);
            this.label12.TabIndex = 594;
            this.label12.Text = "Registration Number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(167, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 593;
            this.label11.Text = "Room Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(167, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 592;
            this.label8.Text = "Name";
            // 
            // menuStrip5
            // 
            this.menuStrip5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip5.AutoSize = false;
            this.menuStrip5.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip5.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5});
            this.menuStrip5.Location = new System.Drawing.Point(170, 127);
            this.menuStrip5.Name = "menuStrip5";
            this.menuStrip5.Size = new System.Drawing.Size(771, 26);
            this.menuStrip5.TabIndex = 598;
            this.menuStrip5.Text = "menuStrip5";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStripMenuItem5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(98, 22);
            this.toolStripMenuItem5.Text = "Student Details";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(813, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtstroomnu
            // 
            this.txtstroomnu.Location = new System.Drawing.Point(352, 221);
            this.txtstroomnu.Name = "txtstroomnu";
            this.txtstroomnu.Size = new System.Drawing.Size(200, 20);
            this.txtstroomnu.TabIndex = 2;
            // 
            // labelkeepername
            // 
            this.labelkeepername.AutoSize = true;
            this.labelkeepername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelkeepername.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelkeepername.Location = new System.Drawing.Point(531, 64);
            this.labelkeepername.Name = "labelkeepername";
            this.labelkeepername.Size = new System.Drawing.Size(18, 16);
            this.labelkeepername.TabIndex = 602;
            this.labelkeepername.Text = "**";
            // 
            // labelhostelname
            // 
            this.labelhostelname.AutoSize = true;
            this.labelhostelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhostelname.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelhostelname.Location = new System.Drawing.Point(179, 64);
            this.labelhostelname.Name = "labelhostelname";
            this.labelhostelname.Size = new System.Drawing.Size(18, 16);
            this.labelhostelname.TabIndex = 601;
            this.labelhostelname.Text = "**";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(35, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 600;
            this.label2.Text = "Hostel Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(388, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 599;
            this.label1.Text = "Name";
            // 
            // gk_Stdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 516);
            this.Controls.Add(this.labelkeepername);
            this.Controls.Add(this.labelhostelname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip5);
            this.Controls.Add(this.txtStiname);
            this.Controls.Add(this.txtstregno);
            this.Controls.Add(this.txtstroomnu);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.menuStrip4);
            this.Controls.Add(this.gvcheckout);
            this.Controls.Add(this.gvvheckin);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Name = "gk_Stdetails";
            this.Text = "gk_Stcheckdetails";
            this.Load += new System.EventHandler(this.gk_Stcheckindetails_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.menuStrip4.ResumeLayout(false);
            this.menuStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvcheckout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentcheckoutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cstudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvvheckin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentcheckinBindingSource)).EndInit();
            this.menuStrip5.ResumeLayout(false);
            this.menuStrip5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem checkInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorCheckInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitorCheckOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentVisitorDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.MenuStrip menuStrip4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.DataGridView gvcheckout;
        private System.Windows.Forms.DataGridView gvvheckin;
        private System.Windows.Forms.TextBox txtStiname;
        private System.Windows.Forms.TextBox txtstregno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MenuStrip menuStrip5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtstroomnu;
        private System.Windows.Forms.BindingSource studentcheckoutBindingSource;
        private System.Windows.Forms.BindingSource cstudentBindingSource;
        private System.Windows.Forms.BindingSource studentcheckinBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayOfWeekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayOfYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn millisecondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn minuteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ticksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOfDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelkeepername;
        private System.Windows.Forms.Label labelhostelname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}