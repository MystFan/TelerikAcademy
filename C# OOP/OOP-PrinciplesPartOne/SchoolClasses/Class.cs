
namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;
    public class Class
    {
        private List<Teacher> teachers;
        public Class()
        {
            this.Id = new Guid();
            this.Teachers = new List<Teacher>();
        }

        public Guid Id { get; set; }
        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            private set
            {
                this.teachers = value;
            }
        }
    }
}
