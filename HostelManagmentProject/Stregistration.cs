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
    public partial class Stregistration : Form
    {
        public Stregistration()
        {
            InitializeComponent();
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : ( screen.Width + Width ) / 2;

            int h = Height >= screen.Height ? screen.Height : ( screen.Height + Height ) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
                
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            localhost.Cstudent sttemp = new localhost.Cstudent();
            sttemp = sc.loggedstudent();
            txtuserid.Text = sttemp.Userid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            localhost.Cstudent stu = sc.loggedstudent();
            stu.Name = txtstudentname.Text;
            stu.PhoneNumber = txtphonenumber.Text;
            stu.RegistrationNumber = txtregistrtaionnumber.Text;
            stu.FatherName = txtfathername.Text;
            stu.FatherNumber = txtfatherphone.Text;
            stu.GuardianName = txtguardianname.Text;
            stu.GuardianNumber = txtguardianphone.Text;
            stu.Address = txtaddress.Text;
            stu.BloodGroup = txtbllodgroup.Text;
            if (chckmale.Checked)
            {
                stu.Gender = "male";
            }
            else if (chckfemale.Checked)
            {
                stu.Gender = "female";
            }
            else
            {
                MessageBox.Show("mark your gender");
            }            
            sc.registerforhostel(stu);
            StFormSubmission stf = new StFormSubmission();
            stf.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void chckfemale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtphonenumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtregistrtaionnumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfathername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtguardianname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbllodgroup_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtguardianphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfatherphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtstudentname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtuserid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
