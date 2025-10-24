using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEntityFrameworkCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext();
        private void Giris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(KullaniciAdi.Text) || string.IsNullOrWhiteSpace(Sifre.Text))
            {
                MessageBox.Show("Kullanıcı Adı ve Şifre Boş Olamaz!");
                return;
            }
            var user = context.Users.FirstOrDefault(u => u.IsActive && u.Email == KullaniciAdi.Text && u.Password == Sifre.Text);
            if (user != null)
            {
                MessageBox.Show("Giriş Başarılı!");
                menuStrip1.Enabled = true;
                menuStrip1.Visible = true;
                groupBox1.Visible = false;
            }
            else
            {
                MessageBox.Show("Giriş Başarısız!");
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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
