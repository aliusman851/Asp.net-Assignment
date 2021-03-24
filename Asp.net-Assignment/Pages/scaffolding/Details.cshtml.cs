using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Asp.net_Assignment.Data;
using Asp.net_Assignment.Models;

namespace Asp.net_Assignment.Pages.scaffolding
{
    public class DetailsModel : PageModel
    {
        private readonly Asp.net_Assignment.Data.EventsContext _context;

        public DetailsModel(Asp.net_Assignment.Data.EventsContext context)
        {
            _context = context;
        }

        public Event Event { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.events.FirstOrDefaultAsync(m => m.EventID == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
