using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppAdoNetCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Giris_Click(object sender, EventArgs e)
        {
            if (KullaniciAdi.Text == "admin" && Sifre.Text == "12345")
            {
                groupBox1.Visible = false;
                menuStrip1.Visible = true;
                MessageBox.Show("Giriş Başarılı!");
                // Burada giriş başarılı olduğunda yapılacak işlemler eklenebilir
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
            }
        }

        private void kategoriYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KategoriYonetimi kategoriYonetimi = new KategoriYonetimi();
            kategoriYonetimi.ShowDialog();
        }

        private void ürünYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UrunYonetimi urunYonetimi = new UrunYonetimi();
            urunYonetimi.ShowDialog();
        }

        private void kullanıcıYönetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciYonetimi kullaniciYonetimi = new KullaniciYonetimi();
            kullaniciYonetimi.ShowDialog();
        }
    }
}
