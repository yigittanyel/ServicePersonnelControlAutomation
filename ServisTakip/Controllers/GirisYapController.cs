using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Security.Claims;
using ServisTakip.Models;
using System.Web.Security;

namespace ServisTakip.Controllers
{
    public class GirisYapController : Controller
    {
        // GET: GirisYap
        Context c = new Context();
        public ActionResult Giris()
        {
            return View();
        }
       [HttpPost]
       public ActionResult Giris(Kullanici l)
        {
            var us = c.Kullanicis.FirstOrDefault(x => x.TcKimlikNo == l.TcKimlikNo && x.Sifre == l.Sifre);
            if (us != null){
                FormsAuthentication.SetAuthCookie(l.TcKimlikNo, true);
                return RedirectToAction("KisiListele", "Kisi");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Cikis()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Giris");
        }
    }
}