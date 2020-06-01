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

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            //will return the same page
            return Page();
        }
    }
}