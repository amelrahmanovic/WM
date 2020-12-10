using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using WM.Data_Access_Layer;
using WM.Models;

namespace WM.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProizvodDAO proizvodDAO = new ProizvodDAO();

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(proizvodDAO.getAll());

            // Write the string array to a new file named "WriteLines.json".
            //using (StreamWriter outputFile = new StreamWriter(Path.Combine(@"C:\Users\Amel\Desktop\", "Proizvodi.json")))
            //{
            //    outputFile.WriteLine(json);
            //}
            return View(proizvodDAO.getAll());
        }
        public ActionResult NoviEditProizvod(int? Id)
        {
            KategorijaDAO kategorijaDAO = new KategorijaDAO();
            ViewData["Kategorije"] = kategorijaDAO.getAll();
            DobavljacDAO dobavljacDAO = new DobavljacDAO();
            ViewData["Dobavljaci"] = dobavljacDAO.getAll();
            ProizvodacDAO proizvodacDAO = new ProizvodacDAO();
            ViewData["Proizvodaci"] = proizvodacDAO.getAll();
            if (Id != null)
            {
                ProizvodDAO proizvodDAO = new ProizvodDAO();
                ViewData["Proizvod"] = proizvodDAO.Find(Int32.Parse(Id.ToString()));
            }
            else
                ViewData["Proizvod"] = new Proizvod();

            return View();
        }
        public ActionResult SnimiProizvod(int Id, string NazivProizvoda, string OpisProizvoda, string CenaProizvoda, int Kategorija, int Dobavljac, int Proizvodac)
        {
            ProizvodDAO proizvodDAO = new ProizvodDAO();
            proizvodDAO.Add(new Proizvod() { Id=Id, Naziv = NazivProizvoda, Opis = OpisProizvoda, Cena = CenaProizvoda, KategorijaId = Kategorija, DobavljacId = Dobavljac, ProizvodacId = Proizvodac });
            return RedirectToAction("", "Home");
        }
        public ActionResult DeleteProizvod(int Id)
        {
            ProizvodDAO proizvodDAO = new ProizvodDAO();
            proizvodDAO.Delete(Id);
            return RedirectToAction("", "Home");
        }
    }
}