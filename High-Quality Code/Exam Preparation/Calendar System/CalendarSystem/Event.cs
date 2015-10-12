namespace CalendarSystem
{
    using System;
    using CalendarSystem.Common;

    public class Event
    {
        private string title;
        private string location;
        private DateTime eventDate;

        public Event(string title, string location, DateTime date)
        {
            this.Title = title;
            this.Location = location;
            this.EventDate = date;
        }

        public DateTime EventDate 
        {
            get
            {
                return this.eventDate;
            }

            private set
            {
                Validator.CheckIfNull(value, "Event date cannot be null.");

                this.eventDate = value;
            }
        }

        public string Title
        {
            get
            {
                return this.title;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Event title cannot be null or empty.");

                this.title = value;
            }
        }

        public string Location
        {
            get { return this.location; }
            private set { this.location = value; }
        }

        public override string ToString()
        {
            string format = "{0:yyyy-MM-ddTH:mm:ss} | {1}";

            if (this.Location != string.Empty)
            {
                format += " | {2}";
            }

            string eventAsString = string.Format(format, this.EventDate, this.Title, this.Location);
            return eventAsString;
        }

        public int CompareTo(Event otherEvent)
        {
            int result = DateTime.Compare(this.EventDate, otherEvent.EventDate);

            if (result == 0)
            {
                result = string.Compare(this.Title, otherEvent.Title, StringComparison.Ordinal);
            }

            return result;
        }
    }
}
