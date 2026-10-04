using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saner3
{
    public partial class Form1 : Form
    {
        sanerEntities Raik = new sanerEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            dataGridView1.DataSource = Raik.RAY.ToList();
        }

        void temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtMail.Clear();
        }

        // EKLE
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            RAY yeniKayit = new RAY();
            yeniKayit.numara = txtMail.Text;
            yeniKayit.Ad = txtAd.Text;
            yeniKayit.Soyad = txtSoyad.Text;

            Raik.RAY.Add(yeniKayit);
            Raik.SaveChanges();
            MessageBox.Show("Kayıt başarıyla eklendi.");
            listele();
            temizle();
        }

        // SİL
        private void btnSil_Click_1(object sender, EventArgs e)
        {
            string no = txtMail.Text;
            var silinecek = Raik.RAY.FirstOrDefault(x => x.numara == no);
            if (silinecek != null)
            {
                Raik.RAY.Remove(silinecek);
                Raik.SaveChanges();
                MessageBox.Show("Kayıt başarıyla silindi.");
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Silinecek kayıt bulunamadı.");
            }
        }

        // GÜNCELLE
        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            string no = txtMail.Text;
            var guncellenecek = Raik.RAY.FirstOrDefault(x => x.numara == no);
            if (guncellenecek != null)
            {
                guncellenecek.Ad = txtAd.Text;
                guncellenecek.Soyad = txtSoyad.Text;

                Raik.SaveChanges();
                MessageBox.Show("Kayıt güncellendi.");
                listele();
                temizle();
            }
            else
            {
                MessageBox.Show("Güncellenecek kayıt bulunamadı.");
            }
        }

        // ARAMA
        private void btnARA_Click(object sender, EventArgs e)
        {
            string aranan = txtAd.Text;
            var sonuc = Raik.RAY.Where(x => x.Ad.Contains(aranan)).ToList();
            dataGridView1.DataSource = sonuc;
        }

        // GRID TIKLAMA
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells["numara"].Value?.ToString();
                txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells["Ad"].Value?.ToString();
                txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells["Soyad"].Value?.ToString();
            }
        }
    }
}