using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WM.Models;

namespace WM.Data_Access_Layer
{
    public class KategorijaDAO
    {
        sql s = new sql();
        public List<Kategorija> getAll()
        {
            return s.Kategorija.ToList();
        }
    }
}