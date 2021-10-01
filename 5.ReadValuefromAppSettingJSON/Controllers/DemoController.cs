using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _5.ReadValuefromAppSettingJSON.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private IConfiguration configuration;
        public DemoController(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        [Route("index")]
        [Route("")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.result1 = configuration["Message"];
            ViewBag.result2 = configuration["MyConfigs:Config1"];
            ViewBag.result3 = configuration["MyConfigs:Config2"];
            ViewBag.result4 = configuration["MyConfigs:Config3"];
            ViewBag.result5 = configuration["Logging:Debug:LogLevel:Default"];
            return View();
        }
    }
}
