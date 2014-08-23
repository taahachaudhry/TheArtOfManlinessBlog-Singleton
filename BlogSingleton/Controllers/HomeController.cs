using BlogSingleton.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogSingleton.Controllers
{
    public class HomeController : Controller
    {
        List<BlogPost> blogposts = Singleton.Instance.BlogPosts;
        List<Comment> comments = Singleton.Instance.Comments;
        public ActionResult Index()
        {
            int RandomNum = new Random().Next(blogposts.Count());
            HomeIndexVM bucket = new HomeIndexVM();
            bucket.BlogPosts = blogposts;
            bucket.FeaturedPost = bucket.BlogPosts[RandomNum];
            //bucket.BlogPosts = bucket.BlogPosts
            return View(bucket);
        }

        public ActionResult Blog()
        {
            HomeIndexVM bucket = new HomeIndexVM();
            bucket.BlogPosts = blogposts;
            
            return View(bucket);
        }

        public ActionResult BlogPost(int id)
        {
            HomeIndexVM bucket = new HomeIndexVM();
            bucket.BlogPosts.Add(blogposts.Where(x => x.ID == id).FirstOrDefault());
            bucket.Comments = comments.Where(x => x.BlogPostID == id).ToList();

            return View(bucket);
        }
    }
}