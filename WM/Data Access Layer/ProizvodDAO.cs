using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WM.Models;

namespace WM.Data_Access_Layer
{
    public class ProizvodDAO
    {
        sql s = new sql();
        public List<Proizvod> getAll()
        {
            return s.Proizvod.Include("Kategorija").Include("Dobavljac").Include("Proizvodac").ToList();
        }
        public void Add(Proizvod proizvod)
        {
            Proizvod p;
            if (proizvod.Id==0)
                s.Proizvod.Add(proizvod);
            else
            {
                p = Find(proizvod.Id);
                p.Cena = proizvod.Cena;
                p.DobavljacId = proizvod.DobavljacId;
                p.KategorijaId = proizvod.KategorijaId;
                p.Naziv = proizvod.Naziv;
                p.Opis = proizvod.Opis;
                p.ProizvodacId = proizvod.ProizvodacId;
            }
            
            s.SaveChanges();
        }
        public Proizvod Find(int Id)
        {
            return s.Proizvod.SingleOrDefault(x => x.Id == Id);
        }
        public void Delete(int Id)
        {
            s.Proizvod.Remove(Find(Id));
            s.SaveChanges();
        }
    }
}