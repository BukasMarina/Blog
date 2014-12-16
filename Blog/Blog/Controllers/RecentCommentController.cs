using Blog.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class RecentCommentController : Controller
    {
        //
        // GET: /RecentComment/
        public ActionResult RecentComment()
        {
            Context db = new Context();
            return View(db.Comments);
        }
	}
}