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
    public partial class AdregisteredStudents : Form
    {
        public AdregisteredStudents()
        {
            InitializeComponent();
        }
       
        private void Form5_Load(object sender, EventArgs e)
        {
            localhost.Service1 service = new localhost.Service1();
            BindingSource s = new BindingSource();
            s.DataSource = service.listOfAllotedStudent();
            gvregisteredstudents.DataSource = s;
            gvregisteredstudents.Columns[1].Visible = false;
            gvregisteredstudents.Columns[2].Visible = false;
            gvregisteredstudents.Columns[3].Visible = false;
            gvregisteredstudents.Columns[4].Visible = false;
            gvregisteredstudents.Columns[5].Visible = false;
            gvregisteredstudents.Columns[6].Visible = false;
            gvregisteredstudents.Columns[7].Visible = false;
            gvregisteredstudents.Columns[8].Visible = false;
            gvregisteredstudents.Columns[9].Visible = false;
            gvregisteredstudents.Columns[10].Visible = false;
            gvregisteredstudents.Columns[14].Visible = false;
            gvregisteredstudents.Columns[17].Visible = false;
            gvregisteredstudents.Columns[13].Visible = false;

        }

        private void textBox127_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {

        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registeredStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentsVistorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddHostel ahd = new AddHostel();
            ahd.Show();
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            adshowhostels a = new adshowhostels();
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

        private void registeredStudentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void complaintsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Admincomplain a = new Admincomplain();
            a.Show();
            this.Hide();
        }

        private void gvregisteredstudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            bool postspecified = true;
            if (e.ColumnIndex == 0)
           {
                localhost.Cstudent registeredstudent = sc.indexForAllottedStudent(e.RowIndex, postspecified);
                adRegisteredStProfile a = new adRegisteredStProfile(registeredstudent);
                a.Show();
                this.Hide();
           }
        }
    }
}
