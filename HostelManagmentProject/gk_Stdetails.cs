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
    public partial class gk_Stdetails : Form
    {
        public gk_Stdetails()
        {
            InitializeComponent();
        }

        private void gk_Stcheckindetails_Load(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            localhost.Cgatek keeper = sc.logged_Gatekeeper();
            labelkeepername.Text = keeper.Name;
            labelhostelname.Text = keeper.AllotedHostel;
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
        private void visitorCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gk_Stvisitorscheckout gkco = new gk_Stvisitorscheckout();
            gkco.Show();
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
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gkNotifications gknot = new gkNotifications();
            gknot.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtStiname.Text == "" || txtstregno.Text == "" || txtstroomnu.Text == "")
            {
                MessageBox.Show("Fill the Search  Form Completly");
            }
            else if (txtStiname.Text != "" && txtstregno.Text != "" && txtstroomnu.Text != "")
            {
                localhost.Service1 service = new localhost.Service1();
                foreach (localhost.Cstudent student in service.listOfAllotedStudent())
                {
                    if (student.Name == txtStiname.Text && student.RegistrationNumber == txtstregno.Text && student.RoomNumber == txtstroomnu.Text)
                    {
                        BindingSource s = new BindingSource();
                        s.DataSource = student.Student_checkin;
                        gvvheckin.DataSource = s;
                        BindingSource si = new BindingSource();
                        si.DataSource = student.Student_checkout;

                        gvcheckout.DataSource = si;
                    }
                }
                txtStiname.Text = "";
                txtstregno.Text = "";
                txtstroomnu.Text = "";
            }
        }

        private void gvcheckout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void visitorCheckOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gk_Stvisitorscheckout gk = new gk_Stvisitorscheckout();
            gk.Show();
            this.Hide();
        }

        private void studentDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gk_Stdetails gk = new gk_Stdetails();
            gk.Show();
            this.Show();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            gkNotifications gk = new gkNotifications();
            gk.Show();
            this.Hide();
        }

        private void studentVisitorDetailToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            gk_StVisitorsDetails gk = new gk_StVisitorsDetails();
            gk.Show();
            this.Hide();
        }
    }
}
