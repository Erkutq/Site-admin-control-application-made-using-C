using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace GorselProgramlamaProje
{
    public partial class Siparisler : Form
    {
        public Siparisler()
        {
            InitializeComponent();
        }

        private void Siparisler_Load(object sender, EventArgs e)
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=WebSitesiProje;Integrated Security=True");
            string sorgu = "select Kullanici.Adi,Kullanici.Soyadi,SUM(URUNLER.BirimFiyati) as Toplam_Odecegi_Tutar from URUNLER INNER JOIN Sepet ON URUNLER.ID = Sepet.UrunID INNER JOIN Kullanici ON Kullanici.ID = Sepet.KullaniciID GROUP BY Kullanici.Adi,Kullanici.Soyadi";
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, Baglanti);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
    }
}
