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
        [HttpGet]
        public ActionResult AddPost()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddPost(string title, string post, string image)
        {
            BlogPost blogpost = new BlogPost();
            blogpost.Title = title;
            blogpost.Post = post;
            blogpost.Image = image;
            blogpost.ID = BlogSingleton.Models.BlogPost.NextID++;
            blogpost.Date = DateTime.Today;
            blogposts.Add(blogpost);

            return RedirectToAction("Blog");
        }
        public ActionResult EditBlogPost(int id)
        {
            BlogPost blogpost = blogposts.Where(x => x.ID == id).FirstOrDefault();
            return View(blogpost);
        }
        [HttpPost]
        public ActionResult EditBlogPost(BlogPost blogpost)
        {
            var bp = blogposts.Where(x => x.ID == blogpost.ID).FirstOrDefault();
            if (bp.GetType().ToString() == "BlogSingleton.Models.BlogPost")
            {
                BlogPost oldPost = (BlogPost)bp;
                oldPost.Title = blogpost.Title;
                oldPost.Post = blogpost.Post;
                oldPost.Image = blogpost.Image;
            }
            return RedirectToAction("BlogPost", new { id = blogpost.ID });
        }
        public ActionResult Delete(int id)
        {
            var target = blogposts.Where(x => x.ID == id).FirstOrDefault();
            blogposts.Remove(target);

            return RedirectToAction("Blog");
        }
        [HttpGet]
        public ActionResult AddComment(int id)
        {
            var blogpost = blogposts.Where(x => x.ID == id).FirstOrDefault();
            return View(blogpost);
        }
        [HttpPost]
        public ActionResult AddComment(string name, string message, int blogpostid)
        {
            Comment comment = new Comment();
            comment.Name = name;
            comment.Message = message;
            comment.CommentID = Comment.NextCommentID++;
            comment.BlogPostID = blogpostid;
            comment.Date = DateTime.Today;
            comments.Add(comment);

            return RedirectToAction("BlogPost", new {id = blogpostid});
        }
        [HttpPost]
        public ActionResult DeleteComment(int id)
        {
            var target = comments.Where(x => x.CommentID == id).FirstOrDefault();
            comments.Remove(target);

            return RedirectToAction("Blog");
        }
    }
}