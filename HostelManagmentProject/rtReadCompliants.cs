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
    public partial class rtReadCompliants : Form
    {
        localhost.Complaints curr = new localhost.Complaints();
        public rtReadCompliants()
        {
            InitializeComponent();
        }
        public rtReadCompliants(localhost.Complaints c)
        {
            InitializeComponent();
            curr = c;
        }
        private void rtReadCompliants_Load(object sender, EventArgs e)
        {
            txtname.Text = curr.Name;
            txthostel.Text = curr.Residencyofperson;
            txtsubject.Text = curr.ComplaintSubject;
            txtcomplaint.Text = curr.TextCompliants;
            localhost.Service1 service = new localhost.Service1();
            string not = "your complaints has been submitted .Soon we will take suitable actions";
            service.addnotificationforStudent(curr.Name, curr.RegistrationNumber, not);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtNotifications r = new rtNotifications();
            r.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtWriteComplaints gk = new rtWriteComplaints();
            gk.Show();
            this.Hide();
        }

        private void compliantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtReceievedComplaints gk = new rtReceievedComplaints();
            gk.Show();
            this.Hide();
        }
    }
}
