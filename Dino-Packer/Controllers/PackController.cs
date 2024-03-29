using Microsoft.AspNetCore.Mvc;
using DinoPacker.Models;
using System.Collections.Generic;
using System;

namespace DinoPacker.Controllers
{
    public class PackController : Controller
    {

        [HttpGet("/pack")]
        public ActionResult Index()
        {
            Pack pack = Pack.Instance;
            return View(pack);
          
        }
        [HttpGet("/pack/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/pack")]
        public ActionResult Create(string item1, string item2, string item3, string item4, string item5)
        {
            Pack pack = Pack.Instance;
            pack.AddItems(new List<string>{item1,item2,item3,item4,item5});
            return RedirectToAction("Index");
        }
        [HttpPost("/pack/checker")]
        public ActionResult PackCheck(string eraName)
        {
            DinoEra eras = new DinoEra();
            Console.WriteLine(eraName);
            Dictionary<string,DinoEra> groupModel = new Dictionary<string, DinoEra>{};
            groupModel.Add(eraName, eras);
            return View(groupModel);
        }
    }
}