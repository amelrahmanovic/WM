using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WM.Models
{
    public class Proizvod
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public int KategorijaId { get; set; }
        public Kategorija Kategorija { get; set; }
        public string Proizvodjac { get; set; }
        public int DobavljacId { get; set; }
        public Dobavljac Dobavljac { get; set; }
        public string Cena { get; set; }
    }
}