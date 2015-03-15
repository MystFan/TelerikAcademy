
namespace SchoolClasses
{
    using System;
    public class Discipline
    {
        private string name;
        private int numberLectures;
        private int numberExercises;

        public Discipline(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Discipline name is too short");
                }
                this.name = value;
            }
        }

        public int NumberLectures
        {
            get
            {
                return this.numberLectures;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Discipline lectures should be larger by 0");
                }
                this.numberLectures = value;
            }
        }

        public int NumberExercises
        {
            get
            {
                return this.numberExercises;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Discipline exercises should be 0 or larger by 0");
                }
                this.numberExercises = value;
            }
        }
    }
}
