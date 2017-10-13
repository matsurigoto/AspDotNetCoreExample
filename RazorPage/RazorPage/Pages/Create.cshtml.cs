using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPage.Models;

namespace RazorPage.Pages
{
    public class CreateModel : PageModel
    {

        [BindProperty]
        public StudentModel Student { get; set; }

        public string GetMessage { get; set; }
        public string PostMessage { get; set; }

        public async Task OnGetAsync()
        {
            GetMessage = "GET";
        }

        public async Task<IActionResult> OnPostAsync()
        {
            PostMessage = Student.Name;
            return Page();
        }
    }
}