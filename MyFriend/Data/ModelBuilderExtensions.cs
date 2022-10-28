
using MyFriend.Models;
using Microsoft.EntityFrameworkCore;

namespace MyFriend.Data
{
    public static class ModelBuilderExtensions
    {
        public static ModelBuilder Seed(this ModelBuilder modelBuilder){
            modelBuilder.Entity<Friend>().HasData(
                new Friend
                {
                    Id = 1,
                    Name = "Harry Potter",
                    Age = 21
                },
                new Friend
                {
                    Id = 2,
                    Name = "Harry2 Potter2",
                    Age = 22
                },new Friend
                {
                    Id = 3,
                    Name = "Harry3 Potter3",
                    Age = 23
                },new Friend
                {
                    Id = 4,
                    Name = "Harry4 Potter4",
                    Age = 24
                },new Friend
                {
                    Id = 5,
                    Name = "Harry5 Potter5",
                    Age = 25
                }
            );
            return modelBuilder;
        }
    }
}