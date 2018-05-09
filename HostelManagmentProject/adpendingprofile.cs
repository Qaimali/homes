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
        private localhost.Cstudent studentO;
        public adpendingprofile()
        {
            InitializeComponent();
        }
        public adpendingprofile(localhost.Cstudent studentP)
        {
            InitializeComponent();
            studentO = studentP;
        }
        private void adpendingprofile_Load(object sender, EventArgs e)
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

        }
        public void load()
        {
            
        }

        private void cmdallot_Click(object sender, EventArgs e)
        {
            adrromallotment adr = new adrromallotment(studentO);
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
