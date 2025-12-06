using NetFrameworkMVCEgitimi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetFrameworkMVCEgitimi.Controllers
{
    public class MVC04ModelBindingController : Controller
    {
        // GET: MVC04ModelBinding
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult KullaniciDetay()
        {
            var kullanici = new Kullanici()
            {
                Ad = "Emre", Soyad = "İmir", Email = "emreimir01@gmail.com", KullaniciAdi  = "emrepsd11",
                Sifre = "12345"
            };
            return View(kullanici); // kullanici nesnesini bu şekilde sayfaya model verisi 
        }
        [HttpPost]
        public ActionResult KullaniciDetay(Kullanici kullanici)
        {
            // burada ekrandan gelen kullanici nesnesini dbye kaydedebiliriz
            return View(kullanici); 
        }
        public ActionResult AdresDetay()
        {
            var model = new Adres()
            {
                Ilce = "Kartal", Sehir = "İstanbul", AcikAdres = "Gül sk. No: 18 Atalar"
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult AdresDetay(Adres model)
        {
            
            return View(model);
        }
        public ActionResult KullanıcıAdresDetay()
        {
            var kullanici = new Kullanici()
            {
                Ad = "Elif Su",
                Soyad = "Uygun",
                Email = "elifsu38@gmail.com",
                KullaniciAdi = "esu38",
                Sifre = "12345"
            };
            UyeSayfasiViewModel model = new UyeSayfasiViewModel()
            {
                Kullanici = kullanici,
                Adres = new Adres()
                {
                    Ilce = "Talas",
                    Sehir = "Kayseri",
                    AcikAdres = "Gül sk. No: 18 Atalar"
                }
            };
            return View(model);
        }
    }
}