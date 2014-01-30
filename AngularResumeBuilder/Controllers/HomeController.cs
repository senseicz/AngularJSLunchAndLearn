using System.Web.Mvc;

namespace AngularResumeBuilder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ProfessionalOverview()
        {
            return View();
        }
    }
}