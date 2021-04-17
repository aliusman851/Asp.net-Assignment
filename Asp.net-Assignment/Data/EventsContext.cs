using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp.net_Assignment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Asp.net_Assignment.Data
{
    public class EventsContext : IdentityDbContext<User>
    {
        public EventsContext(DbContextOptions<EventsContext> options)
            : base(options)
        {

        }

        public DbSet<Event> Events { get; set; }


        // public DbSet<Models.Organizer>organizers { get; set; }
        //  public DbSet<Models.Attendee> attendees { get; set; }
        // public DbSet<Models.MyEvents> myevents { get; set; }
        

        public void ResetAndSeed()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();



            Event[] events = new Event[] {
                new Event(){
                   
                    Description="Have a fun time chilling in the sun",
                    Place="Colorado springs",
                    Adress="515 S Cascade Ave Colorado Springs, CO 80903",
                    Date=DateTime.Now.AddDays(34),
                    SpotsAvailable="234",

                },
                new Event(){
                    
                    Description="Best lazertag in the world",
                    Place="Blackpark",
                    Adress="510 N McPherson Church Rd Fayetteville, NC 28303",
                    Date=DateTime.Now.AddDays(12),
                    SpotsAvailable="23",

                },
            };


            AddRange(events);

            SaveChanges();
        }

        /*  
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


        */
    }
    }
    

        
        
       


    


