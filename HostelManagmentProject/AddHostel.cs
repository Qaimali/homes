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
    public partial class AddHostel : Form
    {
        public AddHostel()
        {
            InitializeComponent();
        }
       
        
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddHostel_Load(object sender, EventArgs e)
        {

            localhost.Service1 service = new localhost.Service1();
            foreach (localhost.CRT rt in service.listOfavailableRT())
            {
                comboIstRT.Items.Add(rt.Name);
            }

            foreach (localhost.Cgatek keeper in service.listOfavailableGateKeeper())
            {
                comboIstGK.Items.Add(keeper.Name);
            }

        }
        public void load()
        {
            
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void comboIstRT_SelectedIndexChanged(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            txt1strt.Text = comboIstRT.GetItemText(comboIstRT.SelectedItem);
            comboIstRT.Items.Remove(txt1strt.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool yes = true;
            int p = 0;
            if (txthostelname.Text == "")
            {
                MessageBox.Show("Enter Hostel Name");
            }
            else if (int.TryParse(txtnoofrooms.Text, out p) == false)
            {
                MessageBox.Show("enter correct number of Rooms");
            }
            else if (int.TryParse(txtroomcapacity.Text, out p) == false)
            {
                MessageBox.Show("enter correct number of Capacity");
            }
            else if (int.TryParse(txtroomcapacity.Text, out p) && (int.TryParse(txtnoofrooms.Text, out p) && txthostelname.Text != ""))
            {
                localhost.Service1 sc = new localhost.Service1();

                sc.addhostel(txthostelname.Text, int.Parse(txtroomcapacity.Text), yes, int.Parse(txtnoofrooms.Text), yes, txt1strt.Text, txt1stGK.Text);

                MessageBox.Show("Hostel Is added To xxxx");
                txthostelname.Text = "";
                txtroomcapacity.Text = "";
                txtnoofrooms.Text = "";
                txt1strt.Text = "";
                txt1stGK.Text = "";
            }
            else
            {
                MessageBox.Show("Fill the Form Completly");
            }
        }

        private void messBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mp =new MainPage();
            mp.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adshowhostels s = new adshowhostels();
            s.Show();
            this.Hide();
        }

        private void comboIstGK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt1stGK.Text = comboIstGK.GetItemText(comboIstGK.SelectedItem);
        }

        private void combo2ndGK_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void registeredStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdregisteredStudents a = new AdregisteredStudents();
            this.Hide();
            a.Show();
        }

        private void pendingStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adpendingrequest adp = new Adpendingrequest();
            adp.Show();
            this.Hide();
        }

        private void hostelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdregisteredStudents adrs = new AdregisteredStudents();
            adrs.Show();
            this.Hide();
        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admincomplain a = new Admincomplain();
            a.Show();
            this.Hide();
        }

        private void studentsVistorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
