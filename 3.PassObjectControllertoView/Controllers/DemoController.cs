using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _3.PassObjectControllertoView.Models;
namespace _3.PassObjectControllertoView.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            Product product = new Product
            {
                Id = "p01",
                Name = "Name 1",
                Photo = "bird.png",
                Price = 5.5,
                Quantity = 4
            };

            ViewBag.product = product;
            return View();
        }
    }
}
