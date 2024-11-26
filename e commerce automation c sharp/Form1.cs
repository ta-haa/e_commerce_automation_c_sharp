using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using eticaret_programi.classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace eticaret_programi
{



    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
            txtuyeolad.TextAlign = HorizontalAlignment.Center;
            txtuyeolsoyad.TextAlign = HorizontalAlignment.Center;
            txtuyeolmail.TextAlign = HorizontalAlignment.Center;
            txtuyeoltelefon.TextAlign = HorizontalAlignment.Center;
            txtuyeolsifre.TextAlign = HorizontalAlignment.Center;
            txtuyeolcaptcha.TextAlign = HorizontalAlignment.Center;
        }



        int sayac = 10;

        private void giris_Load(object sender, EventArgs e)
        {
           

            txtuyeolsifre.PasswordChar = '*';
            txtuyeolsifre.MaxLength = 50;
            lblzaman.Text = "10";
            zaman.Start();
            zaman.Interval = 1000;
            btnuyeol.Enabled = txtuyeolad.Text.Length == 0 || txtuyeolsoyad.Text.Length == 0 ? false : true;

            txtuyeolad.TabIndex = 0;
            txtuyeolsoyad.TabIndex = 1;
            txtuyeolmail.TabIndex = 2;
            txtuyeolsifre.TabIndex = 3;
            txtuyeoltelefon.TabIndex = 4;
            txtuyeolcaptcha .TabIndex = 5;
            btnuyeol.TabIndex = 6;


            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
            Brush brush = new LinearGradientBrush(gradient_rectangle, Color.Red, Color.Black, 45f);
            Graphics.ReferenceEquals(brush, gradient_rectangle);
            this.Paint += new PaintEventHandler(set_background);

        }

        private void set_background(Object sender, PaintEventArgs e)
        {
            
            if (sayac == 1)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(255, 0, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 2)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(255, 0, 0), Color.FromArgb(0, 0, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 3)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(0,255, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 4)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 255, 0), Color.FromArgb(0, 0, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 5)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(255, 69, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 6)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(255, 69, 0), Color.FromArgb(0, 0, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 7)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0, 0, 0), Color.FromArgb(128, 0, 128), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 8)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(128, 0, 128), Color.FromArgb(0,0,0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 9)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(0,0,0), Color.FromArgb(255, 255, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
            if (sayac == 10)
            {
                Graphics graphics = e.Graphics;
                Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);
                Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(255, 255, 0), Color.FromArgb(0, 0, 0), 65f);
                graphics.FillRectangle(b, gradient_rectangle);
            }
        }
        

        private void zaman_Tick(object sender, EventArgs e)
        {
            sayac--;
            lblzaman.Text = sayac.ToString();

            //captcha guvenlik icin

            if (sayac == 0)
            {
                sayac = 10;
                string[] BuyukHarfler = { "A", "B", "C", "Ç", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
                string[] KucukHarfler = { "a", "b", "c", "ç", "d", "e", "f", "g", "ğ", "h", "ı", "i", "j", "k", "l", "m", "n", "o", "ö", "p", "r", "s", "ş", "t", "u", "ü", "v", "y", "z" };
                string[] Semboller = { "+", "-", "/", "*", "!", "#", "$", "%", "½", "{", "[", "/", "(", ")", "]", "=", "}", "?", "<", ">", "|", "@", "~", "¨", "æ", "ß", ",", ";", ":", "." };


                Random rnd = new Random();

                int sembol1, sembol2, sembol3, sembol4;

                sembol1 = rnd.Next(0, BuyukHarfler.Length);
                sembol2 = rnd.Next(0, 10);
                sembol3 = rnd.Next(0, KucukHarfler.Length);
                sembol4 = rnd.Next(0, Semboller.Length);

                lblcapctha.Text = BuyukHarfler[sembol1] + sembol2.ToString() + KucukHarfler[sembol3] + Semboller[sembol4];



                this.BackColor = Color.Red;

            }


            


            if (sayac == 1)
            { this.BackColor = Color.Black; }
            if (sayac == 2)
            { this.BackColor = Color.Purple; }
            if (sayac == 3)
            { this.BackColor = Color.DeepPink; }
            if (sayac == 4)
            { this.BackColor = Color.OrangeRed; }
            if (sayac == 5)
            { this.BackColor = Color.GreenYellow; }
            if (sayac == 6)
            { this.BackColor = Color.Cyan; }
            if (sayac == 7)
            { this.BackColor = Color.White; }
            if (sayac == 8)
            { this.BackColor = Color.Yellow; }
            if (sayac == 9)
            { this.BackColor = Color.Firebrick; }

            if (sayac % 2 == 1) //renk degisimleri
            {
                lblzaman.ForeColor = Color.Black;
                lblad.ForeColor = Color.White;
                lblsifre.ForeColor = Color.White;
                lblsoyad.ForeColor = Color.White;
                label1.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                lblcapctha.ForeColor = Color.White;

                lblad.BackColor = Color.Red;
                lblsifre.BackColor = Color.Red;
                lblsoyad.BackColor = Color.Red;
                label1.BackColor = Color.Red;
                label3.BackColor = Color.Red;
                lblcapctha.BackColor = Color.Red;
            }
            else
            {
                lblzaman.ForeColor = Color.White;
                lblad.ForeColor = Color.Red;
                lblsifre.ForeColor = Color.Red;
                lblsoyad.ForeColor = Color.Red;
                label1.ForeColor = Color.Red;
                label3.ForeColor = Color.Red;
                lblcapctha.ForeColor = Color.Red;

                lblad.BackColor = Color.White;
                lblsifre.BackColor = Color.White;
                lblsoyad.BackColor = Color.White;
                label1.BackColor = Color.White;
                label3.BackColor = Color.White;
                lblcapctha.BackColor = Color.White;
            }



        }





        private void btnuyegiris_Click(object sender, EventArgs e)
        {
            Kullanici_giris panel = new Kullanici_giris();
            panel.Show();

            this.Hide();
        }

        private void btnadmingiris_Click(object sender, EventArgs e)
        {
            Admin_Girisi panel = new Admin_Girisi();
            panel.Show();

            this.Hide();
        }

        private void btnuyeol_Click(object sender, EventArgs e)
        {
            try
            {
                string yazi1 = lblcapctha.Text;
                string yazi2 = txtuyeolcaptcha.Text;
                if (yazi1 != yazi2)
                {
                    MessageBox.Show("Baklenmedik Hata");
                    Close();
                }
                else
                {
                    sqlbaglanticlass.baglan.Open();
                    SqlCommand uyeol = new SqlCommand("insert into kullanici(ad,soyad,eposta,telefon,sifre) values (@ad,@soyad,@eposta,@telefon,@sifre)", sqlbaglanticlass.baglan);
                    uyeol.Parameters.AddWithValue("@ad", txtuyeolad.Text);
                    uyeol.Parameters.AddWithValue("@soyad", txtuyeolsoyad.Text);
                    uyeol.Parameters.AddWithValue("eposta", txtuyeolmail.Text);
                    uyeol.Parameters.AddWithValue("@telefon", txtuyeoltelefon.Text);
                    uyeol.Parameters.AddWithValue("@sifre", txtuyeolsifre.Text);
                    uyeol.ExecuteNonQuery();
                    txtuyeolad.ResetText();
                    txtuyeolsoyad.ResetText();
                    txtuyeolmail.ResetText();
                    txtuyeolsifre.ResetText();
                    sqlbaglanticlass.baglan.Close();
                    Kullanici_giris panel = new Kullanici_giris();
                    panel.Show();
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Beklenmedik Bir Hatayla Karşılaşıldı Lütfen Daha Sonra Tekrar Deneyiniz...", "!! Hata !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Close();
            }

        }

        private void txtuyeolad_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtuyeolsoyad_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtuyeolsifre_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtuyeoltelefon_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtuyeolcaptcha_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }
        private void CheckFields()
        {
            btnuyeol.Enabled = txtuyeolad.Text.Length == 0 || txtuyeolsoyad.Text.Length == 0 || txtuyeolmail.Text.Length == 0 || txtuyeolsifre.Text.Length == 0 || txtuyeolcaptcha.Text.Length == 0 ? false : true;
        }

        private void btnqr_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@TahaKeskin");
        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@TahaKeskin");
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void formuKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void formuKapatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giris_FormClosed(object sender, FormClosedEventArgs e)
        {
            var yazi =MessageBox.Show("Uygulamadan Çıkmak İstediğinizden Emin misiniz", "Uyarı",MessageBoxButtons.OK);
            if (yazi ==  DialogResult.OK)
            {
                
            }
            else
            {

            }
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }















}
