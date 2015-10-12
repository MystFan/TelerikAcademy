namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Entry : IComparable<Entry>
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                this.name = value;
            }
        }

        public SortedSet<string> Phones { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append('[');
            sb.Append(this.Name);
            bool flag = true;

            foreach (var phone in this.Phones)
            {
                if (flag)
                {
                    sb.Append(": ");
                    flag = false;
                }
                else
                {
                    sb.Append(", ");
                }

                sb.Append(phone);
            }

            sb.Append(']');
            return sb.ToString();
        }

        public int CompareTo(Entry otherEntry)
        {
            return this.name.CompareTo(otherEntry.name);
        }
    }
}
