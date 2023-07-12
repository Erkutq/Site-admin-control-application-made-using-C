
namespace GorselProgramlamaProje
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label6 = new System.Windows.Forms.Label();
            this.ÜrünAcıklamasi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UrunStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Kategoriler = new System.Windows.Forms.ComboBox();
            this.urunlerKategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webSitesiProjeDataSet2 = new GorselProgramlamaProje.WebSitesiProjeDataSet2();
            this.label3 = new System.Windows.Forms.Label();
            this.birimFiyati = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UrunAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UrunKodu = new System.Windows.Forms.TextBox();
            this.uRUNLERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webSitesiProjeDataSet1 = new GorselProgramlamaProje.WebSitesiProjeDataSet1();
            this.uRUNLERTableAdapter = new GorselProgramlamaProje.WebSitesiProjeDataSet1TableAdapters.URUNLERTableAdapter();
            this.urunlerKategoriTableAdapter = new GorselProgramlamaProje.WebSitesiProjeDataSet2TableAdapters.UrunlerKategoriTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.webSitesiProjeDataSet6 = new GorselProgramlamaProje.WebSitesiProjeDataSet6();
            this.uRUNLERBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uRUNLERTableAdapter1 = new GorselProgramlamaProje.WebSitesiProjeDataSet6TableAdapters.URUNLERTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Sil = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.Guncelle = new System.Windows.Forms.Button();
            this.Resim1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerKategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSitesiProjeDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNLERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSitesiProjeDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSitesiProjeDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNLERBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Urun Açıklması";
            // 
            // ÜrünAcıklamasi
            // 
            this.ÜrünAcıklamasi.Location = new System.Drawing.Point(121, 347);
            this.ÜrünAcıklamasi.Name = "ÜrünAcıklamasi";
            this.ÜrünAcıklamasi.Size = new System.Drawing.Size(101, 22);
            this.ÜrünAcıklamasi.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Urun stok";
            // 
            // UrunStok
            // 
            this.UrunStok.Location = new System.Drawing.Point(121, 308);
            this.UrunStok.Name = "UrunStok";
            this.UrunStok.Size = new System.Drawing.Size(101, 22);
            this.UrunStok.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Kategoriler";
            // 
            // Kategoriler
            // 
            this.Kategoriler.DataSource = this.urunlerKategoriBindingSource;
            this.Kategoriler.DisplayMember = "Kategori";
            this.Kategoriler.FormattingEnabled = true;
            this.Kategoriler.Location = new System.Drawing.Point(121, 254);
            this.Kategoriler.Name = "Kategoriler";
            this.Kategoriler.Size = new System.Drawing.Size(101, 24);
            this.Kategoriler.TabIndex = 20;
            this.Kategoriler.ValueMember = "ID";
            // 
            // urunlerKategoriBindingSource
            // 
            this.urunlerKategoriBindingSource.DataMember = "UrunlerKategori";
            this.urunlerKategoriBindingSource.DataSource = this.webSitesiProjeDataSet2;
            // 
            // webSitesiProjeDataSet2
            // 
            this.webSitesiProjeDataSet2.DataSetName = "WebSitesiProjeDataSet2";
            this.webSitesiProjeDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Birim Fiyati";
            // 
            // birimFiyati
            // 
            this.birimFiyati.Location = new System.Drawing.Point(121, 194);
            this.birimFiyati.Name = "birimFiyati";
            this.birimFiyati.Size = new System.Drawing.Size(101, 22);
            this.birimFiyati.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Ürün Adi";
            // 
            // UrunAdi
            // 
            this.UrunAdi.Location = new System.Drawing.Point(121, 95);
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.Size = new System.Drawing.Size(101, 22);
            this.UrunAdi.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ürün Kodu";
            // 
            // UrunKodu
            // 
            this.UrunKodu.Location = new System.Drawing.Point(121, 144);
            this.UrunKodu.Name = "UrunKodu";
            this.UrunKodu.Size = new System.Drawing.Size(101, 22);
            this.UrunKodu.TabIndex = 14;
            // 
            // uRUNLERBindingSource
            // 
            this.uRUNLERBindingSource.DataMember = "URUNLER";
            this.uRUNLERBindingSource.DataSource = this.webSitesiProjeDataSet1;
            // 
            // webSitesiProjeDataSet1
            // 
            this.webSitesiProjeDataSet1.DataSetName = "WebSitesiProjeDataSet1";
            this.webSitesiProjeDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uRUNLERTableAdapter
            // 
            this.uRUNLERTableAdapter.ClearBeforeFill = true;
            // 
            // urunlerKategoriTableAdapter
            // 
            this.urunlerKategoriTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(247, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(987, 651);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // webSitesiProjeDataSet6
            // 
            this.webSitesiProjeDataSet6.DataSetName = "WebSitesiProjeDataSet6";
            this.webSitesiProjeDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uRUNLERBindingSource1
            // 
            this.uRUNLERBindingSource1.DataMember = "URUNLER";
            this.uRUNLERBindingSource1.DataSource = this.webSitesiProjeDataSet6;
            // 
            // uRUNLERTableAdapter1
            // 
            this.uRUNLERTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(121, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(101, 22);
            this.textBox1.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 31;
            this.label7.Text = "ID";
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.Color.Red;
            this.Sil.Location = new System.Drawing.Point(17, 548);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(132, 50);
            this.Sil.TabIndex = 29;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // Ekle
            // 
            this.Ekle.BackColor = System.Drawing.Color.Yellow;
            this.Ekle.Location = new System.Drawing.Point(17, 498);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(132, 50);
            this.Ekle.TabIndex = 26;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = false;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // Guncelle
            // 
            this.Guncelle.BackColor = System.Drawing.Color.Lime;
            this.Guncelle.Location = new System.Drawing.Point(17, 598);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(132, 50);
            this.Guncelle.TabIndex = 33;
            this.Guncelle.Text = "Güncelle";
            this.Guncelle.UseVisualStyleBackColor = false;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click_1);
            // 
            // Resim1
            // 
            this.Resim1.Location = new System.Drawing.Point(17, 453);
            this.Resim1.Name = "Resim1";
            this.Resim1.Size = new System.Drawing.Size(75, 23);
            this.Resim1.TabIndex = 34;
            this.Resim1.Text = "Resim";
            this.Resim1.UseVisualStyleBackColor = true;
            this.Resim1.Click += new System.EventHandler(this.Resim1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Resim2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(121, 389);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 36;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(121, 417);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Resim1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Resim2";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(163, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1193, 655);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resim1);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ÜrünAcıklamasi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UrunStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Kategoriler);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birimFiyati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UrunAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UrunKodu);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerKategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSitesiProjeDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNLERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSitesiProjeDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSitesiProjeDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uRUNLERBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ÜrünAcıklamasi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UrunStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Kategoriler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox birimFiyati;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UrunKodu;
        private WebSitesiProjeDataSet1 webSitesiProjeDataSet1;
        private System.Windows.Forms.BindingSource uRUNLERBindingSource;
        private WebSitesiProjeDataSet1TableAdapters.URUNLERTableAdapter uRUNLERTableAdapter;
        private WebSitesiProjeDataSet2 webSitesiProjeDataSet2;
        private System.Windows.Forms.BindingSource urunlerKategoriBindingSource;
        private WebSitesiProjeDataSet2TableAdapters.UrunlerKategoriTableAdapter urunlerKategoriTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WebSitesiProjeDataSet6 webSitesiProjeDataSet6;
        private System.Windows.Forms.BindingSource uRUNLERBindingSource1;
        private WebSitesiProjeDataSet6TableAdapters.URUNLERTableAdapter uRUNLERTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button Ekle;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Button Resim1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}