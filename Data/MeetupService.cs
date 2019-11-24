using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.EventPlanner.Data
{
    public class MeetupService
    {
        private static readonly List<Meetup> Meetups = new List<Meetup>();

        public MeetupService()
        {
            Meetups.Add(new Meetup{
                Id = Guid.NewGuid(),
                Date = DateTime.Now.AddDays(5),
                Summary = "Async/Await in C#",
                Speaker = "Fabio Cozzolino"
            });
            Meetups.Add(new Meetup{
                Id = Guid.NewGuid(),
                Date = DateTime.Now.AddDays(12),
                Summary = "MVVM Concepts",
                Speaker = "Daniele Romanazzi"
            });
            Meetups.Add(new Meetup{
                Id = Guid.NewGuid(),
                Date = DateTime.Now.AddDays(19),
                Summary = "Fabio Cozzolino",
                Speaker = ".NET Core 3"
            });
        }

        public Task<Meetup[]> GetForecastAsync(DateTime startDate)
        {
            return Task.FromResult(Meetups.ToArray());
        }

        public void CreateMeetup(DateTime date, string summary, string speaker)
        {
            Meetups.Add(new Meetup{
                Id = Guid.NewGuid(),
                Date=date,
                Summary=summary,
                Speaker=speaker
            });
        }

        public void AddAttendee(Guid meetupId, MeetupAttendee attendee)
        {
            var currentMeetup = Meetups.FirstOrDefault(m => m.Id == meetupId);
            currentMeetup.Attendees.Add(attendee);
        }

        public Meetup GetMeetup(Guid meetupId)
        {
            return Meetups.FirstOrDefault(m => m.Id == meetupId);
        }
    }
}
