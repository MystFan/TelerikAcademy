using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NightlifeEntertainment
{
    public class CinemaEngineExtension : CinemaEngine
    {
        protected override void ExecuteInsertVenueCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "opera":
                    var opera = new Opera(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(opera);
                    break;
                case "sports_hall":
                    var sportHall = new SportHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(sportHall);
                    break;
                case "concert_hall":
                    var concertHall = new ConcertHall(commandWords[3], commandWords[4], int.Parse(commandWords[5]));
                    this.Venues.Add(concertHall);
                    break;
                default:
                    base.ExecuteInsertVenueCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteInsertPerformanceCommand(string[] commandWords)
        {
            switch (commandWords[2])
            {
                case "theatre":
                    {
                        var venue = this.GetVenue(commandWords[5]);
                        var theatre = new Theatre(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                        this.Performances.Add(theatre);
                    }
                    break;
                case "concert":
                    {
                        var venue = this.GetVenue(commandWords[5]);
                        var concert = new Concert(commandWords[3], decimal.Parse(commandWords[4]), venue, DateTime.Parse(commandWords[6] + " " + commandWords[7]));
                        this.Performances.Add(concert);
                    }
                    break;
                default:
                    base.ExecuteInsertPerformanceCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteSupplyTicketsCommand(string[] commandWords)
        {
            var venue = this.GetVenue(commandWords[2]);
            var performance = this.GetPerformance(commandWords[3]);
            switch (commandWords[1])
            {
                case "regular":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new RegularTicket(performance));
                    }
                    break;
                case "student":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new StudentTicket(performance));
                    }
                    break;
                case "vip":
                    for (int i = 0; i < int.Parse(commandWords[4]); i++)
                    {
                        performance.AddTicket(new VipTicket(performance));
                    }
                    break;
                default:
                    base.ExecuteSupplyTicketsCommand(commandWords);
                    break;
            }
        }

        protected override void ExecuteReportCommand(string[] commandWords)
        {
            var performance = this.GetPerformance(commandWords[1]);
            var ticketsSolded = performance.Tickets.Where(t => t.Status == TicketStatus.Sold);
            decimal totalPrice = 0;
            foreach (var ticket in ticketsSolded)
            {
                totalPrice += ticket.Price;
            }
            string title = string.Format("{0}: {1} ticket(s), total: ${2:F2}", performance.Name, ticketsSolded.Count(), totalPrice);
            string venue = string.Format("Venue: {0} ({1})", performance.Venue.Name, performance.Venue.Location);
            string startTime = string.Format("Start time: {0}", performance.StartTime.ToString("G",
                  DateTimeFormatInfo.InvariantInfo));
            this.Output.AppendLine(title);
            this.Output.AppendLine(venue);
            this.Output.AppendLine(startTime);
        }

        protected override void ExecuteFindCommand(string[] commandWords)
        {
            DateTime startTime = DateTime.Parse(commandWords[2]);
            string[] time = commandWords[3].Split(':');
            int hours = int.Parse(time[0]);
            int minutes = int.Parse(time[1]);
            int seconds = int.Parse(time[2]);
            startTime = startTime.AddHours(hours);
            startTime = startTime.AddMinutes(minutes);
            startTime = startTime.AddSeconds(seconds);
            var venues = this.Venues
                .Where(v => v.Name.ToLower().IndexOf(commandWords[1].ToLower()) >= 0 )
                .OrderBy( v => v.Name);
            var performances = this.Performances
                .Where(p => p.Name.ToLower().IndexOf(commandWords[1].ToLower()) >= 0)
                .Where(p => p.StartTime >= startTime)
                .OrderBy(p => p.StartTime)
                .ThenByDescending(p => p.BasePrice)
                .ThenByDescending(p => p.Name);
            string title = string.Format("Search for \"{0}\"", commandWords[1]);
            this.Output.AppendLine(title);
            this.Output.AppendLine("Performances:");
            if (performances.Count() > 0)
            {
                foreach (var perf in performances)
                {
                    this.Output.AppendLine("-" + perf.Name);
                }
            }
            else
            {
                this.Output.AppendLine("no results");
            }

            this.Output.AppendLine("Venues:");
            if (venues.Count() > 0)
            {
                foreach (var venue in venues)
                {
                    this.Output.AppendLine("-" + venue.Name);
                    var perfVanue = this.Performances.Where(p => p.Venue.Name == venue.Name)
                        .Where(p => p.StartTime >= startTime)
                        .OrderBy(p => p.StartTime)
                        .ThenByDescending(p => p.BasePrice)
                        .OrderBy(p => p.Name); 
                    foreach (var perf in perfVanue)
                    {
                        this.Output.AppendLine("--" + perf.Name);
                    }
                }
            }
            else
            {
                this.Output.AppendLine("no results");
            }
        }
    }
}
