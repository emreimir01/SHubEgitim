using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;

namespace WindowsFormsAppEntityFrameworkCRUD
{
    public partial class KullaniciYonetimi : Form
    {
        public KullaniciYonetimi()
        {
            InitializeComponent();
        }
        DatabaseContext context = new DatabaseContext();
        private void KullaniciYonetimi_Load(object sender, EventArgs e)
        {
            Yukle();
        }
        void Yukle()
        {
            dgvKullanicilar.DataSource = context.Users.ToList();

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
            context.Users.Add(kullanici);
            var sonuc = context.SaveChanges();
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
            int id = (int)dgvKullanicilar.CurrentRow.Cells["Id"].Value;
            var user = context.Users.Find(id);
            
            user.Email = txtEmail.Text;
            user.Name = txtName.Text;
            user.Surname = txtSurname.Text;
            user.Password = txtPassword.Text;
            user.IsActive = cbIsActive.Checked;

            var sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Güncellendi");
            }
            else
            {
                MessageBox.Show("Güncelleme Başarısız");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = (int)dgvKullanicilar.CurrentRow.Cells["Id"].Value;
            var user = context.Users.Find(id);

            context.Users.Remove(user);

            var sonuc = context.SaveChanges();
            if (sonuc > 0)
            {
                Yukle();
                MessageBox.Show("Kayıt Silindi");
            }
            else
            {
                MessageBox.Show("Silme Başarısız");
            }
        }
    }
}
