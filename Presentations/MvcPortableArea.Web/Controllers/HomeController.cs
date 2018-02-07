using AzR.Web.Root.Controllers;
using System.Web.Mvc;

namespace MvcPortableArea.Web.Controllers
{
    public class HomeController : BaseController
    {

        public ActionResult Index()
        {
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View("About");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View("Contact");
        }
    }
}