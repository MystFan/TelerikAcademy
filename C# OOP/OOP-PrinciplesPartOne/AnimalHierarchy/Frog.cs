
namespace AnimalHierarchy
{
    using System.Media;
    using System.Threading;
    public class Frog : Animal
    {
        public Frog(string name, uint age)
            : base(name, age)
        {

        }

        public override void MakeSound()
        {
            using (SoundPlayer player = new SoundPlayer("..\\..\\FrogCroaking.wav"))
            {
                player.Play();
                Thread.Sleep(3000);
            }
        }
    }
}
