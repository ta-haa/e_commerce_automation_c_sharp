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
    public partial class Admin_mesaj : Form
    {
        private void Admin_mesaj_Load(object sender, EventArgs e)
        {
            
        }
        public Admin_mesaj()
        {
            InitializeComponent();
        }

        public string tesekkur = "";
        private void btnmesajgonder_Click(object sender, EventArgs e)
        {

            try
            {
                sqlbaglanticlass.baglan.Open();
                SqlCommand kullanicimesaj = new SqlCommand("select Eposta from kullanici where Eposta=@mail", sqlbaglanticlass.baglan);
                kullanicimesaj.Parameters.AddWithValue("@mail", txtmesajeposta.Text);
                SqlDataAdapter da = new SqlDataAdapter(kullanicimesaj);


                DataTable tablo = new DataTable();
                da.Fill(tablo);

                

                if (tablo.Rows.Count > 0)
                {


                    SqlCommand kullanicimesaji = new SqlCommand("insert into kullanicimesajlari (eposta,kullanicimesaji) values (@eposta,@kullanicimesaj)", sqlbaglanticlass.baglan);
                    kullanicimesaji.Parameters.AddWithValue("@eposta", txtmesajeposta.Text);
                    kullanicimesaji.Parameters.AddWithValue("@kullanicimesaj", txtmesaj.Text);
                    kullanicimesaji.ExecuteNonQuery();
                    lblmesaj.Text = "Düsüncelerin İçin Teşekkürler";

                }
                else
                {
                    MessageBox.Show("Eposta Hatalı");
                }
                sqlbaglanticlass.baglan.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hatayla Karşılaşıldı Lütfen Daha Sonra Tekrar Deneyiniz...", "!! Hata !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        
        
    }
}
