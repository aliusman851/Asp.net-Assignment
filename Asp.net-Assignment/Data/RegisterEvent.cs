using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Asp.net_Assignment.Models;
using Microsoft.EntityFrameworkCore;
using Asp.net_Assignment.Data;

namespace Asp.net_Assignment.Data
{
    public class RegisterEvent
    {
        public static void Register(EventsContext context, int attendeeId, int eventId)
        {
            context.Database.EnsureCreated();

            var MyEvents = new MyEvents
            {
                Attendeeid = attendeeId,
                Eventid = eventId,
            };

            context.myevents.Add(MyEvents);
            context.SaveChanges();
        }
    }
}
