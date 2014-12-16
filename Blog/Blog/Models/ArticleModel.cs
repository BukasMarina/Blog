using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class ArticleModel
    {
        private readonly PostModel post;
        private readonly ICollection<CommentModel> comments;

        public ArticleModel() { }

        public ArticleModel(PostModel post, ICollection<CommentModel> comments)
        {
            this.post = post;
            this.comments = comments;
        }

        public PostModel Post
        {
            get
            {
                return post;
            }
        }

        public ICollection<CommentModel> Comments
        {
            get
            {
                return comments;
            }
        }
        public AddCommentModel NewComment { get; set; }
    }
}