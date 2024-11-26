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
    public partial class Admin_Girisi : Form
    {
        public Admin_Girisi()
        {
            InitializeComponent();
            txtadminsifre.PasswordChar = '*';
        }

        private void btnadmingiris_Click(object sender, EventArgs e)
        {
            try
            {
                sqlbaglanticlass.baglan.Open();
                SqlCommand uyegiris = new SqlCommand("select * from admin where adminadi=@mail and Sifre=@sifre", sqlbaglanticlass.baglan);
                uyegiris.Parameters.AddWithValue("@mail", txtadmineposta.Text);
                uyegiris.Parameters.AddWithValue("@sifre", txtadminsifre.Text);
                SqlDataAdapter da = new SqlDataAdapter(uyegiris);


                DataTable tablo = new DataTable();
                da.Fill(tablo);
                if (tablo.Rows.Count > 0)
                {
                    Admin_Panali ekran = new Admin_Panali();
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

        private void Admin_Girisi_Load(object sender, EventArgs e)
        {
            txtadmineposta.TabIndex = 0;
            txtadminsifre.TabIndex = 1;
            btnadmingiris.TabIndex = 2;
            
        }

        private void Admin_Girisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Çıkmak İstediğinizden Emin misiniz", "Uyarı");
            giris frm = new giris();
            frm.Show();
        }
    }
}
