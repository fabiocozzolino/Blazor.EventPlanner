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
                Description="The Async-Await pattern has now become ubiquitous in C# development, however it still causes confusion for many developers. This is partly because of the amount of misinformation about it floating around and partially because of the lack of more advanced examples of its usage. David Allen and Ben Kotvis from BlueMetal will talking about how Async-Await works and some of the lesser known features and patterns that are useful in the real world. Amongst the topics they will cover are: Tasks, what they are, and options for creating them; What the Async-Await pattern is and how to use it, return types from async methods, and the When, Wait, Continue, and Result Task extensions; Creating async methods from synchronous methods; Synchronization Context, what it means and how to manipulate it; and how to use Async-Await and still get results back from queues and events handlers using TaskCompletionSource. Hopefully after this presentation attendees will have a better understanding of the Async-Await pattern, and be confident enough to start investigating and using some of the more advanced features available in the various Asynchronous patterns supported in .Net.",
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
