using System;
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
    public partial class gk_StCheckin : Form
    {
        public gk_StCheckin()
        {
            InitializeComponent();
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

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentVisitorDetailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void gk_StCheckin_Load(object sender, EventArgs e)
        {

        }
    }
}
