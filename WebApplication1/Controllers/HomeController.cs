using System.Web.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            var _generatorService = new RandomExamService();
            ViewBag.Numbers = _generatorService.GetRandomTasksList(0, 30, 100);
            ViewBag.Message = "Задачи с + и -";

            return View();
        }
    }
}