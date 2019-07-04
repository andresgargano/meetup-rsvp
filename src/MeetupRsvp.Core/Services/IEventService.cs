using MeetupRsvp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetupRsvp.Core.Services
{
    public interface IEventService
    {
        IEnumerable<Event> FindAll();

        Event FindById(long id);

        Event Add(Event _event);

        Event Update(Event _event);

        void Delete(Event _event);
    }
}
