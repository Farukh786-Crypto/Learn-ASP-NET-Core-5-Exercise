﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imagecssjavascript.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
{
    [Route("index")]
    [Route("")]
    [Route("~/")]
    public IActionResult Index()
    {
        return View();
    }
}
}
