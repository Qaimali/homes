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
  
    public partial class hostelDetail : Form
    {
        private localhost.Hostel hosteld;
        public hostelDetail()
        {
            InitializeComponent();
        }
        public hostelDetail(localhost.Hostel hostel1)
        {
            InitializeComponent();
            hosteld = hostel1;
        }

        private void hostelDetail_Load(object sender, EventArgs e)
        {
            txthostelname.Text = hosteld.HostelName;
            txtnuofrooms.Text = Convert.ToString(hosteld.Roomlist.Count());
            BindingSource s = new BindingSource();
            s.DataSource = hosteld.RtList;
            gvrtlist.DataSource = s;
            gvrtlist.Columns[0].Visible = false;
            gvrtlist.Columns[3].Visible = false;
            BindingSource si = new BindingSource();
            si.DataSource = hosteld.GatekeeperList;
            gvgatekeeperlist.DataSource = si;
            gvgatekeeperlist.Columns[0].Visible = false;
            gvgatekeeperlist.Columns[3].Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showhostels s = new showhostels();
            s.Show();
            this.Hide();
        }
    }
}
