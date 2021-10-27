using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetCoreProje.Entities;
using NetCoreProje.Interfaces;
using NetCoreProje.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IUrunRepository _urunRepository;
        public HomeController(IUrunRepository urunRepository, SignInManager<AppUser> signInManager) //bir urun repo'ya karşı neyi örnekliyosa onu verecek
        {
            _signInManager = signInManager;
            _urunRepository = urunRepository;
        }
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            //SetSession("kisi", "bircan");
            //SetCookie("kisi", "bircan");  //cookie için
            return View(_urunRepository.GetirHepsi());
            
        }

        //public IActionResult Privacy()
        //{
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

        public IActionResult UrunDetay(int id)
        {
            //ViewBag.Cookie = GetCookie("kisi");
            //ViewBag.Session = GetSession("kisi");
            return View(_urunRepository.GetirIdile(id));
        }

        public IActionResult GirisYap()
        {
            return View(new KullanıcıGirisModel());
        }
        [HttpPost]
        public async Task<IActionResult> GirisYap(KullanıcıGirisModel model)
        {
            if (ModelState.IsValid)
            {
                var signInResult =await _signInManager.PasswordSignInAsync(model.KullaniciAd, model.Sifre, model.BeniHatirla, false); //false eğer 5 defa üst üste yanlış girişte kitleme olmasın diye
                if (signInResult.Succeeded)
                {
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
            }
            return View(model);
        }

        //session sunucu tabanlı
        //cookie client tabanlı

        #region session
        //public void SetSession(string key, string value)
        //{
        //    HttpContext.Session.SetString(key, value);
        //}

        //public string GetSession(string key)
        //{
        //    return HttpContext.Session.GetString(key);

        //}
        #endregion
        #region cookie

        //public void SetCookie(string key , string value)
        //{
        //    HttpContext.Response.Cookies.Append(key, value);
        //}

        //public string GetCookie(string key)
        //{
        //    HttpContext.Request.Cookies.TryGetValue(key, out string value);
        //    return value;
        //    //session=tarayıcı kapanınca gider
        //    //httponly=false ; jscripte açıktır (document.cookie)
        //}

        #endregion
    }
}
