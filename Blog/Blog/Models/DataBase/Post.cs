using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models.DataBase
{
    public class Post : Base
    {
        public string Title { get; set; }

        public string Body { get; set; }

        public DateTime DateCreated { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}