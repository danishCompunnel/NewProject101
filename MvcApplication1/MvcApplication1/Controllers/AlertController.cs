using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class AlertController : Controller
    {
        //
        // GET: /Alert/

        public ActionResult Index()
        {
            //new change
            return View();
        }

    }
}
