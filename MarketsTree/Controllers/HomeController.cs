using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MarketsTree.Models;

namespace MarketsTree.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new MarketsDataModel();
            return View(model);
        }
    }
}