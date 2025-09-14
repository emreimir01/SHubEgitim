using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konu08SiniflarClasses
{
    internal class User
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string PhoneNumber { get; set; }
        public bool KullaniciGiris(string mail, string sifre)
        {
            // Basit bir kullanıcı doğrulama simülasyonu
            if (mail == "emre@user.com" && sifre == "1234")
            {
                return true;
            }
            return false;
        }
    }
}
