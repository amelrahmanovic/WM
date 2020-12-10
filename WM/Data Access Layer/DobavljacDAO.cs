using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WM.Models;

namespace WM.Data_Access_Layer
{
    public class DobavljacDAO
    {
        sql s = new sql();
        public List<Dobavljac> getAll()
        {
            return s.Dobavljac.ToList();
        }
    }
}