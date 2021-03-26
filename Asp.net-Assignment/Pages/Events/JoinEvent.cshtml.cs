using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Asp.net_Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Asp.net_Assignment.Data;

namespace Asp.net_Assignment.Pages.Events
{
    public class JoinEventModel : PageModel

    {
        private readonly Asp.net_Assignment.Data.EventsContext _context;


        public JoinEventModel(Asp.net_Assignment.Data.EventsContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Event JoinEvent { get; set; }
        public Attendee Attendee { get; set; }
        public Organizer organizer { get; set; }
        public string req;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            JoinEvent = await _context.events.FirstOrDefaultAsync(m => m.EventID == id);

            if (JoinEvent == null)
            {
                return NotFound();
            }
            return Page();
        }
        public async Task OnPostAsync(string id)
        {
            Attendee = await _context.attendees.FirstOrDefaultAsync();
           JoinEvent  = await _context.events.Include(s => s.organizer).FirstOrDefaultAsync(m => m.EventID == Int32.Parse(id));
            RegisterEvent.Register(_context, Attendee.ID, JoinEvent.EventID);
            req = "post";
        }

    }

    }

