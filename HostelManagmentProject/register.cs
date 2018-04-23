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
            localhost.Service1 sc = new localhost.Service1();
            string st = "student";
            string admin = "admin";
            string rt = "rt";
            string gk = "gatekeeper";
            if (comboBox2.GetItemText(comboBox2.SelectedItem) == st)
            {
                sc.regst(txtusername.Text, txtpassword.Text, comboBox1.GetItemText(comboBox1.SelectedItem), txtanswer.Text);

                MessageBox.Show("Dear student you are signed up");
            }
            else if (comboBox2.GetItemText(comboBox2.SelectedItem) == admin)
            {
                sc.regadmin(txtusername.Text, txtpassword.Text, comboBox1.GetItemText(comboBox1.SelectedItem), txtanswer.Text);
                MessageBox.Show("admin you are registered");
            }
            else if (comboBox2.GetItemText(comboBox2.SelectedItem) == rt)
            {
                sc.regrt(txtusername.Text, txtpassword.Text, comboBox1.GetItemText(comboBox1.SelectedItem), txtanswer.Text);

                MessageBox.Show("rt you are registered");
            }
            else if (comboBox2.GetItemText(comboBox2.SelectedItem) == gk)
            {
                sc.reggk(txtusername.Text, txtpassword.Text, comboBox1.GetItemText(comboBox1.SelectedItem), txtanswer.Text);

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
