
namespace StudentsAndWorkers
{
    using System;
    public class Worker : Human
    {
        private const int WORKWEEK = 5;
        private decimal weekSalary;
        private short workHoursPerDay;
        public Worker(string firstName, string lastName, decimal weekSalary)
            : base(firstName, lastName)
        {
            this.weekSalary = weekSalary;
        }
        public Worker(string firstName, string lastName, decimal weekSalary, short workHoursPerDay)
            :this(firstName,lastName,weekSalary)
        {
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Week salary is too small value");
                }
                this.weekSalary = value;
            }
        }

        public short WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value < 8)
                {
                    throw new ArgumentException("Work hours per day must be greater");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal hourMoney = (this.weekSalary / WORKWEEK) / this.workHoursPerDay;
            return hourMoney;
        }
    }
}
