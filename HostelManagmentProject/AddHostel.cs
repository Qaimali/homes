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
    public partial class AddHostel : Form
    {
        public AddHostel()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddHostel_Load(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            comboIstRT.DataSource = sc.rtnames();
            comboIstRT.DisplayMember = "name";
            List<object> list = new List<object>();
            foreach (object o in comboIstRT.Items)
            {
                if (!list.Contains(o))
                {
                    list.Add(o);
                }
            }
            comboIstRT.DataSource = null;
            comboIstRT.Items.AddRange(list.ToArray());
            combo2ndRT.Items.AddRange(list.ToArray());
            comboIstGK.DataSource = sc.gknames();
            comboIstGK.DisplayMember = "name";
            List<object> listgk = new List<object>();
            foreach (object o in comboIstGK.Items)
            {
                if (!listgk.Contains(o))
                {
                    listgk.Add(o);
                }
            }
            comboIstGK.DataSource = null;
            comboIstGK.Items.AddRange(listgk.ToArray());
            combo2ndGK.Items.AddRange(listgk.ToArray());
        }
       

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt2ndrt.Text = combo2ndRT.GetItemText(combo2ndRT.SelectedItem);
        }

        private void comboIstRT_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt1strt.Text = comboIstRT.GetItemText(comboIstRT.SelectedItem);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localhost.Service1 sc = new localhost.Service1();
            bool yes=true;
            sc.addhostel(txthostelname.Text,int.Parse(txtroomcapacity.Text),yes,int.Parse(txtnoofrooms.Text),yes, txt1strt.Text, txt2ndrt.Text, txt1stGK.Text, txt2ndGK.Text);
        }

        private void messBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showhostels s = new showhostels();
            s.Show();
            this.Hide();
        }

        private void comboIstGK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt1stGK.Text = comboIstGK.GetItemText(comboIstGK.SelectedItem);
        }

        private void combo2ndGK_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt2ndGK.Text = combo2ndGK.GetItemText(combo2ndGK.SelectedItem);
        }
    }
}
