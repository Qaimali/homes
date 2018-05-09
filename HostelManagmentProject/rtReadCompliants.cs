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
    public partial class rtReadCompliants : Form
    {
        localhost.Complaints curr = new localhost.Complaints();
        public rtReadCompliants()
        {
            InitializeComponent();
        }
        public rtReadCompliants(localhost.Complaints c)
        {
            InitializeComponent();
            curr = c;
        }
        private void rtReadCompliants_Load(object sender, EventArgs e)
        {
            txtname.Text = curr.Name;
            txthostel.Text = curr.Residencyofperson;
            txtsubject.Text = curr.ComplaintSubject;
            txtcomplaint.Text = curr.TextCompliants;
        }
    }
}
