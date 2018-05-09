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
    public partial class adRegisteredStProfile : Form
    {
        private localhost.Cstudent studentO;
        public adRegisteredStProfile()
        {
            InitializeComponent();
        }
        public adRegisteredStProfile(localhost.Cstudent studentP)
        {
            InitializeComponent();
            studentO = studentP;
        }
        private void adRegisteredStProfile_Load(object sender, EventArgs e)
        {
            txtstudentname.Text = studentO.Name;
            txtgender.Text = studentO.Gender;
            txtbllodgroup.Text = studentO.BloodGroup;
            txtfathername.Text = studentO.FatherName;
            txtfatherphone.Text = studentO.FatherNumber;
            txtguardianname.Text = studentO.GuardianName;
            txtguardianphone.Text = studentO.GuardianNumber;
            txtaddress.Text = studentO.Address;
            txtregistrtaionnumber.Text = studentO.RegistrationNumber;
            txtHostel.Text = studentO.HostelName;
            txtroom.Text = studentO.RoomNumber;
            BindingSource source = new BindingSource();
            source.DataSource = studentO.Student_checkin;
            gvvheckin.DataSource = source;
            BindingSource source1 = new BindingSource();
            source1.DataSource = studentO.Student_checkout;
            gvcheckout.DataSource = source1;
            BindingSource source2 = new BindingSource();
            source2.DataSource = studentO.Visitors;
            gvvisitorsCheckIn.DataSource = source2;
            gvVisitorsCheckOut.DataSource = source2;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            sc.deleteAllotedStudent(studentO);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdregisteredStudents ad = new AdregisteredStudents();
            ad.Show();
            this.Hide();
        }
    }
}
