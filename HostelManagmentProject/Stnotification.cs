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
    public partial class Stnotification : Form
    {
        public Stnotification()
        {
            InitializeComponent();
        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stcomplain stc = new Stcomplain();
            stc.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Stnotification_Load(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            localhost.Cstudent st = new localhost.Cstudent();
            st = sc.loggedstudent();
            txtstName.Text = st.Userid;
            BindingSource s = new BindingSource();
            s.DataSource = st.Notificationlist;
            GVstNotifications.DataSource = s;
            foreach (localhost.Cstudent csi in sc.allotedStudentsforhostel())
            {
                if(csi.Userid == st.Userid)
                {
                    s.DataSource = csi.Notificationlist;
                    GVstNotifications.DataSource = s;
                }
            }    
        }
    }
}
