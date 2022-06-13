using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using zetutrade_DataAccess.Data;

namespace zetutrade.ViewComponents
{
   
    public class LastBlog : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public LastBlog(ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var language = RouteData.Values["culture"].ToString();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            var blogList = (from x in _db.Blogs
                            orderby x.releasetime descending
                            select x
                               ).Include(a => a.BlogTexts.Where(x => x.Language == language)).Take(3);

            
            return View(blogList);
        }
    }
}
