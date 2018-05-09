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
    public partial class gk_Stvisitorscheckout : Form
    {
        List<localhost.Cvisistor> checkedInVisitors = null;
        public gk_Stvisitorscheckout()
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
        private void visitorCheckOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gk_Stvisitorscheckout gkco = new gk_Stvisitorscheckout();
            gkco.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void gk_Stvisitorscheckout_Load(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            checkedInVisitors = new List<localhost.Cvisistor>();
            foreach (localhost.Cstudent studentO in service.listOfAllotedStudent())
            {
               foreach (localhost.Cvisistor visitorO in studentO.Visitors)
                    {
                        if (visitorO.CheckInbool)
                        {
                            checkedInVisitors.Add(visitorO);
                        }
                    }
            }
            BindingSource source = new BindingSource();
            source.DataSource = checkedInVisitors;
            dataGridView1.DataSource = source;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            localhost.Service1 sc = new localhost.Service1();
            localhost.Cgatek keeper = sc.logged_Gatekeeper();
            labelkeepername.Text = keeper.Name;
            labelhostelname.Text = keeper.AllotedHostel;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            checkedInVisitors = new List<localhost.Cvisistor>();
            foreach(localhost.Cstudent studentO in service.listOfAllotedStudent())
            {
                if(studentO.RegistrationNumber == txtstregno.Text)
                {
                    foreach (localhost.Cvisistor visitorO in studentO.Visitors)
                    {
                        if (visitorO.CheckInbool)
                        {
                            checkedInVisitors.Add(visitorO);
                        }
                    }
                }
            }
            BindingSource source = new BindingSource();
            source.DataSource = checkedInVisitors;
            dataGridView1.DataSource = source;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool visitorResult = true;
            bool visitorSpecified = true;
            localhost.Service1 service = new localhost.Service1();
            if (e.ColumnIndex == 0)
            {
                service.visitor_checkOut(txtstregno.Text, checkedInVisitors[e.RowIndex].Name, checkedInVisitors[e.RowIndex].Cnic, datetimeVcheckout.Text,out visitorResult,out visitorSpecified);
                if (visitorResult)
                {
                    MessageBox.Show("check out by" + checkedInVisitors[e.RowIndex].Name+"from homes");
                }
            }
        }
    }
}

