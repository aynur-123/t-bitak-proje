using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Models
{
    public class KisiBilgileriViewModel
    {
        public KisiBilgileriViewModel()
        {
            IlacList = new List<SelectListItem>();
            IlacList.Add(new SelectListItem { Text = "Parol" ,Value= "Parol" });
            IlacList.Add(new SelectListItem { Text = "Aferin", Value="Aferin"});
            IlacList.Add(new SelectListItem { Text = "Gribin", Value= "Gribin" });
            IlacList.Add(new SelectListItem { Text = "Agumentin", Value= "Agumentin" });
            IlacList.Add(new SelectListItem { Text = "Keppra", Value = "Keppra" });
            IlacList.Add(new SelectListItem { Text = "Coraspin", Value = "Coraspin" });
            IlacList.Add(new SelectListItem { Text = "Dolorex", Value = "Dolorex" });
            IlacList.Add(new SelectListItem { Text = "Arveles", Value = "Arveles" });
            IlacList.Add(new SelectListItem { Text = "Lansor", Value = "Lansor" });
            IlacList.Add(new SelectListItem { Text = "Nexium", Value = "Nexium" });
            IlacList.Add(new SelectListItem { Text = "Nootropil", Value = "Nootropil" });
            IlacList.Add(new SelectListItem { Text = "Oksamnen", Value = "Oksamnen" });
            IlacList.Add(new SelectListItem { Text = "Zyprexa", Value = "Zyprexa" });

            CinsiyetList = new List<SelectListItem>();
            CinsiyetList.Add(new SelectListItem { Text = "Erkek", Value = "Erkek" });
            CinsiyetList.Add(new SelectListItem { Text = "Kadın", Value = "Kadın" });
           
            KanGrubuList = new List<SelectListItem>();
            KanGrubuList.Add(new SelectListItem { Text = "A+", Value = "A+" });
            KanGrubuList.Add(new SelectListItem { Text = "A-", Value = "A-" });
            KanGrubuList.Add(new SelectListItem { Text = "B+", Value = "B+" });
            KanGrubuList.Add(new SelectListItem { Text = "B-", Value = "B-" });
            KanGrubuList.Add(new SelectListItem { Text = "0+", Value = "0+" });
            KanGrubuList.Add(new SelectListItem { Text = "0-", Value = "0-" });
            KanGrubuList.Add(new SelectListItem { Text = "AB+", Value = "AB+" });
            KanGrubuList.Add(new SelectListItem { Text = "AB-", Value = "AB-" });

            DigerIlacList = new List<SelectListItem>();
            DigerIlacList.Add(new SelectListItem { Text = "yok", Value = "yok" });
            DigerIlacList.Add(new SelectListItem { Text = "Nimes", Value = "Nimes" });
            DigerIlacList.Add(new SelectListItem { Text = "Ibucold", Value = "Ibucold" });
            DigerIlacList.Add(new SelectListItem { Text = "Parol", Value = "Parol" });
            DigerIlacList.Add(new SelectListItem { Text = "Aferin", Value = "Aferin" });
            DigerIlacList.Add(new SelectListItem { Text = "Gribin", Value = "Gribin" });
            DigerIlacList.Add(new SelectListItem { Text = "Agumentin", Value = "Agumentin" });
            DigerIlacList.Add(new SelectListItem { Text = "Keppra", Value = "Keppra" });
            DigerIlacList.Add(new SelectListItem { Text = "Coraspin", Value = "Coraspin" });
            DigerIlacList.Add(new SelectListItem { Text = "Dolorex", Value = "Dolorex" });
            DigerIlacList.Add(new SelectListItem { Text = "Arveles", Value = "Arveles" });
            DigerIlacList.Add(new SelectListItem { Text = "Lansor", Value = "Lansor" });
            DigerIlacList.Add(new SelectListItem { Text = "Nexium", Value = "Nexium" });
            DigerIlacList.Add(new SelectListItem { Text = "Nootropil", Value = "Nootropil" });
            DigerIlacList.Add(new SelectListItem { Text = "Oksamnen", Value = "Oksamnen" });
            DigerIlacList.Add(new SelectListItem { Text = "Zyprexa", Value = "Zyprexa" });

            AlerjiList = new List<SelectListItem>();
            AlerjiList.Add(new SelectListItem { Text = "yok", Value = "yok" });
            AlerjiList.Add(new SelectListItem { Text = "Kaşıntı", Value = "Kaşıntı" });
            AlerjiList.Add(new SelectListItem { Text = "Ateş", Value = "Ateş" });
            AlerjiList.Add(new SelectListItem { Text = "Öksürük", Value = "Öksürük" });
            AlerjiList.Add(new SelectListItem { Text = "Ciltte kızarıklık ve döküntü", Value = "Ciltte kızarıklık ve döküntü" });
            AlerjiList.Add(new SelectListItem { Text = "Nefes Darlığı", Value = "Nefes Darlığı" });
            AlerjiList.Add(new SelectListItem { Text = "Burunda Akıntı", Value = "Burunda Akıntı" });
            AlerjiList.Add(new SelectListItem { Text = "İshal", Value = "İshal" });
            AlerjiList.Add(new SelectListItem { Text = "Kusma", Value = "Kusma" });

        }
        public int ID { get; set; }
        public string ADSOYAD { get; set; }
        public string CINSIYET { get; set; }
        public List<SelectListItem> CinsiyetList { get; set; }
        public Nullable<int> YAS { get; set; }
        public Nullable<int> KILO { get; set; }
        public Nullable<int> BOY { get; set; }
        public string KANGRUBU { get; set; }

        public List<SelectListItem> KanGrubuList { get; set; }
        public string ILAC { get; set; }
        public List<SelectListItem> IlacList { get; set; }
        public string DIGERILAC { get; set; }
        public List<SelectListItem> DigerIlacList { get; set; }

        public string ALERJILERI { get; set; }
        public List<SelectListItem> AlerjiList { get; set; }

        public string YANETKI { get; set; }


    }
}