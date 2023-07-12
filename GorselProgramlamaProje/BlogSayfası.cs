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
    public partial class BlogSayfası : Form
    {
        public BlogSayfası()
        {
            InitializeComponent();
        }
        private void VerileriListele()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=WebSitesiProje;Integrated Security=True");
            string sorgu = "select BlogIcerik.ID,BlogKategoriID.KategoriAdi,BlogIcerik.Baslik,BlogIcerik.Icerik,BlogIcerik.Data,BlogIcerik.Resim,BlogIcerik.Ozet from BlogKategoriID INNER JOIN BlogIcerik ON BlogIcerik.KategoriID = BlogKategoriID.ID";
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, Baglanti);
            DataTable tablo = new DataTable();
            adp.Fill(tablo);
            dataGridView1.DataSource = tablo;
        }

        private void Guncelleme()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=WebSitesiProje;Integrated Security=True");
            string sorgu = "Update BlogIcerik set KategoriID = @KategoriID, Icerik = @Icerik, Baslik = @Baslik, Data = @Data, Resim = @Resim, Ozet = @Ozet where ID = @ID";

            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@KategoriID", KategorilerCb.SelectedValue);
            cmd.Parameters.AddWithValue("@Baslik", textBox2.Text);
            cmd.Parameters.AddWithValue("@Icerik", textBox3.Text);
            cmd.Parameters.AddWithValue("@Data", textBox4.Text);
            cmd.Parameters.AddWithValue("@Resim", textBox5.Text);
            cmd.Parameters.AddWithValue("@Ozet", textBox6.Text);

            Baglanti.Open();
            cmd.ExecuteNonQuery();
            Baglanti.Close();
            
        }

        private void BlogSayfası_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'webSitesiProjeDataSet7.BlogKategoriID' table. You can move, or remove it, as needed.
            this.blogKategoriIDTableAdapter.Fill(this.webSitesiProjeDataSet7.BlogKategoriID);
            VerileriListele();
        }

        private void UrunEkle()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=WebSitesiProje;Integrated Security=True");
            string sorgu = "INSERT INTO BlogIcerik (KategoriID, Baslik, Icerik, Data,Resim,Ozet) VALUES (@KategoriID, @Baslik, @Icerik, @Data, @Resim,@Ozet)";

            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            cmd.Parameters.AddWithValue("@KategoriID", KategorilerCb.SelectedValue);
            cmd.Parameters.AddWithValue("@Baslik", textBox2.Text);
            cmd.Parameters.AddWithValue("@Icerik", textBox3.Text);
            cmd.Parameters.AddWithValue("@Data", textBox4.Text);
            cmd.Parameters.AddWithValue("@Resim", textBox5.Text);
            cmd.Parameters.AddWithValue("@Ozet", textBox6.Text);


            Baglanti.Open();
            cmd.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Başarıyla Eklendi");
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();//ID
            KategorilerCb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();//KategoriID
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();//Baslik
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();//Icerik
            
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();//data
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();//resim
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();//ozet
            

            //ÜrünAcıklamasi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();//UrunAciklamasi
        }

        private void Guncelle_Click(object sender, EventArgs e)
        {
            Guncelleme();
            VerileriListele();

        }

        private void Sil_()
        {
            SqlConnection Baglanti = new SqlConnection("Data Source=.;Initial Catalog=WebSitesiProje;Integrated Security=True");
            string sorgu = "DELETE FROM BlogIcerik WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sorgu, Baglanti);
            cmd.Parameters.AddWithValue("@ID", textBox1.Text);
            Baglanti.Open();
            cmd.ExecuteNonQuery();
            Baglanti.Close();
            MessageBox.Show("Silindi");
        }

        private void Ekle_Click(object sender, EventArgs e)
        {
            UrunEkle();
            VerileriListele();

        }


        private void Sil_Click(object sender, EventArgs e)
        {
            Sil_();
            VerileriListele();

        }
    }
}
