using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TagHelperIssue.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string SomeValue { get; set; } = "Value";

        public IActionResult OnGet()
        {
            ViewData["Status"] = "You made a GET request.";
            return Page();
        }

        public IActionResult OnPost()
        {
            ViewData["Status"] = $"You made a POST request, saying \"{SomeValue}\".";
            return Page();
        }
    }
}
