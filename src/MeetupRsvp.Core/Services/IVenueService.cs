using MeetupRsvp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetupRsvp.Core.Services
{
    public interface IVenueService
    {
        IEnumerable<Venue> FindAll();

        Venue FindById(long id);

        Venue Add(Venue venue);

        Venue Update(Venue venue);

        void Delete(Venue venue);
    }
}
