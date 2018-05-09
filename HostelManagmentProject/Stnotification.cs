﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HostelManagmentProject
{
    public partial class Stnotification : Form
    {
        public Stnotification()
        {
            InitializeComponent();
        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stcomplain stc = new Stcomplain();
            stc.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Stnotification_Load(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            localhost.Cstudent studentP = new localhost.Cstudent();
            studentP = service.loggedstudent();
            txtstName.Text = studentP.Userid;
            BindingSource source = new BindingSource();
            source.DataSource = studentP.Notificationlist;
            GVstNotifications.DataSource = source;
            foreach (localhost.Cstudent student in service.listOfAllotedStudent())
            {
                if(student.Userid == studentP.Userid)
                {
                    source.DataSource = student.Notificationlist;
                    GVstNotifications.DataSource = source;
                    
                }
            }    
        }
    }
}
