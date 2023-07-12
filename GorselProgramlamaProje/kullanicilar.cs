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
    public partial class kullanicilar : Form
    {
        public kullanicilar()
        {
            InitializeComponent();
        }

        private void kullanicilar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'webSitesiProjeDataSet8.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter1.Fill(this.webSitesiProjeDataSet8.Kullanici);
            // TODO: This line of code loads data into the 'webSitesiProjeDataSet5.Kullanici' table. You can move, or remove it, as needed.


        }
    }
}
