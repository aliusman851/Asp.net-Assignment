using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_Assignment.Models
{
    public class Attendee
    {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public List <Event>  Event { get; set; }


        }
    }

