using _4.PassObjectListControllertoView.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PassObjectListControllertoView.Models;

namespace _PassObjectListControllertoView.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id="p01",
                    Name="Name 1",
                    Photo="bird.png",
                    Price=5.5,
                    Quantity=4
                },
                new Product
                {
                    Id="p02",
                    Name="Name 2",
                    Photo="congo.png",
                    Price=7,
                    Quantity=3
                },
                 new Product
                {
                    Id="p03",
                    Name="Name 3",
                    Photo="fish.png",
                    Price=8,
                    Quantity=6
                }

            };
            ViewBag.products = products;
            return View();
        }
    }
}
