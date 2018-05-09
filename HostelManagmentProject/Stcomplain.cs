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
    public partial class Stcomplain : Form
    {
        localhost.Cstudent cs;
        public Stcomplain()
        {
            InitializeComponent();
        }
        

        private void Form10_Load(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            
            cs = service.loggedstudent();
            foreach(localhost.Cstudent su in service.listOfAllotedStudent())
            {
                if (su.Userid == cs.Userid)
                {
                    txthostel.Text = su.HostelName;
                    txtname.Text = su.Name;
                    txtRoomNum.Text = su.RoomNumber;
                    txtregNum.Text = su.RegistrationNumber;
                    labelHostelname.Text = su.HostelName;
                    labelRoomNumber.Text = su.RoomNumber;
                    labelStudentName.Text = su.Name;
                    
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stnotification stn = new Stnotification();
            stn.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsubject.Text == "")
            {
                MessageBox.Show("Your Complain should have any Subject");
            }
            else if (txtcomplaint.Text == "")
            {
                MessageBox.Show("Your Complain text should not empty");
            }
            else if (txtsubject.Text == "" && txthostel.Text == "")
            {
                MessageBox.Show("Fill the Form Completely");
            }
            else if (txtsubject.Text == "" || txtname.Text == "" || txthostel.Text == "" || txtcomplaint.Text == "" || txtregNum.Text == "" || txtRoomNum.Text == "")
            {
                MessageBox.Show("Fill the Form Completely");
            }
            else
            {
                localhost.Service1 service = new localhost.Service1();
                service.complaintsfromstudent(txtname.Text, txtsubject.Text, txtcomplaint.Text, txthostel.Text, txtregNum.Text, txtRoomNum.Text);
                txtsubject.Text = "";
                txtcomplaint.Text = "";
            }
        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
