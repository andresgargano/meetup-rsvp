using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetupRsvp.Data.Models
{
    public class Group
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string UrlName { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public List<Topic> Topics { get; set; }
    }
}
