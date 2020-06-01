using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMessageWall.Pages
{
    public class MessageWallModel : PageModel
    {
        //used with asp-for
        [BindProperty]
        public string Message { get; set; }

        [BindProperty]
        public List<string> Messages { get; set; } = new List<string>();

        public void OnGet()
        {

        }

        //used with form method="post"
        public IActionResult OnPost()
        {
            Messages.Add(Message);

            //will return the same page
            return Page();
        }
    }
}