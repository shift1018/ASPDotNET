using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public IdentityUser Author { get; set; }
        public string Title { get; set; }

        public string Body { get; set; }
        public DateTime Timestamp { get; set; }
    }
}