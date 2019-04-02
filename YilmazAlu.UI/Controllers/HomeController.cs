using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using YilmazAlu.BOL.Entities;
using YilmazAlu.Repositories;

namespace YilmazAluUI.Controllers
{
    public class HomeController : Controller
    {
        Repository<Admin> repoAdmin = new Repository<Admin>();
        public ActionResult Index()
        {
            Repository<IsOrtak> repoIsOrtak = new Repository<IsOrtak>();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Login(string ReturnUrl)
        {
            ViewBag.rURL = ReturnUrl;
            return View();
        }
       [HttpPost,ValidateAntiForgeryToken]
        public ActionResult Login(string kullaniciAdi,string pass,string rURL)
        {
            ViewBag.rtn = rURL;
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(pass))
            {
                Admin admin = repoAdmin.GetBy(a => a.KullaniciAdi == kullaniciAdi && a.Sifre == pass && a.Role=="admin");
                Admin member = repoAdmin.GetBy(a => a.KullaniciAdi == kullaniciAdi && a.Sifre == pass && a.Role == "member");
                if (admin != null)
                {
                    FormsAuthentication.SetAuthCookie("#" + kullaniciAdi, true);
                    Session["AdSoyad"] = admin.IsimSoyisim;
                    if (!string.IsNullOrEmpty(rURL)) return Redirect(rURL);
                    else return Redirect("/Yonetim/Admin/Index");
                }
                if (member != null)
                {
                    FormsAuthentication.SetAuthCookie(kullaniciAdi, true);
                    Session["AdSoyad"] = member.IsimSoyisim;
                    if (!string.IsNullOrEmpty(rURL)) return Redirect(rURL);
                    else return Redirect("/Yonetim/Admin/Index");
                }
                else
                {                    
                    ViewBag.Hata = "Kullanıcı Adı veya Şifre Hatalı";
                }
            }
            else ViewBag.Hata = "Kullanıcı Adı ve Şifre Gerekli";
            return View();
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}