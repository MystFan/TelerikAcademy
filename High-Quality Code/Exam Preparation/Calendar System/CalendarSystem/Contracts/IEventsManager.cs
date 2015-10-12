namespace CalendarSystem.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface IEventsManager
    {
        /// <summary>
        /// Add Event to Event collection data
        /// </summary>
        /// <param name="eventToAdd">Event shuld be added</param>
        void AddEvent(Event eventToAdd);

        /// <summary>
        /// Delete Event from event data by provide Event title
        /// </summary>
        /// <param name="title">Provided title</param>
        /// <returns>Count of removed Events</returns>
        int DeleteEventsByTitle(string title);

        /// <summary>
        /// Get Events who matching on provide date.
        /// </summary>
        /// <param name="eventDate">Date to be match</param>
        /// <param name="count">Events count to take</param>
        /// <returns>Matched events</returns>
        IEnumerable<Event> ListEvents(DateTime eventDate, int count);
    }
}
