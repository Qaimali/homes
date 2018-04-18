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
            
            
            sc.isAdmin(txtusername.Text, txtpassword.Text, out admin, out fail);
            if (admin)
            {
                MessageBox.Show("welcocme admin");
            }
            
            else
            {
                MessageBox.Show("Not Welcome in homes");
            }
         }
     }

  }
        
             
