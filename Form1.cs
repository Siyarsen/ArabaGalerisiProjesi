using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaGalerisiProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Galeri galeri = new Galeri();
        private void EkranTemizle() //her seferinde ekranı silmemek için
        {
            txtMarka.Text = txtModel.Text=txtRenk.Text= " ";
            txtMarka.Focus();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Araba araba = new Araba();
                araba.Marka = txtMarka.Text;
                araba.Model = Convert.ToInt16(txtModel.Text);
                araba.Renk = txtRenk.Text; 
                galeri.ArabaEkle(araba); //arabayı galeriye eklememiz lazım
                EkranTemizle();
            }
            catch (Exception ex )
            {
                MessageBox.Show("HATA :"+ ex.Message);
                throw;
            }

        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            // galeri üzerindeki arabaları listeleyecek
            txtArabalar.Text = galeri.ArabalariListele() ;
            dgwArabalar.DataSource = galeri.ArabaListesiVer(); // DataSource list or objeckt alıyor
            // arabalistesiver diyince geriye bana arabaları dönüyor.
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgwArabalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
