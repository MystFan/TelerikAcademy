
namespace SchoolClasses
{
    using System.Collections.Generic;
    public class Teacher : Person
    {
        private List<Discipline> disciplines;
        public Teacher(string firstName, string lastName)
            : base(firstName, lastName)
        {
            this.disciplines = new List<Discipline>();
        }

        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            private set
            {
                this.disciplines = value;
            }
        }
    }
}
