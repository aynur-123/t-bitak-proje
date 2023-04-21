using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        websitesiEntities context = new websitesiEntities();
        public ActionResult Index()
        {
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

        public ActionResult VeriGiris()
        {
            KisiBilgileriViewModel viewModel = new KisiBilgileriViewModel();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult VeriGiris(KisiBilgileriViewModel model)
        {
            try
            {
                KISIBILGILERI entity = new KISIBILGILERI();
                entity.ADSOYAD = model.ADSOYAD;
                entity.YAS = model.YAS;
                entity.BOY = model.BOY;
                entity.KILO = model.KILO;
                double index = (double)model.KILO / ( ((double)model.BOY / 100) * ((double)model.BOY / 100));
                if ( index < 18.5 )
                    entity.KITLEINDEKSI = "Aşırı Zayıf";
                else if (index < 24.9  )
                    entity.KITLEINDEKSI = "Zayıf";
                else if (index < 29.9)
                    entity.KITLEINDEKSI = "Orta";
                else if (index < 29.9)
                    entity.KITLEINDEKSI = "Biraz Kilolu";
                else
                    entity.KITLEINDEKSI = "Obez";

                entity.KANGRUBU = model.KANGRUBU;
                entity.ILAC = model.ILAC;
                entity.ALERJILERI = model.ALERJILERI;
                entity.DIGERILAC = model.DIGERILAC;
                entity.CINSIYET = model.CINSIYET;
                entity.YANETKI = model.YANETKI;
                context.KISIBILGILERIs.Add(entity);
                context.SaveChanges();

                ViewBag.Mesaj = "Kayıt Başarılı";
                return View("Index");
            }
            catch (Exception)
            {
                ViewBag.Mesaj = "Kayıt Başarısız";
                return View("Index");
            }


        }

        public ActionResult Grafik()
        {
            RaporBilgileriViewModel viewModel = new RaporBilgileriViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public JsonResult dataGet(string ilac)
        {
            var kayitlar = context.KISIBILGILERIs.ToList();

            RaporBilgileriViewModel viewModel = new RaporBilgileriViewModel();


            viewModel.YasListesi.Add(kayitlar.Where(p => p.YAS < 11 && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.YasListesi.Add(kayitlar.Where(p => p.YAS >= 11 && p.YAS <= 25 && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.YasListesi.Add(kayitlar.Where(p => p.YAS >= 26 && p.YAS <= 40 && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.YasListesi.Add(kayitlar.Where(p => p.YAS >= 46 && p.ILAC == ilac).ToList().Count.ToString());

            viewModel.VKitlesiListesi.Add(kayitlar.Where(p => p.KITLEINDEKSI == "Aşırı Zayıf" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.VKitlesiListesi.Add(kayitlar.Where(p => p.KITLEINDEKSI == "Zayıf" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.VKitlesiListesi.Add(kayitlar.Where(p => p.KITLEINDEKSI == "Orta" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.VKitlesiListesi.Add(kayitlar.Where(p => p.KITLEINDEKSI == "Biraz Kilolu" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.VKitlesiListesi.Add(kayitlar.Where(p => p.KITLEINDEKSI == "Obez" && p.ILAC == ilac).ToList().Count.ToString());

            viewModel.CinsiyetListesi.Add(kayitlar.Where(p => p.CINSIYET == "Kadın" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.CinsiyetListesi.Add(kayitlar.Where(p => p.CINSIYET == "Erkek" && p.ILAC == ilac).ToList().Count.ToString());

            viewModel.KanListesi.Add(kayitlar.Where(p => p.KANGRUBU == "A+" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.KanListesi.Add(kayitlar.Where(p => p.KANGRUBU == "A-" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.KanListesi.Add(kayitlar.Where(p => p.KANGRUBU == "B+" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.KanListesi.Add(kayitlar.Where(p => p.KANGRUBU == "B-" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.KanListesi.Add(kayitlar.Where(p => p.KANGRUBU == "0+" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.KanListesi.Add(kayitlar.Where(p => p.KANGRUBU == "0-" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.KanListesi.Add(kayitlar.Where(p => p.KANGRUBU == "AB+" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.KanListesi.Add(kayitlar.Where(p => p.KANGRUBU == "AB-" && p.ILAC == ilac).ToList().Count.ToString());

            viewModel.DigerIlacList.Add(kayitlar.Where(p => p.DIGERILAC == "Nimes" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.DigerIlacList.Add(kayitlar.Where(p => p.DIGERILAC == "Ibucold" && p.ILAC == ilac).ToList().Count.ToString());

            viewModel.AlerjiList.Add(kayitlar.Where(p => p.ALERJILERI == "Ateş" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.AlerjiList.Add(kayitlar.Where(p => p.ALERJILERI == "Kaşıntı" && p.ILAC == ilac).ToList().Count.ToString());
            viewModel.AlerjiList.Add(kayitlar.Where(p => p.ALERJILERI == "Öksürük" && p.ILAC == ilac).ToList().Count.ToString());

            viewModel.ILAC = ilac;
            return Json(viewModel, JsonRequestBehavior.AllowGet);
        }
    }
}