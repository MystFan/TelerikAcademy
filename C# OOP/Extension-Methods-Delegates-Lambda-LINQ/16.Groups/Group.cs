
namespace _16.Groups
{
    public class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group(int number, string departmentName)
        {
            this.GroupNumber = number;
            this.DepartmentName = departmentName;
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            private set
            {
                this.groupNumber = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return this.departmentName;
            }
            private set
            {
                this.departmentName = value;
            }
        }
    }
}
