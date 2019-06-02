using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class UrlShortenerController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new UrlViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public JsonResult Generate(UrlViewModel url)
        {
            if (ModelState.IsValid)
            {
                var urlModel = new Url();
                urlModel.LongUrl = url.LongUrl;
                urlModel.ShortUrl = Request.Url.Scheme + "://" + Request.Url.Authority+"/";
                var business = new UrlShortenerBusiness();
                var result = business.GenerateShortUrl(urlModel);
                return Json(result);
            }
            else
            {
                return Json(null);
            }
        }
    }
}
