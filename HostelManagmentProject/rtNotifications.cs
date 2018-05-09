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
    public partial class rtNotifications : Form
    {
        public rtNotifications()
        {
            InitializeComponent();
        }

        private void rtNotifications_Load(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            localhost.CRT rt = new localhost.CRT();
            rt = sc.loggedRt();
            BindingSource s = new BindingSource();
            s.DataSource = rt.Notificationlist;
            GVRtNotification.DataSource = s;
            
            foreach(localhost.CRT si in sc.allotedRT())
            {
                if(si.Name==rt.Name && si.AllotedHostel == rt.AllotedHostel)
                {
                    txthostelName.Text = si.AllotedHostel;
                }
                else
                {
                    txthostelName.Text = rt.AllotedHostel;
                }
            }
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void compliantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtReceievedComplaints co = new rtReceievedComplaints();
            co.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtWriteComplaints rt = new rtWriteComplaints();
            rt.Show();
            this.Hide();
        }
    }
}
