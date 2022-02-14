namespace ChefClassLibrary.Model.Entity.vegetable
{
    public class Onion : Vegetable
    {
        public enum OnionType { LEEK, ONION, POTATO}
        public enum ColorType { WHITE, RED, GREEN}

        public OnionType Type { get; set; }
        public ColorType Color { get; set; }


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


        public Onion()
        {
          
        }


        public Onion(OnionType type, ColorType color,
            int diameter, int defect, double weight, double calorie)
            : base(defect, weight, calorie)
        {
            Type = type;
            Color = color;
            this.diameter = diameter;
        }


        public override string ToString()
        {
            return $"Onion : diameter = {diameter}, type = {Type}, color = {Color} "
                + base.ToString();
        }
    }
}
