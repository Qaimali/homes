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
        localhost.Complaints complaints = new localhost.Complaints();
        public Admincomplain()
        {
            InitializeComponent();
        }
       

        private void Admincomplain_Load(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            BindingSource su = new BindingSource();
            su.DataSource = service.listOfComplainFromRt();
            GVRtcomplaints.DataSource = su;
            GVRtcomplaints.Columns[4].Visible = false;
            GVRtcomplaints.Columns[6].Visible = false;
            GVRtcomplaints.Columns[7].Visible = false;
        }
        public void load()
        {
            
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
            if (e.ColumnIndex == 1)
            {
                sc.deleteComplaintsfromRT(e.RowIndex, comspecified);
                BindingSource s = new BindingSource();
                s.DataSource = null;
                GVRtcomplaints.DataSource = s;
                BindingSource su = new BindingSource();
                su.DataSource = sc.listOfComplainFromRt();
                GVRtcomplaints.DataSource = su;

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

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentsVistorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddHostel ad = new AddHostel();
            ad.Show();
            this.Hide();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adshowhostels ad = new adshowhostels();
            ad.Show();
            this.Hide();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }

        private void messEnrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adpendingrequest ad = new Adpendingrequest();
            ad.Show();
            this.Hide();
        }

    }
}
