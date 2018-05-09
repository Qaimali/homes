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
    public partial class gk_Stvisitorscheckin : Form
    {
        public gk_Stvisitorscheckin()
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

        private void gk_Stvisitorscheckin_Load(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            localhost.Cgatek keeper = sc.logged_Gatekeeper();
            labelkeepername.Text = keeper.Name;
            labelhostelname.Text = keeper.AllotedHostel;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gkNotifications gknot = new gkNotifications();
            gknot.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if ( txtcnicvisitor.Text == "" || txtstregno.Text == ""  || txtViname.Text == "")
            {
                MessageBox.Show("Fill the Form Completely");
            }
            else if (txtcnicvisitor.Text != "" && txtstregno.Text != "" && txtViname.Text != "")
            {
                localhost.Service1 service = new localhost.Service1();
                bool st = false;
                bool sts = false;
                service.visitor_checkIn( txtstregno.Text, txtViname.Text, txtcnicvisitor.Text, datetimeVcheckin.Text,  out st, out sts);

                if (st)
                {
                    MessageBox.Show("submitted");
                }
                else
                {
                    MessageBox.Show("invlid information");
                }
               
                txtcnicvisitor.Text = "";
                txtstregno.Text = "";
                txtViname.Text = "";
            }
        }

        private void studentVisitorDetailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gk_StVisitorsDetails g = new gk_StVisitorsDetails();
            g.Show();
            this.Hide();
        }

        private void visitorCheckInToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
