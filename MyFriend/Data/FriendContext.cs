using MyFriend.Models;
using Microsoft.EntityFrameworkCore;

namespace MyFriend.Data
{
    public class FriendContext : DbContext
    {
        public DbSet<Friend> Friends { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data source=MyFriend.db");
        }
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.ApplyConfiguration(new FriendConfiguration).Seed();
        // }
    }
}