using ServisTakip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServisTakip.Controllers
{

    public class ServisController : Controller
    {
        // GET: Servis
        Context c = new Context();
        //SERVİS LİSTELE
        public ActionResult ServisListele()
        {
            var servisList = c.Servis.ToList();
            return View(servisList);
        }

        //SERVİS SİL
        public ActionResult ServisSil(int id)
        {
            var x = c.Servis.FirstOrDefault(a => a.ServisId == id);
            c.Servis.Remove(x);
            c.SaveChanges();
            return RedirectToAction("ServisListele");
        }
        //ID'YE GÖRE SERVİS GETİRME
        public ActionResult ServisGetir(int id)
        {
            //List<SelectListItem> dep = (from x in c.Servis.ToList()
            //                            select new SelectListItem
            //                            {
            //                                Text = x.GidilenGuzergah,
            //                                Value = x.ServisId.ToString()
            //                            }).ToList();
            //ViewBag.dp = dep;
            var d = c.Servis.Find(id);
            return View("ServisGetir", d);
        }

        [HttpPost]
        public ActionResult ServisGuncelle(Servis p)
        {

            var x = c.Servis.FirstOrDefault(a => a.ServisId == p.ServisId);
            x.ServisId = p.ServisId;
            x.Plaka = p.Plaka;
            x.SoforAdi = p.SoforAdi;
            x.SoforSoyadi = p.SoforSoyadi;
            x.SoforTelefon = p.SoforTelefon;
            x.GidilenGuzergah = p.GidilenGuzergah;
            x.GuzergahDetay = p.GuzergahDetay;
            c.SaveChanges();
            return RedirectToAction("ServisListele");
        }

        [HttpGet]
        public ActionResult YeniServisEkle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult YeniServisEkle(Servis p)
        {
            c.Servis.Add(p);
            c.SaveChanges();
            return RedirectToAction("ServisListele");
        }
    }
}