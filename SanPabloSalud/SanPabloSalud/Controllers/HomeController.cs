using System.Web.Mvc;
using Servicios;

namespace SanPabloSalud.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServicioRepositorio _serivicio;

        public HomeController(IServicioRepositorio serivicio)
        {
            _serivicio = serivicio;
        }

        public ActionResult Index()
        {
            _serivicio.ListarPacientes("a");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}