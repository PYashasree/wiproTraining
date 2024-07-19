using System;
using System.Data.Entity;
using System.Linq;

namespace ConsoleAppCodeFirstApproach
{
    public class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new SeedDefaultData());

            using (var context = new BloggingContext())
            {
                context.Database.Initialize(force: true);

                var blogs = context.Blogs.Include(b => b.Posts).ToList();
                var posts = context.Posts.ToList();

                Console.WriteLine("Blogs:");
                /*foreach (var blog in blogs)
                {
                    Console.WriteLine(blog);
                }

                Console.WriteLine("*****************************");

                Console.WriteLine("Posts:");
                foreach (var post in posts)
                {
                    Console.WriteLine(post);
                }*/
            }

            Console.WriteLine("Database created and seeded with initial data.");
            Console.ReadKey();
        }
    }
}
