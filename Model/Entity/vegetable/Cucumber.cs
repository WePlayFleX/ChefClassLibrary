namespace ChefClassLibrary.Model.Entity.vegetable
{
    public class Cucumber : Vegetable
    {
        public enum TasteType { SWEET, BITTER }


        private int lenght;
        public int Lenght
        {
            get { return lenght; }
            set
            {
                if (value > 0)
                {
                    lenght = value;
                }

            }
        }


        private TasteType Taste { get; set; }


       
        public Cucumber()
        {

        }


        public Cucumber(TasteType taste, int lenght, int defect, double weight, double calorie) 
            : base(defect, weight, calorie)
        {
            Taste = taste;
            this.lenght = lenght;
        }


        public override string ToString()
        {
            return $"Cucumber : lenght = {lenght}, " +
                $"taste = {Taste}, "
                + base.ToString();
        }


    }
}
