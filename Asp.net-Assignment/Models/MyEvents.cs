﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_Assignment.Models
{
    public class MyEvents
    {
        public int ID { get; set; }
        public Attendee Attendee { get; set; }
        public Event Event { get; set; }
    }
}
