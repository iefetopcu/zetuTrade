using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using zetutrade_DataAccess.Data;
using zetutrade_Model.Models;

namespace zetutrade.Controllers
{
    [AllowAnonymous]
    public class UrunlerController : BaseController
    {
        private readonly ILogger<UrunlerController> _logger;
        private readonly ApplicationDbContext _db;
        public UrunlerController(ILogger<UrunlerController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            
            var language = RouteData.Values["culture"].ToString();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            ViewBag.Subscribe = TempData["subscribe"];
            ViewBag.Language = language;
            var productlist = _db.Products.Include(a => a.Category).
                Include(a => a.ProductTexts.Where(x=> x.Language == language)).
                Include(a => a.Category.CategoryTexts.Where(x => x.Language == language)).ToList();

            return View(productlist);
        }

        public IActionResult Urun(string url)
        {
            var language = RouteData.Values["culture"].ToString();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            var product = (from i in _db.ProductTexts
                           join pr in _db.Products on i.productID equals pr.productID
                           where i.Language == language
                           && i.url == url
                           select i
                           ).FirstOrDefault();
            
            
            
            if (product != null)
            {
                ViewBag.Shareurl = "https://localhost:44360/"+language+"/Urunler/Urun?url="+url;
                ViewBag.Photourl =  (from i in _db.Products
                                    where i.productID == product.productID
                                    select i.productPhotoUrl).FirstOrDefault().ToString();
                return View(product);
            }
            else
            {
                return RedirectToAction("Hata","Home");
            }           
        }
        public IActionResult Siparis(string url)
        {
            ViewBag.Subscribe = TempData["subscribe"];
            ViewBag.product = TempData["product"];
            var language = RouteData.Values["culture"].ToString();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            var product = (from i in _db.ProductTexts
                           join pr in _db.Products on i.productID equals pr.productID
                           where i.Language == language
                           && i.url == url
                           select i
                           ).FirstOrDefault();



            if (product != null)
            {
                ViewBag.Shareurl = "https://localhost:44360/Urunler/Urun?url=" + url;
                ViewBag.Photourl = (from i in _db.Products
                                    where i.productID == product.productID
                                    select i.productPhotoUrl).FirstOrDefault().ToString();
                return View(product);
            }
            else
            {
                return RedirectToAction("Hata", "Home");
            }                               
        }
        [HttpPost]
        public IActionResult Siparis(int productID, string orderEmail, string orderNameSurname, string orderAddress, int orderNumber)
        {
            var add = new Order
            {
                productID = productID,
                orderAddress = orderAddress,
                orderNumber = orderNumber,
                orderNameSurname = orderNameSurname,
                orderEmail = orderEmail,
                ordertime = DateTime.Now,
            };
            _db.Orders.Add(add);
            _db.SaveChanges();
            TempData["product"] = string.Format("yes");
            return Redirect(ControllerContext.HttpContext.Request.GetTypedHeaders().Referer.ToString());
        }

    }
}
