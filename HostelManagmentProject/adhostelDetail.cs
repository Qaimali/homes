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
  
    public partial class adhostelDetail : Form
    {
        private localhost.Hostel hosteld;
        public adhostelDetail()
        {
            InitializeComponent();
        }
        public adhostelDetail(localhost.Hostel hostel1)
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
            for (int i=0;i< hosteld.Roomlist.Count(); i++)
            {
                comboBox1.Items.Add(hosteld.Roomlist[i].Roomnumber);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adshowhostels s = new adshowhostels();
            s.Show();
            this.Hide();
        }

        private void gvgatekeeperlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gvrtlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adshowhostels ads = new adshowhostels();
            ads.Show();
            this.Hide();
        }
    }
}
