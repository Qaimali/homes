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
            gvrtlist.Columns[1].Visible = false;
            gvrtlist.Columns[4].Visible = false;
            BindingSource si = new BindingSource();
            si.DataSource = hosteld.GatekeeperList;
            gvgatekeeperlist.DataSource = si;
            gvgatekeeperlist.Columns[0].Visible = false;
            gvgatekeeperlist.Columns[1].Visible = false;
            gvgatekeeperlist.Columns[3].Visible = false;
            gvgatekeeperlist.Columns[4].Visible = false;
            localhost.Service1 service = new localhost.Service1();
            foreach (localhost.CRT rt in service.listOfavailableRT())
            {
                comboBox1.Items.Add(rt.Name);
            }
            foreach (localhost.Cgatek keeper in service.listOfavailableGateKeeper())
            {
                comboBox2.Items.Add(keeper.Name);
            }


        }
        public void load()
        {
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 source = new localhost.Service1();
            hosteld=source.AddNewRT(hosteld, comboBox1.Text);
            BindingSource s = new BindingSource();
            s.DataSource = hosteld.RtList;
            gvrtlist.DataSource = s;
            gvrtlist.Columns[0].Visible = false;
            gvrtlist.Columns[3].Visible = false;
            gvrtlist.Columns[1].Visible = false;
            gvrtlist.Columns[4].Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            localhost.Service1 source = new localhost.Service1();
            hosteld = source.AddNewGateKeeper(hosteld, comboBox2.Text);
            BindingSource si = new BindingSource();
            si.DataSource = hosteld.GatekeeperList;
            gvgatekeeperlist.DataSource = si;
            gvgatekeeperlist.Columns[0].Visible = false;
            gvgatekeeperlist.Columns[3].Visible = false;
            gvgatekeeperlist.Columns[2].Visible = false;
            
        }
    }
}
