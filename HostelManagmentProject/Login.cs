using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

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
            bool hostelregistered = true;
            bool nothostelregistered = true;
            sc.isGatekeeper(txtusername.Text, txtpassword.Text, out gatekeeper, out notgk);
            sc.isRT(txtusername.Text, txtpassword.Text, out rt, out notrt);
            sc.isAdmin(txtusername.Text, txtpassword.Text, out admin, out fail);
            sc.isStudent(txtusername.Text, txtpassword.Text, out student, out notst);
            sc.isHostelRegistered(txtusername.Text, out hostelregistered, out nothostelregistered);
            if (txtusername.Text == "" )
            {
                MessageBox.Show("Enter User Name");
            }
            else if (txtusername.Text != "" || txtpassword.Text != "")
            {
                if (admin)
                {
                    MessageBox.Show("welcocme admin");
                    AddHostel sh = new AddHostel();
                    sh.Show();
                    this.Hide();
                }
                else if (student)
                {
                    if (hostelregistered)
                    {
                        MessageBox.Show("welcocme student");
                        Stnotification stn = new Stnotification();
                        stn.Show();
                        this.Hide();
                    }
                    else
                    {
                        Stregistration str = new Stregistration();
                        str.Show();
                        this.Hide();

                    }
                }
                else if (rt)
                {
                    MessageBox.Show("wellcocme RT");
                    rtNotifications rtn = new rtNotifications();
                    rtn.Show();
                    this.Hide();
                }
                else if (gatekeeper)
                {
                    MessageBox.Show("wellcocme gatekeeper");
                    gkNotifications gkn = new gkNotifications();
                    gkn.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("welcocme in homes");
                }
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
        //DataTable t = new DataTable();
        private void Login_Load(object sender, EventArgs e)
        {
            //t.Columns.Add("RT name", typeof(string));
            //dataGridView1.DataSource = t;
            
        }
        
    }

}


