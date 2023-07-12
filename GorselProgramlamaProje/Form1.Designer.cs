
namespace GorselProgramlamaProje
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.blogIcerikTableAdapter1 = new GorselProgramlamaProje.ElektroinkTableAdapters.BlogIcerikTableAdapter();
            this.Siparisler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(417, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(389, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "Ürün";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(389, 69);
            this.button2.TabIndex = 1;
            this.button2.Text = "Blog Sayfası";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(417, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(389, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "Kullanıcılar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // blogIcerikTableAdapter1
            // 
            this.blogIcerikTableAdapter1.ClearBeforeFill = true;
            // 
            // Siparisler
            // 
            this.Siparisler.Location = new System.Drawing.Point(417, 384);
            this.Siparisler.Name = "Siparisler";
            this.Siparisler.Size = new System.Drawing.Size(389, 69);
            this.Siparisler.TabIndex = 3;
            this.Siparisler.Text = "Siparisler";
            this.Siparisler.UseVisualStyleBackColor = true;
            this.Siparisler.Click += new System.EventHandler(this.Siparisler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1162, 658);
            this.Controls.Add(this.Siparisler);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ElektroinkTableAdapters.BlogIcerikTableAdapter blogIcerikTableAdapter1;
        private System.Windows.Forms.Button Siparisler;
    }
}

