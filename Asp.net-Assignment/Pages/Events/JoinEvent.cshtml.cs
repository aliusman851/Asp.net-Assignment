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
        /*  public async Task OnPostAsync(int id)
          {
              Attendee = await _context.attendees.FirstOrDefaultAsync();
             JoinEvent  = await _context.events.FirstOrDefaultAsync(m => m.EventID == id);
              RegisterEvent.Register(_context, Attendee.ID, JoinEvent.EventID);
              req = "post";
          }*/
        
        public async Task<IActionResult> OnPostAsync(int? id)
        {

            //var attendee = await _context.attendees.Where(a => a.ID == id).Include(e => e.Event).FirstOrDefaultAsync();

            var join = await _context.events.Where(e => e.EventID == id).FirstOrDefaultAsync();

           // attendee.Event.Add(join);
            await _context.SaveChangesAsync();
            return RedirectToPage("/Events/MyEvents");

        }

    }

    }

