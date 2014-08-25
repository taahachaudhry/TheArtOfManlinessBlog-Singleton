using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSingleton.Models
{
    public class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        public List<BlogPost> BlogPosts { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Author> Authors { get; set; }
        static Singleton()
        {

        }
        private Singleton()
        {
            BlogPosts = new List<BlogPost>()
            {
                new BlogPost("Taaha Chaudhry","The Houston Food Spots","Ever wonder where are the best places to eat in Houston, TX. Well here's a small list of some of my favorite restaurants: 1- Bandu Khan: a restaurant that specializes in kabobs and chicken bbq. Get their Beheri Kabobs with fresh Tandoori Naan. You won't regret it. 2- M&M Grill: Best burgers you can get in town. Period. Hope you enjoy. Don't forget to bring some back for me.", "http://s3-media4.fl.yelpcdn.com/bphoto/z8x6VemiNsOXJoCkGDqKmw/l.jpg"),
                new BlogPost("A Classy Guy","The Art of Dressing", "Part of being a man is knowing how to dress classy and always looking presentable. This blog post can help you build that wardrobe. First off, upgrade from wearing tshirts to polos. Secondly, if you are going to wear denim, make sure it is a dark color and fits nicely, or wear a pair of pants. Thirdly, stop wearing sneakers and start wearing loafers or oxfords, or leather shoes, such as boat shoes, for a more casual look. Last, but not least, always wear pressed clothes, comb your hair, wear a watch and some cologne. And there you have it: a well dressed man.",""),
                new BlogPost("The Manly Man","How Men Take Selfies", "1) Hold phone a little lower than normal. 2) Lower it a little more. 3) Lay it on table. 4) Don't take a selfie. Men don't take selfies.", "http://i.imgur.com/NvvIVPm.jpg")
            };
            Comments = new List<Comment>()
            {
                new Comment("Robin","Dang Bandu Khan is definetly in my top 5 favorite restaurants. Can't wait to go back!",0),
                new Comment("Rocky","M&M really does have mouthwatering burgers. Thanks!", 0),
                new Comment("Ibrahim", "Upgraded my style and the compliments haven't stopped. Thank you!",1),
                new Comment("Abdulghani","Any recommendations on where to shop?",1),
                new Comment("Dean", "They need to add this to the brocode.", 2)
            };
            Authors = new List<Author>()
            {
                new Author("Taaha Chaudhry", 0),
                new Author("A Classy Guy", 1)
            };
        }
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }
    }
}