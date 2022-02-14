using System.Text;
using ChefClassLibrary.Model.Entity.Abstraction;

namespace ChefClassLibrary.Model.Entity
{
    public class Dish
    {
        public const int DEFAULT_SIZE = 10;

        private Product[] products;
        private int size; 

        public int Size { get { return size; } }

        public Dish()
        {
            size = 0;
        }


        public Dish(int size) : this()
        {
            products = new Product[size];
        }


        public Dish(Product[] products)
        {
            this.products = products;
            size = products.Length;
        }


        public Product this[int index]
        {
            get {
                if (index >= 0 && index < size)
                {
                    return products[index];
                }
                return null;
            }

            set
            {
                if (value != null && index >= 0 && index < size)
                {
                    products[index] = value;
                }
            }
        }


        public void Add(Product product)
        {
            if (size < products.Length)
            {
                products[size++] = product;
            }
        }


        public void Remove(int index)
        {
            if (index > 0 && index < size)
            {
                for (int i = index; i < size; i++)
                {
                    products[i - 1] = products[i];
                }
            }
            size--;
        }

        
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder("List of products:\n");

            for (int i = 0; i < size; i++)
            {
                builder.Append("\n").Append(products[i]);
            }
            return builder.ToString();
        }
    }
}
