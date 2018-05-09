﻿using System;
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
        private localhost.Cstudent s;
        public adRegisteredStProfile()
        {
            InitializeComponent();
        }
        public adRegisteredStProfile(localhost.Cstudent stu)
        {
            InitializeComponent();
            s = stu;
        }
        private void adRegisteredStProfile_Load(object sender, EventArgs e)
        {
            txtstudentname.Text = s.Name;
            txtgender.Text = s.Gender;
            txtbllodgroup.Text = s.BloodGroup;
            txtfathername.Text = s.FatherName;
            txtfatherphone.Text = s.FatherNumber;
            txtguardianname.Text = s.GuardianName;
            txtguardianphone.Text = s.GuardianNumber;
            txtaddress.Text = s.Address;
            txtregistrtaionnumber.Text = s.RegistrationNumber;
            BindingSource source = new BindingSource();
            source.DataSource = s.Student_checkin;
            gvvheckin.DataSource = source;
            BindingSource source1 = new BindingSource();
            source1.DataSource = s.Student_checkout;
            gvcheckout.DataSource = source1;
            //BindingSource source2 = new BindingSource();
            //source2.DataSource = s.
            //gvvisitorsCheckIn.DataSource = source2;
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}