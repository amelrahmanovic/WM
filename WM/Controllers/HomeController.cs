using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WM.Data_Access_Layer;

namespace WM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProizvodDAO proizvodDAO = new ProizvodDAO();
            return View(proizvodDAO.getAll());

        }
    }
}