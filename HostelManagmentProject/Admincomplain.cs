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
    public partial class Admincomplain : Form
    {
        localhost.Complaints com = new localhost.Complaints();
        public Admincomplain()
        {
            InitializeComponent();
        }

        private void Admincomplain_Load(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            BindingSource su = new BindingSource();
            su.DataSource = sc.getComplainFromRt();
            GVRtcomplaints.DataSource = su;
        }

        private void GVRtcomplaints_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            bool comspecified = false;
            if (e.ColumnIndex == 0)
            {
                localhost.Complaints c = sc.getIndexedComplaintsFromRt(e.RowIndex, comspecified);
                adReadComplaints ad = new adReadComplaints(c);
                ad.Show();
                this.Hide();
            }
            
        }

        private void hostelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registeredStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdregisteredStudents ad = new AdregisteredStudents();
            ad.Show();
            this.Hide();
        }
    }
}
