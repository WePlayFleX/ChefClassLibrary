using ChefClassLibrary.Model.Entity.Abstraction;

namespace ChefClassLibrary.Model.Entity.vegetable
{
    public class Vegetable : Product
    {
        private int defect;
        public int Defect
        {
            get { return defect; }
            set
            {
                if (value > 0)
                {
                    defect = value;
                }

            }
        }


        public Vegetable()
        {

        }


        public Vegetable(int defect, double weight, double calorie)
            : base (weight, calorie)
        {
            this.defect = defect;
        }
    }
}
