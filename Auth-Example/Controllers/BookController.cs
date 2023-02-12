using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Auth_Example.Controllers
{
    //[Authorize]
    public class BookController : Controller
    {
        // GET: Book    
        public ActionResult Index()
        {
            return View();
        }
    }
}