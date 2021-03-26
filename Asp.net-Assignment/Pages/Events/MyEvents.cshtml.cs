
using Asp.net_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Asp.net_Assignment.Pages.Forms
{
    public class MyEventsModel : PageModel

       
    {
        private readonly Asp.net_Assignment.Data.EventsContext _context;


        public MyEventsModel(Asp.net_Assignment.Data.EventsContext context)
        {
            _context = context;
        }
        public IList<MyEvents> myEvents { get; set; }
        public async Task OnGetAsync()
        {

            myEvents = await _context.myevents.ToListAsync();


        }


    }
}

    