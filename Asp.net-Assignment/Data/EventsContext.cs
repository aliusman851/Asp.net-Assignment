using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Asp.net_Assignment.Data
{
    public class EventsContext:DbContext
    {
        public EventsContext(DbContextOptions<EventsContext> options)
            : base(options) 
        {
        
        }
        DbSet<Models.ModelEvents> modelEvents { get; set; }

    }
}
