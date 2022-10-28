using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFriend.Data;
using MyFriend.Models;


namespace MyFriend.Pages
{
    public class AddFriendModel : PageModel
    {
        private FriendContext db;
        public AddFriendModel(FriendContext db) => this.db = db;

        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public int Age { get; set; }
        [BindProperty]
        public Friend Friend { get; set;}
        // [BindProperty]
        // public Friend NewFriend { get; set;}
         public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            db.Friends.Add(
                new Friend{
                Name = Name,
                Age = Age
            }
            );

            // db.Friends.Add(newFriend);
            await db.SaveChangesAsync();

            return RedirectToPage("./AddSuccess");
        }
    }
}
