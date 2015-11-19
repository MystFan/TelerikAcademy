namespace KnapsackProblem
{
    public class Product
    {
        public string Name { get; set; }

        public int Cost { get; set; }

        public int Weight { get; set; }

        public override string ToString()
        {
            return "[name: " + this.Name + ", weight: " + this.Weight + ", cost: " + this.Cost + "]"; 
        }
    }
}
