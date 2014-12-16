using Blog.Models;
using Blog.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index(string title)
        {
            if (title == null)
            {
                title = "This is my first title";
            }

            using (var ctx = new Context())
            {
                var post = ctx.Posts.Where(p => p.Title == title).FirstOrDefault();
                var postModel = new PostModel(post.Title, post.Body, post.DateCreated);
                var commentModel = new Collection<CommentModel>();
                if (post.Comments != null && post.Comments.Any())
                {
                    foreach (var item in post.Comments)
                    {
                        CommentModel comment = new CommentModel(item.ID, item.Name, item.Body);
                        commentModel.Add(comment);
                    }
                }
                return View(new ArticleModel(postModel, commentModel));
            }
        }

        [HttpPost]
        public ActionResult Index(ArticleModel model, string title)
        {

            if (model.NewComment != null && ModelState.IsValid)
            {

                using (var ctx = new Context())
                {
                    var post = ctx.Posts.Where(p => p.Title == title).FirstOrDefault();
                    if (post != null)
                    {
                        ctx.Comments.Add(new Comment() { Body = model.NewComment.Comment, PostID = post.ID, Name = model.NewComment.Name });
                        ctx.SaveChanges();
                    }
                }
                ModelState.Clear();
                return RedirectToAction("Index", new { title = title });
            }

            return View(model);
        }
    }
}