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
    public class IndexModel : PageModel
    {
        private readonly Asp.net_Assignment.Data.EventsContext _context;

        public IndexModel(Asp.net_Assignment.Data.EventsContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get;set; }

        public async Task OnGetAsync()
        {
            Event = await _context.events.ToListAsync();
        }
    }
}
