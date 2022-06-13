using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using zetutrade_DataAccess.Data;
using zetutrade_Model.Models;

namespace zetutrade.Controllers
{
    public class BaseController : Controller
    {
        private static List<string> _langs = new List<string> {
            "tr-TR",
            "en-US"
        };

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var req = context.HttpContext.Request;
            if (req.RouteValues["culture"] == null)
            {
                GoDefaultLanguagePage(context, req.Path);
                return;
            }

            var currentLang = req.RouteValues["culture"];
            if(!_langs.Contains(currentLang))
            {
                GoDefaultLanguagePage(context, req.Path);
                return;
            }

            ViewData["lang"] = req.RouteValues["culture"];

            base.OnActionExecuting(context);
        }

        public void GoDefaultLanguagePage(ActionExecutingContext context, string requestPath)
        {
            var culturePath = $"/en-US{requestPath}";
            context.HttpContext.Response.Redirect(culturePath);
        }
    }
}
