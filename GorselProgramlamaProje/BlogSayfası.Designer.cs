
namespace GorselProgramlamaProje
{
    partial class BlogSayfası
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Kategoriler = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.blogIcerikTableAdapter1 = new GorselProgramlamaProje.ElektroinkTableAdapters.BlogIcerikTableAdapter();
            this.KategorilerCb = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Guncelle = new System.Windows.Forms.Button();
            this.Ekle = new System.Windows.Forms.Button();
            this.webSitesiProjeDataSet7 = new GorselProgramlamaProje.WebSitesiProjeDataSet7();
            this.blogKategoriIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blogKategoriIDTableAdapter = new GorselProgramlamaProje.WebSitesiProjeDataSet7TableAdapters.BlogKategoriIDTableAdapter();
            this.Sil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSitesiProjeDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogKategoriIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView1.Location = new System.Drawing.Point(278, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // Kategoriler
            // 
            this.Kategoriler.AutoSize = true;
            this.Kategoriler.Location = new System.Drawing.Point(14, 76);
            this.Kategoriler.Name = "Kategoriler";
            this.Kategoriler.Size = new System.Drawing.Size(77, 17);
            this.Kategoriler.TabIndex = 2;
            this.Kategoriler.Text = "Kategoriler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Baslik";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "İcerik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tarih";
            // 
            // blogIcerikTableAdapter1
            // 
            this.blogIcerikTableAdapter1.ClearBeforeFill = true;
            // 
            // KategorilerCb
            // 
            this.KategorilerCb.DataSource = this.blogKategoriIDBindingSource;
            this.KategorilerCb.DisplayMember = "KategoriAdi";
            this.KategorilerCb.FormattingEnabled = true;
            this.KategorilerCb.Location = new System.Drawing.Point(99, 73);
            this.KategorilerCb.Name = "KategorilerCb";
            this.KategorilerCb.Size = new System.Drawing.Size(121, 24);
            this.KategorilerCb.TabIndex = 6;
            this.KategorilerCb.ValueMember = "ID";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(99, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(120, 22);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(99, 141);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(120, 22);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(98, 174);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 22);
            this.textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(99, 207);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(120, 22);
            this.textBox4.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(99, 273);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(120, 22);
            this.textBox5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(99, 240);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(120, 22);
            this.textBox6.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ozet";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Resim";
            // 
            // Guncelle
            // 
            this.Guncelle.BackColor = System.Drawing.Color.Lime;
            this.Guncelle.Location = new System.Drawing.Point(17, 328);
            this.Guncelle.Name = "Guncelle";
            this.Guncelle.Size = new System.Drawing.Size(88, 35);
            this.Guncelle.TabIndex = 15;
            this.Guncelle.Text = "Guncelle";
            this.Guncelle.UseVisualStyleBackColor = false;
            this.Guncelle.Click += new System.EventHandler(this.Guncelle_Click);
            // 
            // Ekle
            // 
            this.Ekle.BackColor = System.Drawing.Color.Yellow;
            this.Ekle.Location = new System.Drawing.Point(17, 363);
            this.Ekle.Name = "Ekle";
            this.Ekle.Size = new System.Drawing.Size(88, 35);
            this.Ekle.TabIndex = 16;
            this.Ekle.Text = "Ekle";
            this.Ekle.UseVisualStyleBackColor = false;
            this.Ekle.Click += new System.EventHandler(this.Ekle_Click);
            // 
            // webSitesiProjeDataSet7
            // 
            this.webSitesiProjeDataSet7.DataSetName = "WebSitesiProjeDataSet7";
            this.webSitesiProjeDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blogKategoriIDBindingSource
            // 
            this.blogKategoriIDBindingSource.DataMember = "BlogKategoriID";
            this.blogKategoriIDBindingSource.DataSource = this.webSitesiProjeDataSet7;
            // 
            // blogKategoriIDTableAdapter
            // 
            this.blogKategoriIDTableAdapter.ClearBeforeFill = true;
            // 
            // Sil
            // 
            this.Sil.BackColor = System.Drawing.Color.Red;
            this.Sil.Location = new System.Drawing.Point(17, 392);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(88, 35);
            this.Sil.TabIndex = 17;
            this.Sil.Text = "Sil";
            this.Sil.UseVisualStyleBackColor = false;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // BlogSayfası
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sil);
            this.Controls.Add(this.Ekle);
            this.Controls.Add(this.Guncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.KategorilerCb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Kategoriler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BlogSayfası";
            this.Text = "BlogSayfası";
            this.Load += new System.EventHandler(this.BlogSayfası_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webSitesiProjeDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogKategoriIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Kategoriler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private ElektroinkTableAdapters.BlogIcerikTableAdapter blogIcerikTableAdapter1;
        private System.Windows.Forms.ComboBox KategorilerCb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Guncelle;
        private System.Windows.Forms.Button Ekle;
        private WebSitesiProjeDataSet7 webSitesiProjeDataSet7;
        private System.Windows.Forms.BindingSource blogKategoriIDBindingSource;
        private WebSitesiProjeDataSet7TableAdapters.BlogKategoriIDTableAdapter blogKategoriIDTableAdapter;
        private System.Windows.Forms.Button Sil;
    }
}