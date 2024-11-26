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
    public partial class Admin_Panali : Form
    {
        public Admin_Panali()
        {
            InitializeComponent();
        }

        private void btnadminkullanicilar_Click(object sender, EventArgs e)
        {
            adminkullanicipaneli panel = new adminkullanicipaneli();
            panel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gelenmesajlar panel = new gelenmesajlar();
            panel.Show();
        }

        private void btnresimekle_Click(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            openFileDialog1.Filter = "Resim Dosyası |*.jpeg;*.png;*.jpg |  Tüm Dosyalar |*.*";
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;

            

        }

        private void btnurunekle_Click(object sender, EventArgs e)
        {
            sqlbaglanticlass.baglan.Open();
            SqlCommand kod = new SqlCommand("insert into envanter(envanteradi,envantermiktari,envanterfiyati,envanterfoto) values (@enad,@enmik,@enfiy,@enfoto)",sqlbaglanticlass.baglan);
            kod.Parameters.AddWithValue("@enad",txturunad.Text);
            kod.Parameters.AddWithValue("@enmik",txturunmiktar.Text);
            kod.Parameters.AddWithValue("@enfiy", txturunfiyat.Text);

            kod.Parameters.AddWithValue("@enfoto", openFileDialog1.FileName);

            kod.ExecuteNonQuery();
            MessageBox.Show("Envanter Eklendi");
            sqlbaglanticlass.baglan.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
