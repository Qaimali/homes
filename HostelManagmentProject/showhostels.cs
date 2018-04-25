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
    public partial class showhostels : Form
    {
        public showhostels()
        {
            InitializeComponent();
        }

        private void showhostels_Load(object sender, EventArgs e)
        {

            localhost.Service1 sc = new localhost.Service1();
            BindingSource s = new BindingSource();
            s.DataSource = sc.showallhostel();
            GVshowhostels.DataSource = s;
            GVshowhostels.Columns[2].Visible = false;
            GVshowhostels.Columns[3].Visible = false;
        }

        private void GVshowhostels_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            bool postspecified = true;
            if (e.ColumnIndex == 0)
            {
                localhost.Hostel hostelss = sc.hostels(e.RowIndex, postspecified);
                hostelDetail hd = new hostelDetail(hostelss);
                hd.Show();
                this.Hide();
            }
        }
    }
}
