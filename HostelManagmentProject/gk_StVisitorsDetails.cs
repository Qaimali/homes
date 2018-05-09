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
    public partial class gk_StVisitorsDetails : Form
    {
        public gk_StVisitorsDetails()
        {
            InitializeComponent();
        }

        private void gk_StVisitorsDetails_Load(object sender, EventArgs e)
        {

        }
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gk_stcheckout gkc = new gk_stcheckout();
            gkc.Show();
            this.Hide();
        }

        private void visitorCheckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gk_Stvisitorscheckin gkch = new gk_Stvisitorscheckin();
            gkch.Show();
            this.Hide();
        }

        private void visitorCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gk_Stvisitorscheckout gkco = new gk_Stvisitorscheckout();
            gkco.Show();
            this.Hide();
        }

        private void studentDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gk_Stdetails gkc = new gk_Stdetails();
            gkc.Show();
            this.Hide();
        }

        private void studentVisitorDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gk_StVisitorsDetails gkvin = new gk_StVisitorsDetails();
            gkvin.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gkNotifications gknot = new gkNotifications();
            gknot.Show();
            this.Hide();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            foreach (localhost.Cstudent cs in sc.allotedStudentsforhostel())
            {
                if (cs.Name == txtStiname.Text && cs.RegistrationNumber == txtstregno.Text && cs.RoomNumber == txtstroomnu.Text)
                {
                    BindingSource s = new BindingSource();
                    s.DataSource = cs.Visitors;
                    gvvheckin.DataSource = s;
                    gvcheckout.DataSource = s;

                }
            }
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gk_StCheckin gk = new gk_StCheckin();
            gk.Show();
            this.Hide();
        }

        private void checkOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gk_stcheckout gk = new gk_stcheckout();
            gk.Show();
            this.Hide();
        }

        private void visitorCheckInToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gk_Stvisitorscheckin gk = new gk_Stvisitorscheckin();
            gk.Show();
            this.Hide();
        }

        private void visitorCheckOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gk_Stvisitorscheckout gk = new gk_Stvisitorscheckout();
            gk.Show();
            this.Hide();
        }

        private void studentDetailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gk_Stdetails gk = new gk_Stdetails();
            gk.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            gkNotifications gk = new gkNotifications();
            gk.Show();
            this.Hide();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MainPage gk = new MainPage();
            gk.Show();
            this.Hide();
        }
    }
}
