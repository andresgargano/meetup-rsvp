using MeetupRsvp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetupRsvp.Core.Services
{
    interface ITopicService
    {
        IEnumerable<Topic> FindAll();

        Topic FindById(long id);

        Topic Add(Topic topic);

        Topic Update(Topic topic);

        void Delete(Topic topic);
    }
}
