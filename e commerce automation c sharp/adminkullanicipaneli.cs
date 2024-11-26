using eticaret_programi.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eticaret_programi
{
    public partial class adminkullanicipaneli : Form
    {
        public adminkullanicipaneli()
        {
            InitializeComponent();
        }

        private void admingoster_Click(object sender, EventArgs e)
        {
            try
            {

                sqlbaglanticlass.baglan.Open();
                SqlCommand gor = new SqlCommand("select * from kullanici", sqlbaglanticlass.baglan);
                SqlDataReader oku = gor.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(oku);
                dataGridView1.DataSource = dt;
                sqlbaglanticlass.baglan.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hatayla Karşılaşıldı Lütfen Daha Sonra Tekrar Deneyiniz...", "!! Hata !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Close();
            }

        }

        private void adminkullanicipaneli_Load(object sender, EventArgs e)
        {
            dataGridView1.ForeColor = Color.Red;
            txtadminara.TabIndex = 0;
            btnadminsil.TabIndex = 1;
            dataGridView1.TabIndex = 2;
            btnadminsil.TabIndex = 3;
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            try
            {
                string arama = txtadminara.Text;
                sqlbaglanticlass.baglan.Open();
                SqlCommand ara = new SqlCommand("select * from kullanici where ad like'%" + arama + "%'", sqlbaglanticlass.baglan);
                SqlDataReader dr = ara.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                sqlbaglanticlass.baglan.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hatayla Karşılaşıldı Lütfen Daha Sonra Tekrar Deneyiniz...", "!! Hata !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Close();
            }
        }

        private void btnadminsil_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bak Emin Misin Siliyim Mi","UYARI",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                var result2 = MessageBox.Show("Bak Siliyorum", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result2 == DialogResult.Yes)
                {
                    try
                    {
                        sqlbaglanticlass.baglan.Open();
                        string secili = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        SqlCommand veri = new SqlCommand("delete from kullanici where Eposta = @epostaa and Ad = @add", sqlbaglanticlass.baglan);
                        veri.Parameters.AddWithValue("@epostaa", secili);
                        veri.Parameters.AddWithValue("@add", secili);
                        veri.ExecuteNonQuery();

                        MessageBox.Show("seçili kayıt silindi");

                        DataTable tbl = new DataTable();
                        SqlDataAdapter adptr = new SqlDataAdapter("Select * from kullanici ", sqlbaglanticlass.baglan);
                        adptr.Fill(tbl);
                        dataGridView1.DataSource = tbl;

                        sqlbaglanticlass.baglan.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Beklenmedik Bir Hatayla Karşılaşıldı Lütfen Daha Sonra Tekrar Deneyiniz...", "!! Hata !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        Close();
                    }
                    
                }   
            }



        }

















    }   }

