using System;
using System.Collections.Generic;

namespace Blazor.EventPlanner.Data
{
    public class Meetup
    {
        public Guid Id {get;set;}
        public DateTime Date { get; set; }
        public string Summary { get; set; }
        public string Speaker { get; set; }
        public List<MeetupAttendee> Attendees {get;set;}=new List<MeetupAttendee>();
    }

    public class MeetupAttendee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
