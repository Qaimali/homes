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
    public partial class rtReceievedComplaints : Form
    {
        localhost.CRT temprt = new localhost.CRT();
        public rtReceievedComplaints()
        {
            InitializeComponent();
        }

        private void rtReceievedComplaints_Load(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            BindingSource s = new BindingSource();
            s.DataSource = null;
            GVRtcomplaints.DataSource = s;
            BindingSource su = new BindingSource();
            localhost.CRT rt = new localhost.CRT();
            rt = service.loggedRt();
            foreach (localhost.CRT rtO in service.listOfallotedRT())
            {
                if (rtO.AllotedHostel == rt.AllotedHostel)
                {
                    txthostelName.Text = rtO.AllotedHostel;
                    su.DataSource = rtO.ComplaintsforRT;
                    GVRtcomplaints.DataSource = su;
                    temprt.ComplaintsforRT = rtO.ComplaintsforRT;
                    GVRtcomplaints.Columns[5].Visible = false;
                    GVRtcomplaints.Columns[6].Visible = false;

                    GVRtcomplaints.Columns[7].Visible = false;
                }
                else
                {
                    txthostelName.Text = rt.AllotedHostel;
                    su.DataSource = null;
                    GVRtcomplaints.DataSource = su;
                }
            }
        }

        private void GVRtcomplaints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 sci = new localhost.Service1();
           
            if (e.ColumnIndex == 0)
            {
                rtReadCompliants read = new rtReadCompliants(temprt.ComplaintsforRT[e.RowIndex]);
                read.Show();
                this.Hide();
            }
            if (e.ColumnIndex == 1)
            {
                sci.deleteComplaintsfromStudents(temprt.ComplaintsforRT[e.RowIndex]);
                localhost.Service1 sc = new localhost.Service1();
                BindingSource s = new BindingSource();
                s.DataSource = null;
                GVRtcomplaints.DataSource = s;
                BindingSource su = new BindingSource();
                localhost.CRT rt = new localhost.CRT();
                rt = sc.loggedRt();
                foreach (localhost.CRT rtO in sc.listOfallotedRT())
                {
                    if (rtO.AllotedHostel == rt.AllotedHostel)
                    {
                        txthostelName.Text = rtO.AllotedHostel;
                        su.DataSource = rtO.ComplaintsforRT;
                        GVRtcomplaints.DataSource = su;
                        temprt.ComplaintsforRT = rtO.ComplaintsforRT;
                        GVRtcomplaints.Columns[2].Visible = false;
                        GVRtcomplaints.Columns[4].Visible = false;
                        GVRtcomplaints.Columns[5].Visible = false;
                    }
                    else
                    {
                        txthostelName.Text = rt.AllotedHostel;
                        su.DataSource = null;
                        GVRtcomplaints.DataSource = su;
                    }
                }

            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rtWriteComplaints rt = new rtWriteComplaints();
            rt.Show();
            this.Hide();
        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtNotifications gk = new rtNotifications();
            gk.Show();
            this.Hide();
        }

        private void compliantsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage gk = new MainPage();
            gk.Show();
            this.Hide();
        }
    }
}
