using log4net;
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
            try
            {
                return s.Dobavljac.ToList();
            }
            catch (Exception ex)
            {
                ILog log = LogManager.GetLogger("mylog");
                log.Error(ex.Message);
            }
            return new List<Dobavljac>();
        }
    }
}