
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFriend.Data;
using MyFriend.Models;
using Microsoft.EntityFrameworkCore;

namespace MyFriend.Pages
{
    public class IndexModel : PageModel
    {
            private readonly FriendContext db;  
            public IndexModel(FriendContext db) => this.db = db;
            public List<Friend> Friends { get; set; } = new List<Friend>();  
            public async Task OnGetAsync()
            {
                Friends = await db.Friends.ToListAsync();
                
            }
        }

}


