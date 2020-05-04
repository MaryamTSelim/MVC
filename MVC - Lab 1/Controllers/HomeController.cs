using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC___Lab_1.Models;

namespace MVC___Lab_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Index(User newUser)
        {
            Console.WriteLine(newUser.Username);
            UserUtil.Push(newUser);
            return View();

        }

        [Route("List")]
        public ActionResult List()
        {
            return RedirectToAction("Index", "List");
        }




        }
}
