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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        

        private void cmdregister_Click(object sender, EventArgs e)
        {
            if (txtanswer.Text == "" || txtusername.Text == "" || txtpassword.Text == "" || comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Fill the Form Completely");
            }
            else if ((txtanswer.Text != "" && txtusername.Text != "" && txtpassword.Text != "" && comboBox1.Text != "" && comboBox2.Text != ""))
            {
                localhost.Service1 service = new localhost.Service1();
                string st = "student";
                string admin = "admin";
                string rt = "rt";
                string gk = "gatekeeper";
                if (comboBox2.GetItemText(comboBox2.SelectedItem) == st)
                {
                    bool student = true;
                    bool studentSpecified = true;
                    service.uniqueStudentid(txtusername.Text, out student, out studentSpecified);
                    if (student)
                    {
                        service.registerStudent(txtusername.Text, txtpassword.Text, comboBox1.GetItemText(comboBox1.SelectedItem), txtanswer.Text);
                        MessageBox.Show("Dear " + txtusername.Text + "  you are signed up");
                    }
                    else
                    {
                        MessageBox.Show("Username already exists .Please enter another username! ");
                    }
                                       
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == admin)
                {
                    service.registerAdmin(txtusername.Text, txtpassword.Text, comboBox1.GetItemText(comboBox1.SelectedItem), txtanswer.Text);
                    MessageBox.Show("admin " + txtusername.Text +" you are registered");
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == rt)
                {
                    service.registerRt(txtusername.Text, txtpassword.Text, comboBox1.GetItemText(comboBox1.SelectedItem), txtanswer.Text);

                    MessageBox.Show("rt  " + txtusername.Text + " you are registered");
                }
                else if (comboBox2.GetItemText(comboBox2.SelectedItem) == gk)
                {
                    service.registerGatekeeper(txtusername.Text, txtpassword.Text, comboBox1.GetItemText(comboBox1.SelectedItem), txtanswer.Text);
                    MessageBox.Show("Gatekeeper  " + txtusername.Text + "  you are registered");

                    MessageBox.Show("gk you are registered");
                }
                else
                {
                    MessageBox.Show("selectdesignation");
                }
                txtusername.Text = "";
                txtpassword.Text = "";
                txtanswer.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainPage log = new MainPage();
            log.Show();
            this.Hide();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
