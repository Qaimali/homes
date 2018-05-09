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
   
    public partial class adpendingprofile : Form
    {
        private localhost.Cstudent studu;
        public adpendingprofile()
        {
            InitializeComponent();
        }
        public adpendingprofile(localhost.Cstudent st)
        {
            InitializeComponent();
            studu = st;
        }
        private void adpendingprofile_Load(object sender, EventArgs e)
        {
            txtstudentname.Text = studu.Name;
            txtgender.Text = studu.Gender;
            txtbllodgroup.Text = studu.BloodGroup;
            txtfathername.Text = studu.FatherName;
            txtfatherphone.Text = studu.FatherNumber;
            txtguardianname.Text = studu.GuardianName;
            txtguardianphone.Text = studu.GuardianNumber;
            txtaddress.Text = studu.Address;
            txtregistrtaionnumber.Text = studu.RegistrationNumber;
        }

        private void cmdallot_Click(object sender, EventArgs e)
        {
            adrromallotment adr = new adrromallotment(studu);
            adr.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Adpendingrequest adp = new Adpendingrequest();
            adp.Show();
            this.Hide();
        }
    }
}
