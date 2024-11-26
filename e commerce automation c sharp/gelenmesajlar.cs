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
    public partial class gelenmesajlar : Form
    {
        public gelenmesajlar()
        {
            InitializeComponent();
        }

        private void gelenmesajgoster_Click(object sender, EventArgs e)
        {
            if (mesajgonderen.CurrentCell != null)
            {
                txtgelenmesaj.Text = mesajgonderen.CurrentRow.Cells[8].Value.ToString();

                txtmid.Text = mesajgonderen.CurrentRow.Cells[6].Value.ToString();
            }
            else
            {
                MessageBox.Show("Gelen Mesaj Yok");
                
            }


        }

        private void gelenmesajlar_Load(object sender, EventArgs e)
        {
            sqlbaglanticlass.baglan.Open();
            SqlCommand komut = new SqlCommand("select * from kullanici inner join kullanicimesajlari on kullanici.eposta = kullanicimesajlari.eposta", sqlbaglanticlass.baglan);
            SqlDataReader dr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            mesajgonderen.DataSource = dt;
            sqlbaglanticlass.baglan.Close();
        }

        private void gelenmesajsil_Click(object sender, EventArgs e)
        {

            int kayit = int.Parse(txtmid.Text);

            var result = MessageBox.Show("Bak Emin Misin Siliyim Mi", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                var result2 = MessageBox.Show("Bak Siliyorum", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result2 == DialogResult.Yes)
                {

                    sqlbaglanticlass.baglan.Open();

                    SqlCommand sorgu = new SqlCommand("delete from kullanicimesajlari where kullanicimesajid=" + kayit, sqlbaglanticlass.baglan);
                    sorgu.ExecuteNonQuery();
                    MessageBox.Show("mesaj silindi");

                    SqlCommand komut = new SqlCommand("select * from kullanici inner join kullanicimesajlari on kullanici.eposta = kullanicimesajlari.eposta", sqlbaglanticlass.baglan);
                    SqlDataReader dr = komut.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    mesajgonderen.DataSource = dt;

                    sqlbaglanticlass.baglan.Close();
                }
            }


            /* if (mesajgonderen.Rows.Count != -1)
         {
             sqlbaglanticlass.baglan.Open();
             string secili = mesajgonderen.CurrentRow.Cells[1].Value.ToString();

             SqlCommand veri = new SqlCommand("delete from kullanicimesajlari where eposta = @epostaa", sqlbaglanticlass.baglan);
             veri.Parameters.AddWithValue("@epostaa", secili);
             veri.ExecuteNonQuery();

             MessageBox.Show("Mesaj silindi");


           SqlCommand komut = new SqlCommand("select * from kullanici inner join kullanicimesajlari on kullanici.eposta = kullanicimesajlari.eposta", sqlbaglanticlass.baglan);
           SqlDataReader dr = komut.ExecuteReader();
           DataTable dt = new DataTable();
           dt.Load(dr);
           mesajgonderen.DataSource = dt;




           sqlbaglanticlass.baglan.Close();
         }
         else
         {
             MessageBox.Show("Beklenmedik Hata Oluştu Lütfen Daha Sonra Tekrar Deneyin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

         } */


        }







    }
}

