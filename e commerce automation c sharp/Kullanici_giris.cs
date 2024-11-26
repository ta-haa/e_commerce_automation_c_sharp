using eticaret_programi.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eticaret_programi
{
    public partial class Kullanici_giris : Form
    {
        public Kullanici_giris()
        {
            InitializeComponent();
            txtuyesifre.PasswordChar = '*';
            txtuyead.TabIndex = 0;
            txtuyeeposta.TabIndex = 1;
            txtuyesifre.TabIndex = 2;
            btnuyegiris.TabIndex = 3;
            button1.TabIndex = 4;
        }
        private void Kullanici_giris_Load(object sender, EventArgs e, Kullanici_giris kullanici_giris)
        {
            


        }

        private void btnuyegiris_Click(object sender, EventArgs e)
        {
            try
            {
                sqlbaglanticlass.baglan.Open();
                SqlCommand uyegiris = new SqlCommand("select Ad,Eposta,Sifre from kullanici where Ad=@ad and Eposta=@mail and Sifre=@sifre", sqlbaglanticlass.baglan);
                uyegiris.Parameters.AddWithValue("@Ad", txtuyead.Text);
                uyegiris.Parameters.AddWithValue("@mail", txtuyeeposta.Text);
                uyegiris.Parameters.AddWithValue("@sifre", txtuyesifre.Text);
                SqlDataAdapter da = new SqlDataAdapter(uyegiris);


                DataTable tablo = new DataTable();
                da.Fill(tablo);
                if (tablo.Rows.Count > 0)
                {
                    Kullanici_Paneli ekran = new Kullanici_Paneli();
                    ekran.veri = "Hosgeldin " + txtuyead.Text;
                    ekran.Show();
                    
                }
                else
                {
                    MessageBox.Show("Eposta veya Şifre Hatalı");
                }
                sqlbaglanticlass.baglan.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hatayla Karşılaşıldı Lütfen Daha Sonra Tekrar Deneyiniz...", "!! Hata !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtuyead.ResetText();
            txtuyeeposta.ResetText();
            txtuyesifre.ResetText();
        }

        

        private void Kullanici_giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Çıkmak İstediğinizden Emin misiniz", "Uyarı");
            giris frm = new giris();
            frm.Show();
        }
    }
}
