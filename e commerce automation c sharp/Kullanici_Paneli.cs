using eticaret_programi.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eticaret_programi
{
    public partial class Kullanici_Paneli : Form
    {
        public Kullanici_Paneli()
        {
            InitializeComponent();

        }

         
        public string veri = "";

        private void Kullanici_Paneli_Load(object sender, EventArgs e)
        {
            lblhosgeldin.Text = veri;

            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;

            timer1.Start();
            timer1.Interval = 1000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_mesaj panel = new Admin_mesaj();
            panel.Show();
        }

        private void btnsifreguncelleme_Click(object sender, EventArgs e)
        {
            Sifre_Guncelle panel = new Sifre_Guncelle();
            panel.Show();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            sqlbaglanticlass.baglan.Open();
           
            SqlCommand komut = new SqlCommand("select * from envanter where envanterid=1",sqlbaglanticlass.baglan);
            SqlDataReader dr = komut.ExecuteReader();

            

            while (dr.Read())
            {
                pictureBox1.Image = Image.FromFile("" + dr["envanterfoto"].ToString());



                lblurunadi1.Text = dr.GetValue(1).ToString();
                lblurunmiktari1.Text = dr.GetValue(2).ToString();
                lblurunfiyati1.Text = dr.GetValue(3).ToString();

            }

            sqlbaglanticlass.baglan.Close();

            btnsatinal1.Visible = true;

        }

        private void btnkpanelara_Click(object sender, EventArgs e)
        {
            try
            {
                string arama = txtkpanelara.Text;
                sqlbaglanticlass.baglan.Open();
                SqlCommand ara = new SqlCommand("select envanteradi,envanterfiyati from envanter where envanteradi like'%" + arama + "%'", sqlbaglanticlass.baglan);
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sqlbaglanticlass.baglan.Open();

            SqlCommand komut = new SqlCommand("select * from envanter where envanterid=2", sqlbaglanticlass.baglan);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                pictureBox2.Image = Image.FromFile("" + dr["envanterfoto"].ToString());
                lblurunadi2.Text = dr.GetValue(1).ToString();
                lblurunmiktari2.Text = dr.GetValue(2).ToString();
                lblurunfiyati2.Text = dr.GetValue(3).ToString();

            }

            sqlbaglanticlass.baglan.Close();

            btnsatinal2.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            sqlbaglanticlass.baglan.Open();

            SqlCommand komut = new SqlCommand("select * from envanter where envanterid=3", sqlbaglanticlass.baglan);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                pictureBox3.Image = Image.FromFile("" + dr["envanterfoto"].ToString());
                lblurunadi3.Text = dr.GetValue(1).ToString();
                lblurunmiktari3.Text = dr.GetValue(2).ToString();
                lblurunfiyati3.Text = dr.GetValue(3).ToString();

            }

            sqlbaglanticlass.baglan.Close();

            btnsatinal3.Visible = true;


        }

        private void lblhosgeldin_MouseEnter(object sender, EventArgs e)
        {
            lblhosgeldin.ForeColor = Color.Black;
        }

        private void lblhosgeldin_MouseLeave(object sender, EventArgs e)
        {
            lblhosgeldin.ForeColor = Color.Red;
        }

        int zaman=0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman++;
            if (zaman%2==1)
            {
                pictureBox1.BackColor = Color.White;
                pictureBox3.BackColor = Color.White;

                pictureBox2.BackColor = Color.Red;
            }
            else
            {
                pictureBox2.BackColor = Color.White;

                pictureBox1.BackColor = Color.Red;
                pictureBox3.BackColor = Color.Red;
            }


           







        }

        private void btnsatinal1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("250 + 50 (%20 KDV) Toplam = 300 TL");
        }

        private void btnsatinal2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("400 + 80 (%20 KDV) Toplam = 480 TL");
        }

        private void btnsatinal3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("250 + 4 (%20 KDV) Toplam = 254 TL");
        }
    }
}
