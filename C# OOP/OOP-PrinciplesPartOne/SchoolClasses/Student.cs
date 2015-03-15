
namespace SchoolClasses
{
    public class Student : Person
    {
        private int classNumber;
        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }
    }

    
}
