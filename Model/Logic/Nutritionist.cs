using ChefClassLibrary.Model.Entity.Abstraction;
using ChefClassLibrary.Model.Entity;

namespace ChefClassLibrary.Model.Logic
{
    public static class Nutritionist
    {
        public static int CountProducts(double calorie, Dish dish)          //сделать private после теста
        {
            if (dish == null || calorie < 0)
            {
                return -1;
            }

            int count = 0;

            for (int i = 0; i < dish.Size; i++)
            {
                if (calorie ==  dish[i].Calorie )
                {
                    count++;
                }
            }
            return count;
        }


        private static double FindMaxCalorie(Dish dish)
        {
            double max = dish[0].Calorie;

            for (int i = 0; i < dish.Size; i++)
            {
                if (max < dish[i].Calorie)
                {
                    max = dish[i].Calorie;
                }
            }
            return max;
        }


        public static double FindMinCalorie(Dish dish)
        {
            double min = dish[0].Calorie;

            for (int i = 0; i < dish.Size; i++)
            {
                if (min > dish[i].Calorie)
                {
                    min = dish[i].Calorie;
                }
            }
            return min;
        }


        private static Product[] FindProduct(Dish dish, double calorie)
        {
            int count = CountProducts(calorie, dish);

            Product[] products = new Product[count];

            for (int i = 0, j = 0; i < dish.Size; i++)
            {
                if (calorie == dish[i].Calorie)
                {
                    products[j++] = dish[i];
                }
            }
            return products;
        }


        public static Product[] FindMaxCalorieProduct(Dish dish)
        {
            if (dish == null || dish.Size == 0)
            {
                return null;
            }

            double max = FindMaxCalorie(dish);
            return FindProduct(dish, max);       
        }


        public static Product[] FindMinCalorieProduct(Dish dish)
        {
            double min = FindMinCalorie(dish);
            return FindProduct(dish, min);
        }

       
        public static double CalculateTotalCalories(Dish dish)
        {
            double total = 0;

            for (int i = 0; i < dish.Size; i++)
            {
                total += dish[i].Calorie;
            }
            return total;
        }


        private static int CountProductsByWeight(double weight, Dish dish)
        {
            int count = 0;

            for (int i = 0; i < dish.Size; i++)
            {
                if (weight == dish[i].Weight)
                {
                    count++;
                }
            }
            return count;
        }


        private static double FindMaxWeight(Dish dish)
        {
            double max = dish[0].Weight;

            for (int i = 0; i < dish.Size; i++)
            {
                if (max < dish[i].Weight)
                {
                    max = dish[i].Weight;
                }
            }
            return max;
        }


        public static double FindMinWeight(Dish dish)
        {
            double min = dish[0].Weight;

            for (int i = 0; i < dish.Size; i++)
            {
                if (min > dish[i].Weight)
                {
                    min = dish[i].Weight;
                }
            }
            return min;
        }


        private static Product[] FindProductByWeight(Dish dish, double weight)
        {
            int count = CountProducts(weight, dish);

            Product[] products = new Product[count];

            for (int i = 0, j = 0; i < dish.Size; i++)
            {
                if (weight == dish[i].Weight)
                {
                    products[j++] = dish[i];
                }
            }
            return products;
        }


        public static Product[] FindMaxWeightProduct(Dish dish)
        {
            double max = FindMaxWeight(dish);
            return FindProductByWeight(dish, max);
        }


        public static Product[] FindMinWeightProduct(Dish dish)
        {
            double min = FindMinWeight(dish);
            return FindProductByWeight(dish, min);
        }


        public static double CalculateTotalWeight(Dish dish)
        {
            double total = 0;

            for (int i = 0; i < dish.Size; i++)
            {
                total += dish[i].Weight;
            }
            return total;
        }
    }
}
