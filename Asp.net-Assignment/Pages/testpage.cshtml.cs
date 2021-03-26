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
        [BindProperty]
        public MyEvents MyEvents { get; set; }
        public Event Event { get; set; }
        // public IList<Event> Event { get; set; }
        // public IList<Attendee> Attendee { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            Event = await _context.events.Where(e => e.EventID == id).FirstOrDefaultAsync();
            if (Event == default)
            {
                return RedirectToPage("../Events/MyEvents", new { id });
            }
            MyEvents joinedEvent = new MyEvents()
            {
                Attendee = await _context.attendees.Where(a => a.ID == 1).FirstOrDefaultAsync(),
                Event = Event,
            };
            _context.myevents.Add(joinedEvent);

            

            await _context.SaveChangesAsync();

            return RedirectToPage("Events/MyEvents", new { id });
        }

       

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.myevents.Add(MyEvents);
            await _context.SaveChangesAsync();

            return RedirectToPage("Events/Events");
        }
    }

}

