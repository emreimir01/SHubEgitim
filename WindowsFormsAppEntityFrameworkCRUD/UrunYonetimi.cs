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
    public partial class UrunYonetimi : Form
    {
        public UrunYonetimi()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext();

        private void UrunYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvUrunler.DataSource = context.Product.ToList();
            cbKategoriler.DataSource = context.Categories.ToList();
            cbKategoriler.DisplayMember = "Name";
            cbKategoriler.ValueMember = "Id";
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtUrunAdi.Text = "";
            txtAciklama.Text = string.Empty;
            cbDurum.Checked = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text) || string.IsNullOrWhiteSpace(txtStok.Text) || string.IsNullOrWhiteSpace(txtFiyat.Text))
            {
                MessageBox.Show("Gerekli alanları doldurunuz!");
                return;
            }
            var urun = new Product
            {
                CreateDate = DateTime.Now,
                Stock = Convert.ToInt32(txtStok.Text),
                Description = txtAciklama.Text,
                IsActive = cbDurum.Checked,
                Name = txtUrunAdi.Text,
                Price = Convert.ToDecimal(txtFiyat.Text),
                CategoryId = (int)cbKategoriler.SelectedValue
            };
            try
            {
                context.Product.Add(urun);
                var sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Ürün Eklendi");
                }
                else
                {
                    MessageBox.Show("Ekleme Başarısız");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Girdiğiniz değerleri kontrol ediniz.");
            }
        }

        private void dgvUrunler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Text = dgvUrunler.CurrentRow.Cells[1].Value.ToString();
            txtAciklama.Text = dgvUrunler.CurrentRow.Cells[2].Value.ToString();
            cbDurum.Checked = (bool)dgvUrunler.CurrentRow.Cells[3].Value;
            cbKategoriler.SelectedValue = Convert.ToInt32(dgvUrunler.CurrentRow.Cells["CategoryId"].Value);
            txtStok.Text = dgvUrunler.CurrentRow.Cells[5].Value.ToString();
            txtFiyat.Text = dgvUrunler.CurrentRow.Cells[6].Value.ToString();

            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text) || string.IsNullOrWhiteSpace(txtStok.Text) || string.IsNullOrWhiteSpace(txtFiyat.Text))
            {
                MessageBox.Show("Gerekli alanları doldurunuz!");
                return;
            }
            var id = (int)dgvUrunler.CurrentRow.Cells["Id"].Value;
            var product = context.Product.Find(id);
            product.Name = txtUrunAdi.Text;
            product.Description = txtAciklama.Text;
            product.IsActive = cbDurum.Checked;
            product.Stock = Convert.ToInt32(txtStok.Text);
            product.Price = Convert.ToDecimal(txtFiyat.Text);
            product.CategoryId = (int)cbKategoriler.SelectedValue;
            try
            {
                
                var sonuc = context.SaveChanges();
                if (sonuc > 0)
                {
                    Yukle();
                    MessageBox.Show("Güncelleme İşlemi Başarılı!");
                }
                else
                {
                    MessageBox.Show("Güncelleme İşlemi Başarısız!");

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata Oluştu! Girdiğiniz değerleri kontrol ediniz.");
            }

        }
        
        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = (int)dgvUrunler.CurrentRow.Cells["Id"].Value;
            var product = context.Product.Find(id);
            context.Product.Remove(product);
            var sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Silme İşlemi Başarılı!");
            }
            else
            {
                MessageBox.Show("Silme İşlemi Başarısız!");

            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = context.Product.Where(x => x.Name.Contains(txtAra.Text) || x.Description.Contains(txtAra.Text)).ToList();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            dgvUrunler.DataSource = context.Product.Where(x => x.Name.Contains(txtAra.Text) || x.Description.Contains(txtAra.Text)).ToList();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
