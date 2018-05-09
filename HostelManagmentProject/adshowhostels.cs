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
    public partial class adshowhostels : Form
    {
        public adshowhostels()
        {
            InitializeComponent();
        }
        
        private void showhostels_Load(object sender, EventArgs e)
        {

            localhost.Service1 service = new localhost.Service1();
            BindingSource s = new BindingSource();
            s.DataSource = service.listOfAllHostel();
            GVshowhostels.DataSource = s;
            
            GVshowhostels.Columns[3].Visible = false;
            GVshowhostels.Columns[2].Visible = false;

        }

        private void GVshowhostels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            bool postspecified = true;
            if (e.ColumnIndex == 0)
            {
                localhost.Hostel hostelss = service.hostelIndex(e.RowIndex, postspecified);
                adhostelDetail hd = new adhostelDetail(hostelss);
                hd.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddHostel adh = new AddHostel();
            adh.Show();
            this.Hide();

        }
    }
}
