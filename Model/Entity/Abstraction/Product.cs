namespace ChefClassLibrary.Model.Entity.Abstraction
{
    public class Product
    {
        private double weight;
        private double calorie;

        public Product()
        {
            weight = 0.1;
        }

        public Product(double weight, double calorie)
        {
            this.weight = weight;
            this.calorie = calorie;
        }

        public virtual double Weight
        {
            get { return weight; }
            set {
                if (value > 0)
                {
                    weight = value;
                }
            }
        }

        public virtual double Calorie
        {
            get { return calorie; }
            set{
                if (value >= 0)
                {
                    calorie = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Weight = {weight}, calorie = {calorie} ";
        }

    }
}
