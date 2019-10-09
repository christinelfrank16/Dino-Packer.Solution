using Microsoft.AspNetCore.Mvc;
using DinoPacker.Models;
using System.Collections.Generic;

namespace DinoPacker.Controllers
{
    public class PackController : Controller
    {

        [HttpGet("/pack")]
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet("/pack/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/pack")]
        public ActionResult Create(string item1, string item2, string item3, string item4, string item5)
        {
            Pack pack = new Pack();
            pack.AddItems(new List<string>{item1,item2,item3,item4,item5});
            return RedirectToAction("Show");
        }

        [HttpGet("/pack/myPack")]
        public ActionResult Show()
        {
            return View();
        }
    }
}