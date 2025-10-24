using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsAppEntityFrameworkCRUD
{
    public partial class KategoriYonetimi : Form
    {
        public KategoriYonetimi()
        {
            InitializeComponent();
        }

        DatabaseContext context = new DatabaseContext(); // veritabanı tablolarımızı tutan entity framework sınıfımızdan bir nesne türettik.
        void Yukle()
        {
            dgvKategoriler.DataSource = context.Categories.ToList();
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtKategoriAdi.Text = "";
            txtAciklama.Text = string.Empty;
            cbDurum.Checked = false;
        }
        private void KategoriYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez");
                return;
            }
            var kategori = new Category
            {
                CreateDate = DateTime.Now,
                Description = txtAciklama.Text,
                IsActive = cbDurum.Checked,
                Name = txtKategoriAdi.Text
            };
            context.Categories.Add(kategori);
            var sonuc = context.SaveChanges(); // context.SaveChanges() metodu context üzerinde c# tarafındaki değişiklikleri
            // sql veritabanına yansıtır ve etkilenen kayıt sayısını int olarak bize getirir.
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kategori Eklendi");
            }
            else
            {
                MessageBox.Show("Ekleme Başarısız");
            }
        }

        private void dgvKategoriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            txtKategoriAdi.Text = dgvKategoriler.CurrentRow.Cells[1].Value.ToString();
            txtAciklama.Text = dgvKategoriler.CurrentRow.Cells[2].Value.ToString();
            cbDurum.Checked = (bool)dgvKategoriler.CurrentRow.Cells[3].Value;
            */
            var Id = (int)dgvKategoriler.CurrentRow.Cells["Id"].Value;
            var kayit = context.Categories.Find(Id); // Find metodu birincil anahtar üzerinden kayıt arar.
            txtKategoriAdi.Text = kayit.Name;
            txtAciklama.Text = kayit.Description;
            cbDurum.Checked = kayit.IsActive;

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKategoriAdi.Text))
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez");
                return;
            }
            var Id = (int)dgvKategoriler.CurrentRow.Cells["Id"].Value;
            var kayit = context.Categories.Find(Id);
            kayit.Name = txtKategoriAdi.Text;
            kayit.Description = txtAciklama.Text;
            kayit.IsActive = cbDurum.Checked;
            var sonuc = context.SaveChanges(); // değişiklikleri veritabanına yansıtır.

            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Başarısız");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var Id = (int)dgvKategoriler.CurrentRow.Cells["Id"].Value;
            var kayit = context.Categories.Find(Id); // dbden silinecek kaydı bulduk.
            context.Categories.Remove(kayit); // bulunan kaydı contextden sil dedik.
            var sonuc = context.SaveChanges(); // değişiklikleri veritabanına yansıtır.

            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Silme Başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Silme Başarısız");
            }
        }
    }
}
