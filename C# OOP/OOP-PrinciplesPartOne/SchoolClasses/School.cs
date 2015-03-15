/*Problem 1. School classes

    We are given a school. In the school there are classes of students. Each class has a set of teachers. 
 * Each teacher teaches a set of disciplines. Students have name and unique class number. 
 * Classes have unique text identifier. Teachers have name. Disciplines have name, number of lectures and number of exercises. 
 * Both teachers and students are people. Students, classes, teachers and disciplines could have optional comments (free text block).
    Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, 
 * define the class hierarchy and create a class diagram with Visual Studio.
*/

namespace SchoolClasses
{
    using System.Collections.Generic;
    public class School
    {
        private List<Student> students;
        private List<Class> classes;
        public School()
        {
            this.Students = new List<Student>();
            this.Classes = new List<Class>();
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            private set
            {
                this.students = value;
            }
        }

        public List<Class> Classes
        {
            get
            {
                return this.classes;
            }
            private set
            {
                this.classes = value;
            }
        }
    }
}
