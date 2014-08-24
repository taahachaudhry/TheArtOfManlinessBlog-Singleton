using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSingleton.Models
{
    public class BlogPost
    {
        public static int NextID = 0;
        public int ID { get; set; }
        public string Title { get; set; }
        public string Post { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }
        public BlogPost(string title, string post, string image)
        {
            ID = NextID++;
            Title = title;
            Post = post;
            Image = image;
            Date = DateTime.Today;
        }
        public BlogPost()
        {

        }
    }
}