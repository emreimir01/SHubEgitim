using System;
using System.ComponentModel.DataAnnotations; // validation için
using System.ComponentModel.DataAnnotations.Schema; 
using System.Web;

namespace NetFrameworkMVCEgitimi.Models
{
    [Table("Uyeler")] // Classın adı üye fakat veritabanı tarafında tablo adı  Uyeler olsun
    public class Uye
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad boş geçilemez!"), StringLength(50)]
        public string Ad { get; set; }
        public string Soyad { get; set; }
        [Required, StringLength(50), EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Telefon { get; set; }
        [Display(Name = "TC Kimlik Numarası"), StringLength(50)]
        public string TcKimlikNo { get; set; }
        [Display(Name = "Doğum Tarihi")]
        public DateTime DogumTarihi { get; set; }
        [Display(Name = "Kullanıcı Adı"), StringLength(50)]
        public string KullaniciAdi { get; set; }
        [Display(Name = "Şifre")]
        [StringLength(15, ErrorMessage = "{0} {2} karakterden az olamaz!", MinimumLength = 5)]
        [Required(ErrorMessage ="{0} alanı boş geçilemez!")]
        public string Sifre { get; set; }
        [Display(Name = "Şifreyi tekrar giriniz")]
        [StringLength(15, ErrorMessage = "{0} {2} karakterden az olamaz!", MinimumLength = 5)]
        [Compare("Sifre")] // Sifre property si ile karşılaştırır
        public string SifreTekrar {  get; set; }
    }
}