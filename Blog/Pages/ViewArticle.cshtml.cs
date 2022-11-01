
using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;


namespace Blog.Pages
{
    public class ViewArticleModel : PageModel
    {
        private UserManager<IdentityUser> userManager;
        private readonly ILogger<IndexModel> _logger;
        private SignInManager<IdentityUser> signInManager;
        private readonly BlogDbContext db;

        public ViewArticleModel(UserManager<IdentityUser> userManager, ILogger<IndexModel> logger, SignInManager<IdentityUser> signInManager, BlogDbContext db)
        {

            this.userManager = userManager;
            _logger = logger;
            this.signInManager = signInManager;
            this.db = db;
        }

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public Article article { get; set; }
        
        public async Task OnGetAsync()
        {
            // article = await db.Articles.FindAsync(Id);
            article = await db.Articles.Include(article => article.Author).Where(article => article.Id == Id).FirstOrDefaultAsync();
        }
        // public async Task<IActionResult> OnPostAsync()
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return Page();
        //     }
            
        //     var userName = User.Identity.Name; // user's email
        //     var user = db.Users.Where(u => u.UserName == userName).FirstOrDefault(); //user in database
            
        //     if(article.Author == user)
        //     {
        //         var ArticleFromDB =  db.Articles.FirstOrDefault(article => article.Id == Id);
        //         ArticleFromDB.Title= article.Title;
        //     // ArticleFromDB.Author = article.Author;
        //         ArticleFromDB.Body = article.Body;
        //     // ArticleFromDB.Created = article.Created;
        //         await db.SaveChangesAsync();
        //         return RedirectToPage("Index");
        //     }
        //     else
        //     {
        //         return RedirectToPage("/Index");
        //     }  
            
        // }
    }
}
