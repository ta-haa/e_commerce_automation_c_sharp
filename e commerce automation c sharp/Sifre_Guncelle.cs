using eticaret_programi.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace eticaret_programi
{
    public partial class Sifre_Guncelle : Form
    {
        public Sifre_Guncelle()
        {
            InitializeComponent();
            txtsifreguncelleeski.PasswordChar = '*';
            txtsifreguncelleyeni.PasswordChar = '*';
        }

        private void btnsifreguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                sqlbaglanticlass.baglan.Open();
                SqlCommand uyegiris = new SqlCommand("select Eposta,Sifre from kullanici where Eposta=@eposta and Sifre=@sifre", sqlbaglanticlass.baglan);
                uyegiris.Parameters.AddWithValue("@eposta", txtsifreguncellememail.Text);
                uyegiris.Parameters.AddWithValue("@sifre", txtsifreguncelleeski.Text);
                SqlDataAdapter da = new SqlDataAdapter(uyegiris);
                DataTable tablo = new DataTable();
                da.Fill(tablo);
                if (tablo.Rows.Count > 0)
                {
                    SqlCommand sifreguncelle = new SqlCommand("update kullanici set sifre=@sifrem where eposta=@epostaa and sifre=@sifree",sqlbaglanticlass.baglan);
                    sifreguncelle.Parameters.AddWithValue("@epostaa", txtsifreguncellememail.Text);
                    sifreguncelle.Parameters.AddWithValue("@sifree", txtsifreguncelleeski.Text);
                    sifreguncelle.Parameters.AddWithValue("@sifrem", txtsifreguncelleyeni.Text);
                    sifreguncelle.ExecuteNonQuery();
                    MessageBox.Show("Şifreniz Başarıyla Güncellendi");
                    this.Close();
                    Kullanici_Paneli frm1 = new Kullanici_Paneli();
                    frm1.Close();
                    giris frm = new giris();
                    frm.Show();


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

        private void Sifre_Guncelle_Load(object sender, EventArgs e)
        {
            txtsifreguncellememail.TabIndex = 0;
            txtsifreguncelleeski.TabIndex = 1;
            txtsifreguncelleyeni.TabIndex = 2;
            
        }
    }
}
