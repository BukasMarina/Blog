using Blog.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class LatestPostController : Controller
    {
        //
        // GET: /LatestPost/
        Context db = new Context();
        public ActionResult LatestPost()
        {
            return View(db.Posts);
        }
	}
}