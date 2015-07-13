using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class LocalCourse : Course, ICourse
    {
        private string lab;
        public LocalCourse(string name)
            :base(name, String.Empty)
        {
            this.Lab = String.Empty;
        }

        public LocalCourse(string courseName, string teacherName)
            :base(courseName, teacherName)
        {
            this.Lab = String.Empty;
        }

        public LocalCourse(string courseName, string teacherName, IList<string> students)
            :base(courseName, teacherName)
        {
            base.Students = students;
            this.Lab = String.Empty;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Local course lab name can not be null");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            if (this.Lab != null)
            {
                result.Append("; Lab = ");
                result.Append(this.Lab);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
