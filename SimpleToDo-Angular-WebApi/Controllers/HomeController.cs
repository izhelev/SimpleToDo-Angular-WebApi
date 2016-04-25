using System.Web.Mvc;

namespace SimpleToDo_Angular_WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
