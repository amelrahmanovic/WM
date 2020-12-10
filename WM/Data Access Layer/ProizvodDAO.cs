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
    }
}