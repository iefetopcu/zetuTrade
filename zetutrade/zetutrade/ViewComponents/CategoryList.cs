using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zetutrade_DataAccess.Data;

namespace zetutrade.ViewComponents
{
    public class CategoryList : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public CategoryList(ApplicationDbContext db)
        {
            _db = db;
        }
        public IViewComponentResult Invoke()
        {
           var categorylist = _db.Categories.Include(a => a.CategoryTexts.Where(s => s.Language == "tr-TR")).ToList();
           return View(categorylist);
        }
    }
}
