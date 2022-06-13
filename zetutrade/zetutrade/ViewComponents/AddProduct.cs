using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zetutrade_DataAccess.Data;

namespace zetutrade.ViewComponents
{
    public class AddProduct : ViewComponent

    {
        private readonly ApplicationDbContext _db;
        public AddProduct(ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
            List<SelectListItem> categorylist = (from i in _db.Categories
                                                 join ct in _db.categoryTexts on i.categoryID equals ct.categoryID
                                                 where ct.Language == "tr-TR"
                                                 select new SelectListItem
                                                 {
                                                     Text = ct.categoryName,
                                                     Value = i.categoryID.ToString()
                                                 }).ToList();

            
            ViewBag.categories = categorylist;            
            return View();
        }
    }
}
