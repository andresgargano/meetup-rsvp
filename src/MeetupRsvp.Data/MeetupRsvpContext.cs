using MeetupRsvp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetupRsvp.Data
{
    public class MeetupRsvpContext : DbContext
    {
        public MeetupRsvpContext(DbContextOptions<MeetupRsvpContext> options) 
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<Topic> Topics { get; set; }

        public DbSet<Member> Members { get; set; }

        public DbSet<Venue> Venues { get; set; }

    }
}
