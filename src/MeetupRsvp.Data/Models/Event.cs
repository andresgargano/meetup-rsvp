using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetupRsvp.Data.Models
{
    public class Event
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public DateTime Time { get; set; }
    }
}
