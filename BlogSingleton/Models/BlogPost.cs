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
        public DateTime Date { get; set; }
        public BlogPost(string title, string post)
        {
            ID = NextID++;
            Title = title;
            Post = post;
            Date = DateTime.Today;
        }
        public BlogPost()
        {

        }
        public int IncrementID()
        {
            return NextID++;
        }
    }
}