using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.net_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Asp.net_Assignment.Pages
{
    public class testpageModel : PageModel
    {

        private readonly Asp.net_Assignment.Data.EventsContext _context;
        public testpageModel(Asp.net_Assignment.Data.EventsContext context)
        {
            _context = context;
        }

        public IList<Event> Event { get; set; }
        public IList<Attendee> Attendee { get; set; }

        public async Task OnPostAsync()
        {
            var RegisteredEvent = await _context.events
                .Include(r => r.Attendee)
                .Include(r => r.EventID).ToListAsync();
        }
        
    }
}
