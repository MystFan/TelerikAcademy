namespace CalendarSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using CalendarSystem.Common;
    using CalendarSystem.Contracts;

    public class EventManager : IEventsManager
    {
        private readonly List<Event> eventsList;

        public EventManager()
        {
            this.eventsList = new List<Event>();
        }

        public List<Event> EventsList
        {
            get
            {
                return new List<Event>(this.eventsList);
            }
        } 

        public void AddEvent(Event eventToAdd)
        {
            Validator.CheckIfNull(eventToAdd, "Event to add cannot be null.");

            this.eventsList.Add(eventToAdd);
        }

        public int DeleteEventsByTitle(string title)
        {
            Validator.CheckIfNull(title, "Title cannot be null.");

            int removedEventsCount = this.eventsList.RemoveAll(
                e => e.Title.ToLowerInvariant() == title.ToLowerInvariant());

            return removedEventsCount;
        }

        public IEnumerable<Event> ListEvents(DateTime date, int count)
        {
            Validator.CheckIfNull(date, "Date cannot be null.");

            var result = (from e in this.eventsList
                where e.EventDate >= date
                orderby e.EventDate, e.Title, e.Location
                select e).Take(count);

            return result;
        }
    }
}
