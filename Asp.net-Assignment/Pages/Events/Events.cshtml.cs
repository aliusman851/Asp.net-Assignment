using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Asp.net_Assignment.Models;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Internal;
using Microsoft.EntityFrameworkCore;

namespace Asp.net_Assignment.Pages.Forms
{
    public class EventsModel : PageModel
    {


        private readonly Asp.net_Assignment.Data.EventsContext _context;


        public EventsModel(Asp.net_Assignment.Data.EventsContext context)
        {
            _context = context;
        }


        
        public IList<Event> Event { get; set; }
        
       
      
       
        public async Task OnGetAsync()
        {

            Event = await _context.events.ToListAsync();


        }

       

        

    }
}
       


       

        

       



