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
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        UserDAL dal = new UserDAL();
        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvKullanicilar.DataSource = dal.GetDataTable("Select * from users");
            // dgvUrunler.DataSource = dal.GetDataTable("select * from Product");
            btnEkle.Enabled = true;
            btnGuncelle.Enabled = false;
            btnSil.Enabled = false;
            txtName.Text = "";
            txtSurname.Text = "";
            txtPassword.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbIsActive.Checked = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Tüm alanları doldurmalısınız!");
                return;
            }
            var kullanici = new User
            {
                CreateDate = DateTime.Now,
                Password = txtPassword.Text,
                IsActive = cbIsActive.Checked,
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Email = txtEmail.Text

            };
            var sonuc = dal.Add(kullanici);
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kullanıcı Eklendi");
            }
            else
            {
                MessageBox.Show("Ekleme Başarısız");
            }
        }

        private void dgvKullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvKullanicilar.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dgvKullanicilar.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = dgvKullanicilar.CurrentRow.Cells["Email"].Value.ToString();
            txtPassword.Text = dgvKullanicilar.CurrentRow.Cells["Password"].Value.ToString();
            cbIsActive.Checked = (bool)dgvKullanicilar.CurrentRow.Cells["IsActive"].Value;
            btnEkle.Enabled = false;
            btnGuncelle.Enabled = true;
            btnSil.Enabled = true;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Tüm alanları doldurmalısınız!");
                return;
            }
            var kullanici = new User
            {
                Id = (int)dgvKullanicilar.CurrentRow.Cells["Id"].Value,
                CreateDate = DateTime.Now,
                Password = txtPassword.Text,
                IsActive = cbIsActive.Checked,
                Name = txtName.Text,
                Surname = txtSurname.Text,
                Email = txtEmail.Text

            };
            var sonuc = dal.Update(kullanici);
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Güncelleme işlemi yapıldı!");
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi Başarısız!");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var sonuc = dal.Delete((int)dgvKullanicilar.CurrentRow.Cells[0].Value);
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Silme Başarılı!");
            }
            else
            {
                MessageBox.Show("Kayıt Silme Başarısız!");
            }
        }
    }
}
