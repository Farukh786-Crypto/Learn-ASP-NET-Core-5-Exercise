using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2.PassdataControllertoView.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.age = 20;
            ViewBag.fullName = "kevin";
            ViewBag.status = true;
            ViewBag.price = 4.5;
            ViewBag.birthday = DateTime.Now;
            return View();
        }
    }
}
