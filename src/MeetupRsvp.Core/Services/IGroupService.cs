using MeetupRsvp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetupRsvp.Core.Services
{
    interface IGroupService
    {
        IEnumerable<Group> FindAll();

        Group FindById(long id);

        Group Add(Group group);

        Group Update(Group group);

        void Delete(Group group);
    }
}
