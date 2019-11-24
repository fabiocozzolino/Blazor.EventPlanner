using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Blazor.EventPlanner.Data
{
    public class Meetup
    {
        public Guid Id {get;set;}
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Summary { get; set; }
        public string Description { get; set; }
        [Required]
        public string Speaker { get; set; }
        public List<MeetupAttendee> Attendees {get;set;}=new List<MeetupAttendee>();
    }

    public class MeetupAttendee
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
