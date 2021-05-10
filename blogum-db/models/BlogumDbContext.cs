using System;
using Microsoft.EntityFrameworkCore;

namespace blogum_db.models
{
    public class BlogumDbContext : DbContext
    {
        public BlogumDbContext(DbContextOptions<BlogumDbContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Comment> Comments { get; set; }
    }
}
