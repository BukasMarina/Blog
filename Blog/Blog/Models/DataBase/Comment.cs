using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Blog.Models.DataBase
{
    public class Comment : Base
    {
        public int PostID { get; set; }

        public string Body { get; set; }

        public string Name { get; set; }

        [ForeignKey("PostID")]

        public virtual Post Post { get; set; }
    }
}