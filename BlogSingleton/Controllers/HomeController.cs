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
            return View();
        }

        public ActionResult Blog()
        {
            HomeIndexVM bucket = new HomeIndexVM();
            bucket.BlogPosts = blogposts;
            
            return View(bucket);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}