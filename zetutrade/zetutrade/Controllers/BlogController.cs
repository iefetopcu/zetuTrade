using Microsoft.AspNetCore.Authorization;
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

namespace zetutrade.Controllers
{
    [AllowAnonymous]
    public class BlogController : BaseController
    {
        private readonly ILogger<UrunlerController> _logger;
        private readonly ApplicationDbContext _db;
        public BlogController(ILogger<UrunlerController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            var language = RouteData.Values["culture"].ToString();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            var blogList = (from x in _db.Blogs
                            orderby x.releasetime descending
                            select x
                               ).Include(a => a.BlogTexts.Where(x => x.Language == language)).ToList();
           
            ViewBag.Subscribe = TempData["subscribe"];
            return View(blogList);
        }
        public IActionResult BlogOku(string url)
        {

            var language = RouteData.Values["culture"].ToString();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            var blog = (from i in _db.BlogTexts
                           join pr in _db.Blogs on i.blogID equals pr.blogID
                           where i.Language == language
                           && i.url == url
                           select i
                           ).FirstOrDefault();
            if(blog != null)
            {
                ViewBag.Photourl = (from i in _db.Blogs
                                    where i.blogID == blog.blogID
                                    select i.blogPhoto).FirstOrDefault().ToString();
                ViewBag.time = (from i in _db.Blogs
                                where i.blogID == blog.blogID
                                select i.releasetime).FirstOrDefault().ToString("dd-mm-yyyy");
                ViewBag.View = (from i in _db.Blogs
                                where i.blogID == blog.blogID
                                select i.blogviews).FirstOrDefault().ToString();
                var blogview = _db.Blogs.FirstOrDefault(x => x.blogID == blog.blogID);

                blogview.blogviews += 1;
                _db.SaveChanges();

                return View(blog);
            }
            else
            {
                return RedirectToAction("Hata", "Home");
            }


        }
    }
}
