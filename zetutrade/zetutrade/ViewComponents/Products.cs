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
    public class Products : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public Products(ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            var language = RouteData.Values["culture"].ToString();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);

            if (language == null)
            {
                
                var productlist = _db.Products.Include(a => a.Category).
                Include(a => a.ProductTexts.Where(x => x.Language == "en-US")).
                ToList();
                return View(productlist);
            }
            else
            {
                
                var productlist = _db.Products.Include(a => a.Category).
                Include(a => a.ProductTexts.Where(x => x.Language == language)).
                ToList();
                return View(productlist);
            }                      
        }
    }
}
