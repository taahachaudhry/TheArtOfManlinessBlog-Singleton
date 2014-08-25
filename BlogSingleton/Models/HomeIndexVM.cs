using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSingleton.Models
{
    public class HomeIndexVM
    {
        public BlogPost FeaturedPost { get; set; }
        public List<BlogPost> BlogPosts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Author> Authors { get; set; }
        public HomeIndexVM()
        {
            BlogPosts = new List<BlogPost>();
            Comments = new List<Comment>();
            Authors = new List<Author>();
        }
    }
}