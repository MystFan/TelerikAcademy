namespace _01.StudentClass
{
    using System;
    [Serializable]
    public class Course
    {
        public Course(string name)
        {
            this.Name = name;
        }
        public string Name { get; private set; }
    }
}
