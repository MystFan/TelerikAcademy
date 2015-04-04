using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightlifeEntertainment
{
    public class StudentTicket : Ticket
    {
        public StudentTicket(IPerformance performance)
            : base(performance, TicketType.Student)
        {
        }

        protected override decimal CalculatePrice()
        {
            if (this.Performance == null)
            {
                throw new ArgumentException("The price cannot be calculated because there is no performance for this ticket.");
            }

            decimal studentTicketPrice = (this.Performance.BasePrice / 100) * 80;
            return studentTicketPrice;
        }
    }
}
