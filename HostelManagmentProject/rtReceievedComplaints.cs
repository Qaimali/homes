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
            localhost.Service1 sc = new localhost.Service1();
            BindingSource s = new BindingSource();
            s.DataSource = null;
            GVRtcomplaints.DataSource = s;
            BindingSource su = new BindingSource();
            localhost.CRT rt = new localhost.CRT();
            rt = sc.loggedRt();
            foreach (localhost.CRT si in sc.allotedRT())
            {
                if (si.AllotedHostel == rt.AllotedHostel)
                {
                    txthostelName.Text = si.AllotedHostel;
                    su.DataSource = si.ComplaintsforRT;
                    GVRtcomplaints.DataSource = su;
                    temprt.ComplaintsforRT = si.ComplaintsforRT;
                    GVRtcomplaints.Columns[1].Visible = false;
                    GVRtcomplaints.Columns[3].Visible = false;
                    GVRtcomplaints.Columns[4].Visible = false;
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
            localhost.Service1 sc = new localhost.Service1();
            if (e.ColumnIndex == 0)
            {
                rtReadCompliants read = new rtReadCompliants(temprt.ComplaintsforRT[e.RowIndex]);
                read.Show();
                this.Hide();
            }
        }
    }
}
