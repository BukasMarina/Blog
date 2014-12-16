using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class CommentModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
        public CommentModel(int ID, string Name, string Body) 
        {
            this.ID = ID;
            this.Name = Name;
            this.Body = Body;
        }
    }
}