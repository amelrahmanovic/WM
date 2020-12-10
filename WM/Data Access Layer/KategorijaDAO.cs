using log4net;
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
            try
            {
                return s.Kategorija.ToList();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("mylog");
                log.Error(ex.Message);
            }
            return new List<Kategorija>();
        }
    }
}