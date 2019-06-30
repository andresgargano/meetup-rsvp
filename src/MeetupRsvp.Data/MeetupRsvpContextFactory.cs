using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetupRsvp.Data
{
    class MeetupRsvpContextFactory : IDesignTimeDbContextFactory<MeetupRsvpContext>
    {
        public MeetupRsvpContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MeetupRsvpContext>();
            optionsBuilder.UseSqlite("Data Source=meetup-rsvp.db");

            return new MeetupRsvpContext(optionsBuilder.Options);
        }
    }
}
