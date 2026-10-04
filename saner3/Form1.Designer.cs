namespace saner3
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnARA = new System.Windows.Forms.Button();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(516, 34);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(192, 126);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(788, 34);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(192, 126);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(1045, 34);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(192, 126);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Guncele";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click_1);
            // 
            // btnARA
            // 
            this.btnARA.Location = new System.Drawing.Point(1082, 546);
            this.btnARA.Name = "btnARA";
            this.btnARA.Size = new System.Drawing.Size(192, 126);
            this.btnARA.TabIndex = 3;
            this.btnARA.Text = "ARA";
            this.btnARA.UseVisualStyleBackColor = true;
            this.btnARA.Click += new System.EventHandler(this.btnARA_Click);
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(79, 138);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(218, 22);
            this.txtAd.TabIndex = 4;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(79, 166);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(218, 22);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(79, 194);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(218, 22);
            this.txtMail.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(79, 222);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(218, 22);
            this.textBox4.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(115, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(758, 294);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 723);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.btnARA);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnARA;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

