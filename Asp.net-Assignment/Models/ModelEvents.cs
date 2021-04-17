using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.net_Assignment.Models
{

    public class Event
    {
        public int EventID { get; set; }

        public string Description { get; set; }
        public string Place { get; set; }
        public string Adress { get; set; }
        public DateTime Date { get; set; }
        public string SpotsAvailable { get; set; }

       [InverseProperty("JoindEvents")]
        public List<User> Attendees { get; set; }

        [InverseProperty("HostedEvents")]
        public User organizer {get; set;}

       

    }
    

}
   
