using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GorselProgramlamaProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BlogSayfası frm = new BlogSayfası();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kullanicilar frm = new kullanicilar();
            frm.Show();
        }

        private void Siparisler_Click(object sender, EventArgs e)
        {
            Siparisler frm = new Siparisler();
            frm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
