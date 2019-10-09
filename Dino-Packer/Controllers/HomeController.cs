using Microsoft.AspNetCore.Mvc;

namespace DinoPacker.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}