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
    public partial class forgotpas : Form
    {
        public forgotpas()
        {
            InitializeComponent();
        }

        private void forgotpas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
            sc.canresetAdmin(txtusername.Text, comboquestion.GetItemText(comboquestion.SelectedItem), txtanswer.Text,txtnewpass.Text, out admin, out fail);
            sc.canresetgatekeeper(txtusername.Text, comboquestion.GetItemText(comboquestion.SelectedItem), txtanswer.Text,txtnewpass.Text, out gatekeeper, out notgk);
            sc.canresetstudent(txtusername.Text, comboquestion.GetItemText(comboquestion.SelectedItem), txtanswer.Text, txtnewpass.Text, out student, out notst);
            sc.canresetrt(txtusername.Text, comboquestion.GetItemText(comboquestion.SelectedItem), txtanswer.Text, txtnewpass.Text, out rt, out notrt);
            if (admin)
            {
                MessageBox.Show("welcocme admin new pass "+ txtnewpass.Text);
            }
            else if (student)
            {
                MessageBox.Show("welcocme student new pass" + txtnewpass.Text);
            }
            else if (rt)
            {
                MessageBox.Show("wellcocme RT new pass" + txtnewpass.Text);
            }
            else if (gatekeeper)
            {
                MessageBox.Show("wellcocme gatekeeper new pass" + txtnewpass.Text);
            }
            else
            {
                MessageBox.Show("invalid");
            }
        }
    }
}
