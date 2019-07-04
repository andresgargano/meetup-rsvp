using MeetupRsvp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MeetupRsvp.Core.Services
{
    interface IMemberService
    {
        IEnumerable<Member> FindAll();

        Member FindById(long id);

        Member Add(Member member);

        Member Update(Member member);

        void Delete(Member member);
    }
}
