using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Senhas.Controllers
{
    public class DashBoardController : Controller
    {
        // GET: DashBoardt
        public ActionResult Index()
        {
            return View();
        }
    }
}