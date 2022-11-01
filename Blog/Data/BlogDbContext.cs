using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Blog.Data.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Blog.Data
{
    public class BlogDbContext : IdentityDbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) :base(options){}
        // public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        // public DbSet<Comment> Comments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=Blog.db");
        }
    //     protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.ApplyConfiguration(new ArticleConfiguration());
    // }
    }
}


