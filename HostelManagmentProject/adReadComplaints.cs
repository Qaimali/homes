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
    public partial class adReadComplaints : Form
    {
        localhost.Complaints complaints=new localhost.Complaints();
        public adReadComplaints()
        {
            InitializeComponent();
        }
        public adReadComplaints(localhost.Complaints cs)
        {
            InitializeComponent();
            complaints = cs;
        }

        private void adReadComplaints_Load(object sender, EventArgs e)
        {
            txtcomplaint.Text = complaints.TextCompliants;
            txthostel.Text = complaints.Residencyofperson;
            txtname.Text = complaints.Name;
            txtsubject.Text = complaints.ComplaintSubject;
        }
    }
}
