using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;

namespace WebApplication.Controllers
{
    public class UrlShortenerController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Url());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Generate(Url url)
        {
            if (ModelState.IsValid)
            {
                var business = new UrlShortenerBusiness();
                var result = business.GenerateShortUrl(url);
                return Json(result);
            }
            else
            {
                return Json(null);
            }
        }
    }
}
