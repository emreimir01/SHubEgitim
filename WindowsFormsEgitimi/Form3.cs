using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEgitimi
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre giriniz!", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
