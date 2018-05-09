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
            if (txtsubject.Text == "" || txtname.Text == "" || txthostel.Text == "" || txtcomplaint.Text == "")
            {
                MessageBox.Show("Fill the Form Completely");
            }
            else if (txtsubject.Text == "")
            {
                MessageBox.Show("Your Complain should have any Subject");
            }
            else if (txtcomplaint.Text == "")
            {
                MessageBox.Show("Your Complain text should not empty");
            }
            else if (txtsubject.Text == "" && txthostel.Text == "")
            {
                MessageBox.Show("Fill the Form Completely");
            }
            else
            {
                localhost.Service1 service = new localhost.Service1();
                service.complaintsfromRT(txtname.Text, txtsubject.Text, txtcomplaint.Text, txthostel.Text);
                txtsubject.Text = "";
                txtcomplaint.Text = "";
            }
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
            localhost.CRT rtP = new localhost.CRT();
            rtP = sc.loggedRt();
            foreach (localhost.CRT rtO in sc.listOfallotedRT())
            {
                if (rtO.Name == rtP.Name)
                {
                    txthostel.Text = rtO.AllotedHostel;
                    txtname.Text = rtO.Name;
                }
            }
        }
    }
}
