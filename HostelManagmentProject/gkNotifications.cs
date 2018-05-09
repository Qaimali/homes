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
    public partial class gkNotifications : Form
    {
        public gkNotifications()
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

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gk_StCheckin gkin = new gk_StCheckin();
            gkin.Show();
            this.Hide();
        }

        private void visitorCheckInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gk_Stvisitorscheckin gkch = new gk_Stvisitorscheckin();
            gkch.Show();
            this.Hide();
        }

        private void gkNotifications_Load(object sender, EventArgs e)
        {
            localhost.Service1 service=new localhost.Service1();
            localhost.Cgatek cg = new localhost.Cgatek();
            cg = service.logged_Gatekeeper();
            BindingSource s = new BindingSource();
            s.DataSource = cg.Notificationlist;
            GVgkNotifications.DataSource = s;
            localhost.Service1 sc = new localhost.Service1();
            localhost.Cgatek keeper = sc.logged_Gatekeeper();
            labelkeepername.Text = keeper.Name;
            labelhostelname.Text = keeper.AllotedHostel;

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void studentVisitorDetailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gk_StVisitorsDetails gk = new gk_StVisitorsDetails();
            gk.Show();
            this.Hide();
        }
    }
}
