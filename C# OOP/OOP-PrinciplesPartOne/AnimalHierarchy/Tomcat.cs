
namespace AnimalHierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, uint age)
            :base(name,age)
        {
            this.Sex = SexType.Male;
        }

        public override void MakeSound()
        {
            System.Console.WriteLine("Maaaaaaaaaaay");
        }
    }
}
