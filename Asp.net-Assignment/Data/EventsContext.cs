using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp.net_Assignment.Models;

namespace Asp.net_Assignment.Data
{
    public class EventsContext : DbContext
    {
        public EventsContext(DbContextOptions<EventsContext> options)
            : base(options)
        {

        }
        public DbSet<Models.Event> events { get; set; }
       public DbSet<Models.Organizer>organizers { get; set; }
        public DbSet<Models.Attendee> attendees { get; set; }
        public DbSet<Models.MyEvents> myevents { get; set; }
        public void Seed()
        {
            this.Database.EnsureCreated();

            
          if (this.events.Any())
            {
                return;   // DB has been seeded


            }
           

            this.events.AddRange(new List<Models.Event>()
            {
                  new Event{Description="Kräftfestival",Place="Flakenberg",Adress="flakenberggata 6A",SpotsAvailable="200",Date =DateTime.Parse("2021-05-10")},
                  new Event{Description="Wheels&Wings",Place="Halmstad",Adress="Halmstadgatan 7B",SpotsAvailable="250",Date =DateTime.Parse("2021-06-21")},
                  new Event{Description="Footboll",Place="Göteborg",Adress="Göteborggata 8D",SpotsAvailable="350",Date =DateTime.Parse("2021-08-23")},
              });
              
              this.SaveChanges();

            
              this.organizers.AddRange(new List<Models.Organizer>()
              {
                  new Organizer{Name="Alaxder",Email="Alxh@gmail.com",PhoneNumber="9978798"},
                  new Organizer{Name="Björn",Email="Björn@gmail.com",PhoneNumber="9978798"},
                  new Organizer{Name="Gustaf",Email="Gustaf@gmail.com",PhoneNumber="9978798"},

              });

             
              this.SaveChanges();
            
              this.attendees.AddRange(new List<Models.Attendee>()
              {
                  new Attendee{Name="Svensson",Email="Svensson@gmail.com",PhoneNumber="2342343"},
                  new Attendee{Name="Albert",Email="Albert@gmail.com",PhoneNumber="2342343"},
                  new Attendee{Name="Ali",Email="Ali@gmail.com",PhoneNumber="2342343"},


              });

             
              this.SaveChanges();
            

            /*events.AddRange(new List<Models.Event>()
            {

                new Models.Event() { Description = "this is the first event" },
                new Models.Event() { Place = "this is the second event" },
                new Models.Event() { Adress = "this is the third event" },
                 new Models.Event() { SpotsAvailable = "this is the second event" },

            });*/

        }
    }
    }

        
        
       


    


