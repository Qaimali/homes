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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdlogin_Click(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            bool admin = true;
            bool fail = true;
            bool student = true;
            bool notst = true;
            bool rt = true;
            bool notrt = true;
            bool gatekeeper = true;
            bool notgk = true;
            sc.isGatekeeper(txtusername.Text, txtpassword.Text, out gatekeeper, out notgk);
            sc.isRT(txtusername.Text, txtpassword.Text, out rt, out notrt);
            sc.isAdmin(txtusername.Text, txtpassword.Text, out admin, out fail);
            sc.isStudent(txtusername.Text, txtpassword.Text, out student, out notst);
            if (admin)
            {
                MessageBox.Show("welcocme admin");
            }
            else if (student)
            {
                MessageBox.Show("welcocme student");
            }
            else if (rt)
            {
                MessageBox.Show("wellcocme RT");
            }
            else if (gatekeeper)
            {
                MessageBox.Show("wellcocme gatekeeper");
            }
            else
            {
                MessageBox.Show("welcocme in homes");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            forgotpas fog = new forgotpas();
            fog.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainPage log = new MainPage();
            log.Show();
            this.Hide();
        }
    }

}


