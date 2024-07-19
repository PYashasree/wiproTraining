using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCodeFirstApproach
{
    public class BloggingContext : DbContext
    {
        public BloggingContext()
            : base("name=Blogging ")
        {
            // Database.SetInitializer(new DropCreateDatabaseAlways<BloggingContext>());
            // Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BloggingContext>());
            Database.SetInitializer(new SeedDefaultData());
        }


        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }


    }
    public class SeedDefaultData : DropCreateDatabaseIfModelChanges<BloggingContext>
    {
        protected override void Seed(BloggingContext context)
        {
            Blog bg = new Blog();
            bg.BlogId = 1;
            bg.BlogName = "yashu";
            bg.BlogDescription = "Description";
            bg.BlogHeader = "Blog";
            bg.BlogType = "fun with friends";

            Post pt = new Post();
            pt.BlogId = 1;
            pt.CreationDate = DateTime.Now;
            pt.PostDescription = "Post Description";

            context.Blogs.Add(bg);
            // context.Posts.Add(pt);
            context.SaveChanges();
            base.Seed(context);
        }

    }
}

