using System.Web.Mvc;

namespace SignalR.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Task()
        {
            for (int i = 1; i <= 30; i++)
            {
                System.Threading.Thread.Sleep(1000);
            }
            return View();
        }
    }
}