using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zetutrade.Controllers
{
    [AllowAnonymous]
    public class HizmetlerController : BaseController
    {
        public IActionResult Index()
        {
            ViewBag.Subscribe = TempData["subscribe"];
            return View();
        }
    }
}
