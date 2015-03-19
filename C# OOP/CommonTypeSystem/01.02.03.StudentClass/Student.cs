
namespace _01.StudentClass
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    [Serializable]
    public class Student : ICloneable, IComparable
    {
        private long ssn;
        public Student(string firstName, string middleName, string lastName, long ssn)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
        }
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public long SSN 
        {
            get
            {
                return this.ssn;
            }
            private set
            {
                if (value.ToString().Length != 10)
                {
                    throw new ArgumentException("Student SSN number should be exact 10 digits");
                }
                this.ssn = value;
            } 
        }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Course Course { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }
        public Specialty Specialty { get; set; }

        public override string ToString()
        {
            string studentAsString = string.Format("{0} {1} {2} --> {3}",
                this.FirstName, this.MiddleName, this.LastName, this.SSN);
            return studentAsString;
        }

        public override bool Equals(object st)
        {
            Student student = st as Student;
            if (student == null)
            {
                throw new ArgumentNullException("The comparable object is null");
            }

            if (this.SSN == student.SSN)
            {
                return true;
            }

            return false;
        }

        public static bool operator ==(Student first, Student second)
        {
            return Student.Equals(first, second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !(Student.Equals(first, second));
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.ToString().GetHashCode();
        }

        public object Clone()
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, this);
                ms.Position = 0;
                return (Student)(formatter.Deserialize(ms));
            }
        }

        public int CompareTo(object obj)
        {
            Student inputStudent = obj as Student;
            if (inputStudent == null)
            {
                throw new ArgumentNullException("The comparable object is null");
            }

            string firstStudentName = this.FirstName;
            string secondStudentName = inputStudent.FirstName;
            long firstStudentSSN =  this.SSN;
            long secondStudentSSN = inputStudent.SSN;

            if (string.Compare(firstStudentName, secondStudentName, StringComparison.Ordinal) <= 0)
            {
                if (firstStudentSSN < secondStudentSSN)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else if (string.Compare(firstStudentName, secondStudentName, StringComparison.Ordinal) > 0)
            {
                if (secondStudentSSN < firstStudentSSN)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }

            return 0;
        }
    }
}
