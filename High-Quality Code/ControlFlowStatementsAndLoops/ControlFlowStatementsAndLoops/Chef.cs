namespace ControlFlowStatementsAndLoops
{
    public class Chef
    {
        public void Cook()
        {
            Bowl bowl;
            bowl = this.GetBowl();

            Potato potato = this.GetPotato();
            this.Peel(potato);
            this.Cut(potato);
            bowl.Add(potato);

            Carrot carrot = this.GetCarrot();
            this.Peel(carrot);
            this.Cut(carrot);
            bowl.Add(carrot);
        }
        
        private Bowl GetBowl()
        {
            // ... 
        }

        private Carrot GetCarrot()
        {
            // ...
        }

        private void Cut(Vegetable potato)
        {
            // ...
        }

        private Potato GetPotato()
        {
            // ...
        }
    }
}
