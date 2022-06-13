using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using zetutrade.Models;
using zetutrade_DataAccess.Data;
using zetutrade_Model.Models;

namespace zetutrade.Controllers
{
    [AllowAnonymous]
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;
        private readonly IStringLocalizer<HomeController> _localizer;
        public static System.Globalization.CultureInfo CurrentCulture { get; set; }
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db , IStringLocalizer<HomeController> localizer)
        {
            _logger = logger;
            _db = db;
            _localizer = localizer;
        }
        public IActionResult Index()
        {
            ViewBag.Subscribe = TempData["subscribe"];
            var lang = Request.RouteValues["culture"];
            if (lang == null)
            {
                return Redirect($"/en-US");
            }
            return View();           
        }      
        public IActionResult Iletisim()
        {
            ViewBag.Subscribe = TempData["subscribe"];
            ViewBag.contact = TempData["contact"];
            return View();
        }
        [HttpPost]
        public IActionResult Iletisim(string nameSurname, string email, string subject, string message)
        {

            var add = new Contact
            {
                nameSurname = nameSurname,
                email = email,
                subject = subject,
                message = message,
                status = 1 ,
                createtime = DateTime.Now,
            };
            _db.Contacts.Add(add);
            _db.SaveChanges();
            TempData["contact"] = string.Format("yes");
            return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
        }
        [HttpPost]
        public IActionResult subscribe(string subsEmail)
        {
            var mail = _db.Subscribers.FirstOrDefault(a => a.subsEmail == subsEmail);
            if(mail == null)
            {
                var add = new Subscriber
                {
                    subsEmail = subsEmail,
                };
                _db.Subscribers.Add(add);
                _db.SaveChanges();
                TempData["subscribe"] = string.Format("yes");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
            else
            {
                TempData["subscribe"] = string.Format("no");
                return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
            }
        }
        public IActionResult Hakkimizda()
        {
            ViewBag.Subscribe = TempData["subscribe"];
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.Subscribe = TempData["subscribe"];
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Login(string email, string password)
        {           
            var user = _db.Users.FirstOrDefault(x => x.userEmail == email && x.userPassword == password);

            if(user != null)
            {
                var claims = new List<Claim>
                {
                    new Claim (ClaimTypes.Name,email)
                };
                var useridentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            };          
        }       
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Hata()
        {
            
            ViewBag.Subscribe = TempData["subscribe"];

            return View();
        }
    }
}
