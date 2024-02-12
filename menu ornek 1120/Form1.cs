using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_ornek_1120
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.Show();

        }

        private void kapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }

        private void ogrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle();
            ogrenciEkle.Show();

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial Black", 12); 
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial Black", 22);
        }

        private void ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Arial Black", 15);
        }
    }
}
