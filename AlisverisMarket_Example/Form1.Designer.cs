
namespace AlisverisMarket_Example
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
            this.cmbUrunler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nuAdet = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.lstSebze = new System.Windows.Forms.ListBox();
            this.lstMeyve = new System.Windows.Forms.ListBox();
            this.lstBakliyat = new System.Windows.Forms.ListBox();
            this.btnSiparisTamamla = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblSebzeToplam = new System.Windows.Forms.Label();
            this.lblMeyveToplam = new System.Windows.Forms.Label();
            this.lblBakliyatTopla = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUrunler
            // 
            this.cmbUrunler.FormattingEnabled = true;
            this.cmbUrunler.Location = new System.Drawing.Point(60, 28);
            this.cmbUrunler.Name = "cmbUrunler";
            this.cmbUrunler.Size = new System.Drawing.Size(121, 25);
            this.cmbUrunler.TabIndex = 0;
            this.cmbUrunler.SelectedIndexChanged += new System.EventHandler(this.cmbUrunler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün ";
            // 
            // nuAdet
            // 
            this.nuAdet.Location = new System.Drawing.Point(60, 65);
            this.nuAdet.Name = "nuAdet";
            this.nuAdet.Size = new System.Drawing.Size(55, 25);
            this.nuAdet.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adet";
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 17;
            this.lstSepet.Location = new System.Drawing.Point(12, 154);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(116, 276);
            this.lstSepet.TabIndex = 4;
            // 
            // lstSebze
            // 
            this.lstSebze.FormattingEnabled = true;
            this.lstSebze.ItemHeight = 17;
            this.lstSebze.Location = new System.Drawing.Point(150, 154);
            this.lstSebze.Name = "lstSebze";
            this.lstSebze.Size = new System.Drawing.Size(106, 242);
            this.lstSebze.TabIndex = 5;
            // 
            // lstMeyve
            // 
            this.lstMeyve.FormattingEnabled = true;
            this.lstMeyve.ItemHeight = 17;
            this.lstMeyve.Location = new System.Drawing.Point(262, 154);
            this.lstMeyve.Name = "lstMeyve";
            this.lstMeyve.Size = new System.Drawing.Size(106, 242);
            this.lstMeyve.TabIndex = 6;
            // 
            // lstBakliyat
            // 
            this.lstBakliyat.FormattingEnabled = true;
            this.lstBakliyat.ItemHeight = 17;
            this.lstBakliyat.Location = new System.Drawing.Point(374, 154);
            this.lstBakliyat.Name = "lstBakliyat";
            this.lstBakliyat.Size = new System.Drawing.Size(106, 242);
            this.lstBakliyat.TabIndex = 7;
            // 
            // btnSiparisTamamla
            // 
            this.btnSiparisTamamla.Location = new System.Drawing.Point(12, 448);
            this.btnSiparisTamamla.Name = "btnSiparisTamamla";
            this.btnSiparisTamamla.Size = new System.Drawing.Size(116, 23);
            this.btnSiparisTamamla.TabIndex = 8;
            this.btnSiparisTamamla.Text = "Siparis Tamamla";
            this.btnSiparisTamamla.UseVisualStyleBackColor = true;
            this.btnSiparisTamamla.Click += new System.EventHandler(this.btnSiparisTamamla_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(15, 100);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(100, 29);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblSebzeToplam
            // 
            this.lblSebzeToplam.AutoSize = true;
            this.lblSebzeToplam.Location = new System.Drawing.Point(152, 413);
            this.lblSebzeToplam.Name = "lblSebzeToplam";
            this.lblSebzeToplam.Size = new System.Drawing.Size(104, 17);
            this.lblSebzeToplam.TabIndex = 10;
            this.lblSebzeToplam.Text = "Toplam : 0,00 TL";
            // 
            // lblMeyveToplam
            // 
            this.lblMeyveToplam.AutoSize = true;
            this.lblMeyveToplam.Location = new System.Drawing.Point(274, 413);
            this.lblMeyveToplam.Name = "lblMeyveToplam";
            this.lblMeyveToplam.Size = new System.Drawing.Size(104, 17);
            this.lblMeyveToplam.TabIndex = 11;
            this.lblMeyveToplam.Text = "Toplam : 0,00 TL";
            // 
            // lblBakliyatTopla
            // 
            this.lblBakliyatTopla.AutoSize = true;
            this.lblBakliyatTopla.Location = new System.Drawing.Point(376, 413);
            this.lblBakliyatTopla.Name = "lblBakliyatTopla";
            this.lblBakliyatTopla.Size = new System.Drawing.Size(104, 17);
            this.lblBakliyatTopla.TabIndex = 12;
            this.lblBakliyatTopla.Text = "Toplam : 0,00 TL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 557);
            this.Controls.Add(this.lblBakliyatTopla);
            this.Controls.Add(this.lblMeyveToplam);
            this.Controls.Add(this.lblSebzeToplam);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSiparisTamamla);
            this.Controls.Add(this.lstBakliyat);
            this.Controls.Add(this.lstMeyve);
            this.Controls.Add(this.lstSebze);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nuAdet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUrunler);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuAdet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.ListBox lstSebze;
        private System.Windows.Forms.ListBox lstMeyve;
        private System.Windows.Forms.ListBox lstBakliyat;
        private System.Windows.Forms.Button btnSiparisTamamla;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblSebzeToplam;
        private System.Windows.Forms.Label lblMeyveToplam;
        private System.Windows.Forms.Label lblBakliyatTopla;
    }
}

