
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Asp.net_Assignment.Pages.Forms
{
    public class MyEventsModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public MyEventsModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
       
        public void OnGet()
        {
              
        }
        
    }
}

    