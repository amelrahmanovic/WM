using log4net;
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
            try
            {
                return s.Proizvod.Include("Kategorija").Include("Dobavljac").Include("Proizvodac").ToList();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("mylog");
                log.Error(ex.Message);
            }
            return new List<Proizvod>();  
        }
        public void Add(Proizvod proizvod)
        {
            try
            {
                Proizvod p;
                if (proizvod.Id == 0)
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
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("mylog");
                log.Error(ex.Message);
            }
        }
        public Proizvod Find(int Id)
        {
            try
            {
                return s.Proizvod.SingleOrDefault(x => x.Id == Id);
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("mylog");
                log.Error(ex.Message);
            }
            return new Proizvod();
        }
        public void Delete(int Id)
        {
            try
            {
                s.Proizvod.Remove(Find(Id));
                s.SaveChanges();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("mylog");
                log.Error(ex.Message);
            }
        }
    }
}