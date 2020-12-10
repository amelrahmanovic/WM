using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WM.Models;

namespace WM.Data_Access_Layer
{
    public class ProizvodacDAO
    {
        sql s = new sql();
        public List<Proizvodac> getAll()
        {
            return s.Proizvodac.ToList();
        }
    }
}