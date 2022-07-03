namespace EntitiyFreamwork
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.Lblstok = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtUrunadi = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblAra = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1273, 795);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUrunAdi.Location = new System.Drawing.Point(1309, 68);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(88, 25);
            this.lblUrunAdi.TabIndex = 1;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // Lblstok
            // 
            this.Lblstok.AutoSize = true;
            this.Lblstok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblstok.Location = new System.Drawing.Point(1312, 240);
            this.Lblstok.Name = "Lblstok";
            this.Lblstok.Size = new System.Drawing.Size(52, 25);
            this.Lblstok.TabIndex = 2;
            this.Lblstok.Text = "Stok";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(1309, 146);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(55, 25);
            this.lblFiyat.TabIndex = 3;
            this.lblFiyat.Text = "Fİyat";
            // 
            // txtUrunadi
            // 
            this.txtUrunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunadi.Location = new System.Drawing.Point(1425, 68);
            this.txtUrunadi.Name = "txtUrunadi";
            this.txtUrunadi.Size = new System.Drawing.Size(125, 30);
            this.txtUrunadi.TabIndex = 4;
            // 
            // txtStok
            // 
            this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStok.Location = new System.Drawing.Point(1425, 240);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(125, 30);
            this.txtStok.TabIndex = 5;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(1425, 141);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(125, 30);
            this.txtFiyat.TabIndex = 6;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnEkle.Location = new System.Drawing.Point(1317, 297);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 37);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(1455, 297);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(111, 37);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriler.Location = new System.Drawing.Point(1317, 371);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(111, 37);
            this.btnKategoriler.TabIndex = 9;
            this.btnKategoriler.Text = "Kategoriler";
            this.btnKategoriler.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(1455, 371);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(111, 37);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // txtAra
            // 
            this.txtAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.Location = new System.Drawing.Point(1388, 445);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(125, 30);
            this.txtAra.TabIndex = 12;
            // 
            // lblAra
            // 
            this.lblAra.AutoSize = true;
            this.lblAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAra.Location = new System.Drawing.Point(1324, 450);
            this.lblAra.Name = "lblAra";
            this.lblAra.Size = new System.Drawing.Size(43, 25);
            this.lblAra.TabIndex = 11;
            this.lblAra.Text = "Ara";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1388, 492);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(125, 33);
            this.comboBox1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1809, 801);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKategoriler);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtUrunadi);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.Lblstok);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label Lblstok;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtUrunadi;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblAra;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

