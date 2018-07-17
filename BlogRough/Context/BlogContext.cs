using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using BlogRough.Models;

namespace BlogRough.Context
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContext")
        {
        }

        public DbSet<Post> DbPost { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}