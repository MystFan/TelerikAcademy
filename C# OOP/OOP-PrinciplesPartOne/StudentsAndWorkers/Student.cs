
namespace StudentsAndWorkers
{
    public class Student : Human
    {
        private uint grade;
        public Student(string firstName,string lastName, uint grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public uint Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                this.grade = value;
            }
        }
    }
}
