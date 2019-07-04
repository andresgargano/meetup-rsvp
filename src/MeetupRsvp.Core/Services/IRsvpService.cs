using MeetupRsvp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetupRsvp.Core.Services
{
    public interface IRsvpService
    {
        IEnumerable<Rsvp> FindAll();

        Rsvp FindById(long id);

        Rsvp Add(Rsvp rsvp);

        Rsvp Update(Rsvp rsvp);

        void Delete(Rsvp rsvp);
    }
}
