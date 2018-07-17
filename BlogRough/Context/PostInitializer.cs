using BlogRough.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogRough.Context
{
    public class PostInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var posts = new List<Post>
            {
                new Post {Id = 1, Title = "First post!", Body = "This is awesome!", Date = DateTime.Now},
                new Post {Id = 2, Title = "Second Post", Body = "Woo-hoo!", Date = DateTime.Now},
                new Post {Id = 3, Title = "Third Post!", Body = "Kickass!", Date = DateTime.Now}
            };
            posts.ForEach(s => context.DbPost.Add(s));
            context.SaveChanges();
        }
    }
}