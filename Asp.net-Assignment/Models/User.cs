﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_Assignment.Models
{
    public class User: IdentityUser
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Event> HostedEvents { get; set; }
        public List<Event> JoinedEvents { get; set; }
    }
}
