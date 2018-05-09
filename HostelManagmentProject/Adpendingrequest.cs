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
    public partial class Adpendingrequest : Form
    {
        public Adpendingrequest()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            BindingSource s = new BindingSource();
            s.DataSource = sc.registeredstudent();
            gvpendingrequest.DataSource = s;
            gvpendingrequest.Columns[1].Visible = false;
            gvpendingrequest.Columns[2].Visible = false;
            gvpendingrequest.Columns[3].Visible = false;
            gvpendingrequest.Columns[4].Visible = false;
            gvpendingrequest.Columns[5].Visible = false;
            gvpendingrequest.Columns[6].Visible = false;
            gvpendingrequest.Columns[7].Visible = false;
            gvpendingrequest.Columns[8].Visible = false;
            gvpendingrequest.Columns[9].Visible = false;
            gvpendingrequest.Columns[11].Visible = false;
            gvpendingrequest.Columns[12].Visible = false;
            gvpendingrequest.Columns[13].Visible = false;
            gvpendingrequest.Columns[15].Visible = false;
            gvpendingrequest.Columns[16].Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox86_TextChanged(object sender, EventArgs e)
        {

        }

        private void registeredStudentsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void registeredStudentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gvpendingrequest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            bool specifie = true;
            if (e.ColumnIndex == 0)
            {
                localhost.Cstudent student1 = sc.getregisteredstudent(e.RowIndex, specifie);
                adpendingprofile ad = new adpendingprofile(student1);
                ad.Show();
                this.Hide();
            }
                
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registeredStudentsToolStripMenuItem_Click_2(object sender, EventArgs e)
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

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            adshowhostels a = new adshowhostels();
            a.Show();
            this.Hide();
        }

        private void messBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage m = new MainPage();
            m.Show();
            this.Hide();
        }

        private void pendingStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void complaintsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Adcomplaintsread ad = new Adcomplaintsread();
            ad.Show();
            this.Hide();
        }
    }
}
