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
    public partial class Adcomplaintsread : Form
    {
        public Adcomplaintsread()
        {
            InitializeComponent();
        }

        private void hostelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registeredStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdregisteredStudents a = new AdregisteredStudents();
            a.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            adshowhostels a = new adshowhostels();
            a.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            AdregisteredStudents a = new AdregisteredStudents();
            a.Show();
            this.Hide();
        }

        private void studentsVistorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddHostel a = new AddHostel();
            a.Show();
            this.Hide();
        }

        private void messBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage a = new MainPage();
            a.Show();
            this.Hide();
        }

        private void pendingStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adpendingrequest a = new Adpendingrequest();
            a.Show();
            this.Hide();
        }

        private void hostelApplicationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void Adcomplaintsread_Load(object sender, EventArgs e)
        {

        }
    }
}
