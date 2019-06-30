using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetupRsvp.Data.Models
{
    public class Rsvp
    {
        public long Id { get; set; }

        public int Guests { get; set; }

        public bool Response { get; set; }

        public Event Event { get; set; }

        public Group Group { get; set; }

        public Member Member { get; set; }

        public Venue Venue { get; set; }

        public DateTime LastModified { get; set; }       
    }
}
