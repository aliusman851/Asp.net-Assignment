using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Asp.net_Assignment.Models;

namespace Asp.net_Assignment.Pages.Forms
{
    public class EventsModel : PageModel
    {
        [BindProperty]
        public ModelEvents LastName { get; set; }
        public ModelEvents FirstMidName { get; set; }
        


        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if(ModelState.IsValid == false)
            {
                return Page();
            }
            return RedirectToPage("/index");

        }
    }
}
