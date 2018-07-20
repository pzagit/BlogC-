using System.Collections.Generic;
using BlogRough.Models;

namespace BlogRough.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BlogRough.Context.BlogContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BlogRough.Context.BlogContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var posts = new List<Post>
            {
                new Post {Id = 1, Title = "First post!", Body = "This is awesome!", ImageFile = "scene.jpg", Date = DateTime.Now},
                new Post {Id = 2, Title = "Second Post", Body = "Woo-hoo!", ImageFile = "scene.jpg", Date = DateTime.Now},
                new Post {Id = 3, Title = "Third Post!", Body = "Kickass!", ImageFile = "scene.jpg", Date = DateTime.Now}
            };
            posts.ForEach(s => context.DbPost.Add(s));
            context.SaveChanges();
        }

    }
}
