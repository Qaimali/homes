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
    public partial class adrromallotment : Form
    {
        private localhost.Cstudent stud; 
        public adrromallotment()
        {
            InitializeComponent();
        }
        public adrromallotment(localhost.Cstudent stu)
        {
            InitializeComponent();
            stud = stu;
        }
        private void adrromallotment_Load(object sender, EventArgs e)
        {
            txtregistrationnumber.Text = stud.RegistrationNumber;
            localhost.Service1 sc = new localhost.Service1();
            foreach(localhost.Hostel hos in sc.showallhostel())
            {
                combolistofhostels.Items.Add(hos.HostelName);
            }
        }

        private void combolistofhostels_SelectedIndexChanged(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            
            foreach (localhost.Hostel hos in sc.showallhostel())
            {
                if (combolistofhostels.GetItemText(combolistofhostels.SelectedItem) == hos.HostelName)
                {
                    
                    for(int i = 0; i < hos.Roomlist.Count(); i++)
                    {
                        if (hos.Roomlist[i].Allotees < hos.Roomlist[i].Capacity)
                        {
                            combolistofrooms.Items.Add(hos.Roomlist[i].Roomnumber);
                        }
                    }
                }
            }
            

        }

        private void combolistofrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmdallot_Click(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            stud.HostelName = combolistofhostels.Text;
            stud.RoomNumber = combolistofrooms.Text;
            string c = "you are most wellcomed to HOMES Your hotel name is " + stud.HostelName + "& room number is " + stud.RoomNumber;
            sc.allotstudent(stud);
            sc.addnotificationforsearch(stud.Name, stud.RegistrationNumber, c);
            sc.deletependingst(stud);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adpendingprofile adp = new adpendingprofile(stud);
            adp.Show();
            this.Hide();
        }
    }
}
