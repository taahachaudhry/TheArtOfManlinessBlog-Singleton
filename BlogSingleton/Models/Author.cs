using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSingleton.Models
{
    public class Author
    {
        public string Name { get; set; }
        public static int NextAuthorID = 0;
        public int AuthorID { get; set; }
        public int BlogPostID { get; set; }
        public Author(string name, int blogpostid)
        {
            Name = name;
            AuthorID = NextAuthorID++;
            BlogPostID = blogpostid;
        }
        public Author()
        {

        }
    }
}