using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using SignalR.Hubs;

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

        public void Task()
        {
            for (int i = 1; i <= 30; i++)
            {
                System.Threading.Thread.Sleep(1000);
                ProgressHub.NotifyUI("We are at: " + i, i);
            }
          //  return View();
        }
    }
}