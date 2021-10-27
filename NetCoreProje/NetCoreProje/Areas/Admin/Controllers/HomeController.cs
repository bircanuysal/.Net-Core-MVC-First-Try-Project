using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCoreProje.Entities;
using NetCoreProje.Interfaces;
using NetCoreProje.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IUrunRepository _urunRepository;
        public HomeController(IUrunRepository urunRepository)
        {
            _urunRepository = urunRepository;
        }
        public IActionResult Index()
        {
            return View(_urunRepository.GetirHepsi());
        }

        public IActionResult Ekle()
        {
            return View(new UrunEkleModel());
        }
        [HttpPost]
        public IActionResult Ekle(UrunEkleModel model)
        {
            if (ModelState.IsValid)
            {
                Urun urun = new Urun();
                if (model.Resim != null)
                {
                    var uzantı = Path.GetExtension(model.Resim.FileName); //benzersiz resim adı için
                    var yeniresimAd = Guid.NewGuid() + uzantı;
                    var yuklenecekYer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + yeniresimAd);
                    //if (model.Resim.ContentType == "image/jpeg") ; //Resim mi diye kontrol işlemi
                    var stream = new FileStream(yuklenecekYer, FileMode.Create);
                    model.Resim.CopyTo(stream);
                    urun.Resim = yeniresimAd;
                }
                
                urun.Ad = model.Ad;
                urun.Fiyat = model.Fiyat;
                _urunRepository.Ekle(urun);
                return RedirectToAction("Index", "Home", new { area = "Admin" });
            }
            return View(model);
        }

        public IActionResult Guncelle(int id)
        {
            var gelenUrun = _urunRepository.GetirIdile(id); //güncellenecek model
            UrunGuncelleModel model = new UrunGuncelleModel
            {
                Ad = gelenUrun.Ad,
                Fiyat = gelenUrun.Fiyat,
                Id = gelenUrun.Id,
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Guncelle(UrunGuncelleModel model)
        {
            if (ModelState.IsValid)
            {
                var guncellenecekUrun = _urunRepository.GetirIdile(model.Id);
                if (model.Resim != null)
                {
                    var uzantı = Path.GetExtension(model.Resim.FileName); //benzersiz resim adı için
                    var yeniresimAd = Guid.NewGuid() + uzantı;
                    var yuklenecekYer = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/" + yeniresimAd);
                    //if (model.Resim.ContentType == "image/jpeg") ; //Resim mi diye kontrol işlemi
                    var stream = new FileStream(yuklenecekYer, FileMode.Create);
                    model.Resim.CopyTo(stream);
                    guncellenecekUrun.Resim = yeniresimAd;
                }
                guncellenecekUrun.Ad = model.Ad;
                guncellenecekUrun.Fiyat = model.Fiyat;
                _urunRepository.Guncelle(guncellenecekUrun);
                return RedirectToAction("Index", "Home", new { area = "Admin" });

            }
            return View(model);
        }
        public IActionResult Sil(int id)
        {
            _urunRepository.Sil(new Urun { Id = id });
            return RedirectToAction("Index");
        }
    }
}
