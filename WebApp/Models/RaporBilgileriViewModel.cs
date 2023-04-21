using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Models
{
    public class RaporBilgileriViewModel
    {

        public RaporBilgileriViewModel()
        {
            YasListesi = new List<string>();
            VKitlesiListesi = new List<string>();
            CinsiyetListesi = new List<string>();
            KanListesi = new List<string>();
            DigerIlacList = new List<string>();
            AlerjiList = new List<string>();

            IlacList = new List<SelectListItem>();
            IlacList.Add(new SelectListItem { Text = "Seçiniz", Value = "Seçiniz" });
            IlacList.Add(new SelectListItem { Text = "Parol", Value = "Parol" });
            IlacList.Add(new SelectListItem { Text = "Aferin", Value = "Aferin" });
            IlacList.Add(new SelectListItem { Text = "Gribin", Value = "Gribin" });
            IlacList.Add(new SelectListItem { Text = "Agumentin", Value = "Agumentin" });
            IlacList.Add(new SelectListItem { Text = "Keppra", Value = "Keppra" });
            IlacList.Add(new SelectListItem { Text = "Coraspin", Value = "Coraspin" });
            IlacList.Add(new SelectListItem { Text = "Dolorex", Value = "Dolorex" });
            IlacList.Add(new SelectListItem { Text = "Arveles", Value = "Arveles" });
            IlacList.Add(new SelectListItem { Text = "Lansor", Value = "Lansor" });
            IlacList.Add(new SelectListItem { Text = "Nexium", Value = "Nexium" });
            IlacList.Add(new SelectListItem { Text = "Nootropil", Value = "Nootropil" });
            IlacList.Add(new SelectListItem { Text = "Oksamnen", Value = "Oksamnen" });
            IlacList.Add(new SelectListItem { Text = "Zyprexa", Value = "Zyprexa" });
        }
        public List<string> YasListesi { get; set; }
        public List<string> VKitlesiListesi { get; set; }
        public List<string> CinsiyetListesi { get; set; }
        public List<string> KanListesi { get; set; }
        public List<string> DigerIlacList { get; set; }
        public List<string> AlerjiList { get; set; }


        public string ILAC { get; set; }
        public List<SelectListItem> IlacList { get; set; }
    }
}