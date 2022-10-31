using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blog.Pages
{
    public class AddArticleModel : PageModel
    {

        [BindProperty]
        public string Title { get; set; }
        [BindProperty]
        public string Content { get; set; }
        public Article Article { get; set;}
        public void OnGet()
        {
        }
    }
}
