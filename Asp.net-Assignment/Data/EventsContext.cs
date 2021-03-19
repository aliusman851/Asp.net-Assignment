using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp.net_Assignment.Models;

namespace Asp.net_Assignment.Data
{
    public class EventsContext:DbContext
    {
        public EventsContext(DbContextOptions<EventsContext> options)
            : base(options) 
        {
        
        }
       public DbSet<ModelEvents> modelEvents { get; set; }

       


    }
    }

