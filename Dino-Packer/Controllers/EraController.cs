using Microsoft.AspNetCore.Mvc;
using DinoPacker.Models;
using System.Collections.Generic;
using System;

namespace DinoPacker.Controllers
{
    public class EraController : Controller
    {
        [HttpGet("/era/jurassic")]
        public ActionResult Jurassic()
        {
            return View();
        }
        [HttpGet("/era/triassic")]
        public ActionResult Triassic()
        {
            return View();
        }
        [HttpGet("/era/cretaceous")]
        public ActionResult Cretaceous()
        {
            return View();
        }
    }
}