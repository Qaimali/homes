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
        private localhost.Cstudent studentO; 
        public adrromallotment()
        {
            InitializeComponent();
        }
        public adrromallotment(localhost.Cstudent studentP)
        {
            InitializeComponent();
            studentO = studentP;
        }
        private void adrromallotment_Load(object sender, EventArgs e)
        {
            txtregistrationnumber.Text = studentO.RegistrationNumber;
            localhost.Service1 service = new localhost.Service1();
            foreach(localhost.Hostel hos in service.listOfAllHostel())
            {
                combolistofhostels.Items.Add(hos.HostelName);
            }
        }

        private void combolistofhostels_SelectedIndexChanged(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            
            foreach (localhost.Hostel hos in service.listOfAllHostel())
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
            if (combolistofhostels.Text == "")
            {
                MessageBox.Show("Select Any Hostel");
            }
            else if (combolistofrooms.Text == "")
            {
                MessageBox.Show("Select Any Room");
            }
            else
            {
                localhost.Service1 service = new localhost.Service1();
                studentO.HostelName = combolistofhostels.Text;
                studentO.RoomNumber = combolistofrooms.Text;
                string c = "you are most wellcomed to HOMES Your hotel name is " + studentO.HostelName + "& room number is " + studentO.RoomNumber;
                service.allotStudent(studentO);
                service.addnotificationforStudent(studentO.Name, studentO.RegistrationNumber, c);
                service.deletePendingStudent(studentO);
                MessageBox.Show("Room is Alloted to" + studentO.Name + "whose registration number is" + studentO.RegistrationNumber);
                combolistofrooms.Text = "";
                combolistofhostels.Text = "";
                txtregistrationnumber.Text = "";
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adpendingprofile adp = new adpendingprofile(studentO);
            adp.Show();
            this.Hide();
        }
    }
}
