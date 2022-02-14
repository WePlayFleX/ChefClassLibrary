namespace ChefClassLibrary.Model.Entity.vegetable
{
    public class Tomato : Vegetable
    {
        public enum ColorType { RED, BLACK, GREEN, YELLOW, ORANGE, PINK }
        public enum DensityType { SOFT, MEDIUM, HARD }

        private int diameter;
        public int Diameter
        {
            get { return diameter; }
            set
            {
                if (value > 0)
                {
                    diameter = value;
                }

            }
        }

        public DensityType Density { get; set; }

        public ColorType Color { get; set; }


        public Tomato()
        {

        }


        public Tomato(int diameter, DensityType density, ColorType color,
            int defect, double weight, double calorie)
            : base(defect, weight, calorie)
        {
            this.diameter = diameter;
            Density = density;
            Color = color;

        }


        public override string ToString()
        {
            return $"Tomato : diameter = {diameter}, " +
                $"density = {Density}, " +
                $"color = {Color}, "
                + base.ToString();
        }
    }
}
