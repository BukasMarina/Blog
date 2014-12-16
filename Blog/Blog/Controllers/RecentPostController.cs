using Blog.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class RecentPostController : Controller
    {
        //
        // GET: /RecentPost/
        public ActionResult RecentPost()
        {
            Context db = new Context();
            return View(db.Posts);
        }
	}
}