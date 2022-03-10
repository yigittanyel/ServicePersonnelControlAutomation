using ServisTakip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServisTakip.Controllers
{
    public class KisiController : Controller
    {
        // GET: Kisi
        Context c = new Context();
        //KİŞİ LİSTELE
        //[Authorize] etme işlemi eklenecek.
        public ActionResult KisiListele()
        {
            var kisiList = c.Kisis.ToList();
            return View(kisiList);
        }
        //KİŞİ SİL
        public ActionResult KisiSil(int id)
        {
            var x = c.Kisis.FirstOrDefault(a => a.KisiId == id);
            c.Kisis.Remove(x);
            c.SaveChanges();
            return RedirectToAction("KisiListele"); 
        }

        //ID'YE GÖRE KİŞİ GETİRME
        public ActionResult KisiGetir(int id)
        {
            List<SelectListItem> dep = (from x in c.Servis.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.Plaka,
                                            Value = x.ServisId.ToString(),
                                            Selected=false
                                        }).ToList();
            ViewBag.dp = dep;
            var d = c.Kisis.Find(id);
            return View("KisiGetir", d);
        }

        [HttpPost]
        public ActionResult KisiGuncelle(Kisi p)
        {
            var x = c.Kisis.FirstOrDefault(a => a.KisiId == p.KisiId);
            x.KisiId = p.KisiId;
            x.KisiAd = p.KisiAd;
            x.KisiSoyad = p.KisiSoyad;
            x.KisiTelefon = p.KisiTelefon;
            x.Adres = p.Adres;
            x.BinilenLokasyon = p.BinilenLokasyon;
            x.ServisId = p.ServisId;
            c.SaveChanges();
            return RedirectToAction("KisiListele");
        }
        [HttpGet]
        public ActionResult YeniKisiEkle()
        {
            List<SelectListItem> dep = (from x in c.Servis.ToList()
                                        select new SelectListItem
                                        {
                                            Text = x.Plaka,
                                            Value = x.ServisId.ToString()
                                        }).ToList();

            //List<SelectListItem> der = (from x in c.Servis.ToList()
            //                            select new SelectListItem
            //                            {
            //                                Text = x.GidilenGuzergah,
            //                                Value = x.ServisId.ToString()
            //                            }).ToList();
            ViewBag.dp = dep;
            //ViewBag.dr = der;
            return View();
        }


        [HttpPost]
        public ActionResult YeniKisiEkle(Kisi p)
        {
            c.Kisis.Add(p);
            c.SaveChanges();
            return RedirectToAction("KisiListele");
        }



        //servisin plakasına göre o servisle giden kişilerin listesi
        public ActionResult KisiPlaka(int id)
        {
            var x = c.Kisis.Where(a => a.ServisId==id).ToList();
            return View(x);
        }
    }
}