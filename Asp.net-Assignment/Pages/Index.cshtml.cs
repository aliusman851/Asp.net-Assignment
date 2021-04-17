using Asp.net_Assignment.Data;
using Asp.net_Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_Assignment.Pages
{
    public class IndexModel : PageModel
    {

        private readonly Asp.net_Assignment.Data.EventsContext _context;


        public IndexModel(Asp.net_Assignment.Data.EventsContext context)
        {
            _context = context;
        }
        
        public void OnGet(bool? resetDb)
        {
            if (resetDb ?? false)
            {
                _context.ResetAndSeed();
            }
        }
    }
}