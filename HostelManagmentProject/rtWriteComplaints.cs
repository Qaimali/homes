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
    public partial class rtWriteComplaints : Form
    {
        public rtWriteComplaints()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            sc.complaintsfromRT(txtname.Text, txtsubject.Text, txtcomplaint.Text, txthostel.Text);
        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtNotifications rt = new rtNotifications();
            rt.Show();
            this.Hide();
        }

        private void compliantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtReceievedComplaints rt = new rtReceievedComplaints();
            rt.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }

        private void rtWriteComplaints_Load(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            localhost.CRT cs = new localhost.CRT();
            cs = sc.loggedRt();
            foreach (localhost.CRT su in sc.allotedRT())
            {
                if (su.Name == cs.Name)
                {
                    txthostel.Text = su.AllotedHostel;
                    txtname.Text = su.Name;
                }
            }
        }
    }
}
