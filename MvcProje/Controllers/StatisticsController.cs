using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProje.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        Context context = new Context();
        public ActionResult Index()
        {
            var result = context.Categories.Count();
            var result2 = context.Headings.Count(c => c.Category.CategoryID == 7);
            var result3 = context.Writers.Count(c => c.WriterName.Contains("a"));
            var result4 = context.Headings.Max(c => c.Category.CategoryName);
            var result5 = context.Categories.Count(c => c.CategoryStatus == true);
            var result6 = context.Categories.Count(c => c.CategoryStatus == false);
            ViewBag.CategoryCount = result;
            ViewBag.Heading = result2;
            ViewBag.Writer = result3;
            ViewBag.HeadingMax = result4;
            ViewBag.StatusFark = (result5 - result6);

            return View();
        }
    }
}