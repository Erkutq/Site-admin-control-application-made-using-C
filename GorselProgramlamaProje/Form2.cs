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
using System.Data.SqlTypes;

namespace GorselProgramlamaProje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'webSitesiProjeDataSet6.URUNLER' table. You can move, or remove it, as needed.
            this.uRUNLERTableAdapter1.Fill(this.webSitesiProjeDataSet6.URUNLER);
            // TODO: This line of code loads data into the 'webSitesiProjeDataSet2.UrunlerKategori' table. You can move, or remove it, as needed.
            this.urunlerKategoriTableAdapter.Fill(this.webSitesiProjeDataSet2.UrunlerKategori);
            // TODO: This line of code loads data into the 'webSitesiProjeDataSet1.URUNLER' table. You can move, or remove it, as needed.
            this.uRUNLERTableAdapter.Fill(this.webSitesiProjeDataSet1.URUNLER);
            VerileriListele();

        }
        private void VerileriListele()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=WebSitesiProje;Integrated Security=True");
            string sorgu = "select URUNLER.ID,URUNLER.ÜrünAdi,URUNLER.BirimFiyati,URUNLER.ÜrünKodu,UrunlerKategori.Kategori,URUNLER.UrunStok,URUNLER.UrunAciklamasi,UrunResim.Resim1,UrunResim.Resim2 from URUNLER INNER JOIN UrunlerKategori ON UrunlerKategori.ID = URUNLER.KategoriId INNER JOIN UrunResim ON UrunResim.ID = URUNLER.ID";
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, Baglanti);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }
        private void Guncelleme()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=WebSitesiProje;Integrated Security=True");
            string sorgu = "Update URUNLER set ÜrünAdi = @UrunAdi,BirimFiyati = @BirimFiyati, UrunAciklamasi = @UrunAciklamasi, KategoriId = @Kategori, UrunStok = @UrunStok where ID=@ID";

            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            cmd.Parameters.AddWithValue("@UrunAdi", UrunAdi.Text);
            cmd.Parameters.AddWithValue("@BirimFiyati", birimFiyati.Text);
            cmd.Parameters.AddWithValue("@UrunAciklamasi", ÜrünAcıklamasi.Text);
            cmd.Parameters.AddWithValue("@Kategori", Kategoriler.SelectedValue);
            cmd.Parameters.AddWithValue("@UrunStok", Convert.ToInt32(UrunStok.Text));
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox1.Text));



            //dataGridView1.CurrentRow.Cells[0].Value.ToString();//UrunAdi

            Baglanti.Open();
            cmd.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Güncellleme Yapıldı");
        }

        private void UrunEkleme()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=WebSitesiProje;Integrated Security=True");
            Baglanti.Open();
            string sorgu = "INSERT INTO URUNLER (ÜrünAdi, BirimFiyati, UrunAciklamasi, KategoriId, UrunStok,ÜrünKodu) VALUES (@ÜrünAdi, @BirimFiyati, @UrunAciklamasi, @KategoriId, @UrunStok,@ÜrünKodu)";

            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            cmd.Parameters.AddWithValue("@ÜrünAdi", UrunAdi.Text);
            cmd.Parameters.AddWithValue("@BirimFiyati", birimFiyati.Text);
            cmd.Parameters.AddWithValue("@UrunAciklamasi", ÜrünAcıklamasi.Text);
            cmd.Parameters.AddWithValue("@KategoriId", Kategoriler.SelectedValue);
            cmd.Parameters.AddWithValue("@UrunStok", Convert.ToInt32(UrunStok.Text));
            cmd.Parameters.AddWithValue("@ÜrünKodu", Convert.ToInt32(UrunKodu.Text));
            cmd.ExecuteNonQuery();

            string ResimEkle = "INSERT INTO UrunResim (Resim1, Resim2) VALUES (@Resim1, @Resim2)";
            SqlCommand cmd2 = new SqlCommand(ResimEkle,Baglanti);
            cmd2.Parameters.AddWithValue("@Resim1", textBox2.Text);
            cmd2.Parameters.AddWithValue("@Resim2", textBox3.Text);
            cmd2.ExecuteNonQuery();
            Baglanti.Close();

            MessageBox.Show("Ürün Eklendi");

        }



        private void Sil_()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=WebSitesiProje;Integrated Security=True");
            string sorgu = "DELETE FROM URUNLER WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(textBox1.Text));
            Baglanti.Open();
            cmd.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Silindi");
            VerileriListele();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//UrunAdi
            UrunAdi.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();//Birim Fİyati
            birimFiyati.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();//Birim Fİyati

            UrunKodu.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();//Urun Koud
            Kategoriler.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();//Kategori
            UrunStok.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();//Urun Stok
            ÜrünAcıklamasi.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();//UrunAciklamasi
            textBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();//UrunAciklamasi
            textBox3.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();//UrunAciklamasi



        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            Guncelleme();
            VerileriListele();

        }

        private void Sil_Click(object sender, EventArgs e)
        {
            Sil_();
            VerileriListele();

        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            UrunEkleme();
            VerileriListele();
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=WebSitesiProje;Integrated Security=True");
            Baglanti.Open();

            string ResimEkle = "INSERT INTO UrunResim (Resim1,Resim2) VALUES (@Resim1,@Resim2)";
            SqlCommand cmd2 = new SqlCommand(ResimEkle, Baglanti);
            cmd2.Parameters.AddWithValue("@Resim1", textBox2.Text);
            cmd2.Parameters.AddWithValue("@Resim2", textBox3.Text);


            cmd2.ExecuteNonQuery();
            Baglanti.Close();

        }

        private void Guncelle_Click_1(object sender, EventArgs e)
        {
            Guncelleme();
            VerileriListele();

        }

        private void Resim1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox2.Text = openFileDialog1.FileName;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog2.FileName;
            textBox3.Text = openFileDialog2.FileName;
        }
    }
}
