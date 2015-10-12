namespace CalendarSystem
{
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using CalendarSystem.Common;
    using CalendarSystem.Contracts;

    public class CommandManager
    {
        public readonly IEventsManager Manager;

        public CommandManager(IEventsManager manager)
        {
            this.Manager = manager;
        }

        public string ProcessCommand(Command command)
        {
            if (command.Name == "AddEvent")
            {
                var eventDate = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                string eventTitle = command.Parameters[1];

                string eventLocation = string.Empty;
                if (command.Parameters.Length == 3)
                {
                    eventLocation = command.Parameters[2];
                }

                var eventToAdd = new Event(eventTitle, eventLocation, eventDate);

                this.Manager.AddEvent(eventToAdd);

                return "Event added";
            }
            else if ((command.Name == "DeleteEvents") && (command.Parameters.Length == 1))
            {
                int count = this.Manager.DeleteEventsByTitle(command.Parameters[0]);

                if (count == 0)
                {
                    return "No events found.";
                }

                return count + " events deleted";
            }
            else if ((command.Name == "ListEvents") && (command.Parameters.Length == 2))
            {
                var date = DateTime.ParseExact(command.Parameters[0], "yyyy-MM-ddTHH:mm:ss", CultureInfo.InvariantCulture);
                var count = int.Parse(command.Parameters[1]);
                var events = this.Manager.ListEvents(date, count).ToList();
                var eventsList = new StringBuilder();

                if (events.Count == 0)
                {
                    return "No events found";
                }

                foreach (var eventToList in events)
                {
                    eventsList.AppendLine(eventToList.ToString());
                }

                string result = eventsList.ToString().Trim();
                return result;
            }
            else
            {
                throw new InvalidCommandException("Command " + command.Name + " is invalid");
            }
        }
    }
}
