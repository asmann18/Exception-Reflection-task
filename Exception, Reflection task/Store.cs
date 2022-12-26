using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exception__Reflection_task
{
    internal class Store
    {
        public Product[] products;
        public Store()
        {
            products = new Product[0];
        }
        public void AddProduct()
        {
            Console.Write("Enter the product name:");
            string name = Console.ReadLine();
            Console.Write("Enter the price of the product:");
            double price;
            restart:
            string pricestr = Console.ReadLine();
            bool amountresult = Double.TryParse(pricestr, out price);
            if (pricestr.Contains(",") || amountresult==false)
            {
                Console.WriteLine("please enter valid price");
                goto restart;
            }

            Console.Write("Choose the food's type:(bakery/drink/meat)");
            Type type;
            restarttype:
            string typestr = Console.ReadLine().ToLower();
            switch (typestr)
            {
                case "meat":
                    type = Type.meat;
                    break;
                case "bakery":
                    type = Type.bakery;
                    break;
                case "drink":
                    type = Type.drink;
                    break;
                default:
                    Console.WriteLine("Please enter valid type");
                    goto restarttype;
                    break;
            }
            Product product = new Product(name, price, type);
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
            Console.Clear();
            Console.WriteLine("The product has been successfully added");
        

        }
        public void RemoveProductByNo()
        {
            int count = 1;
            int count2 = 1;
            Console.WriteLine("Select the index of the product you want to delete");
            foreach (Product product in products)
            {
                Console.WriteLine(count + ". " + product);
                count++;
            }
            int index;
            restartIndex:
            bool TFindex = int.TryParse(Console.ReadLine(), out index);
            if (TFindex == false || index > count)
            {
                Console.WriteLine("Please enter valid index");
                goto restartIndex;
            }
            for (int i = index-1; i+1 < products.Length; i++) 
            {
                    products[i] = products[i + 1];
            }
            Array.Resize(ref products, products.Length - 1);
            Console.Clear();
            Console.WriteLine("The product has been successfully deleted");
            
            foreach (Product product in products)
            {
                Console.WriteLine(count2+". "+product);
                count2++;
            }
        }
        public void FilterProductsByType()
        {
            int count = 0;
            Console.Write("Select the type you are looking for:(bakery/drink/meat)");
            Type type;
            restarttype:
            string typestr = Console.ReadLine().ToLower();
            switch (typestr)
            {
                case "meat":
                    type = Type.meat;
                    break;
                case "bakery":
                    type = Type.bakery;
                    break;
                case "drink":
                    type = Type.drink;
                    break;
                default:
                    Console.WriteLine("Please enter valid type");
                    goto restarttype;
                    break;
            }
            foreach (Product product in products)
            {
                if (product.type == type)
                {
                    count++;
                    Console.WriteLine(count+". "+product);
                }
            }
        }
        public void FilterProductByName()
        {
            int count = 0;
            Console.Write("Enter the name of the product you are looking for:");
            string name = Console.ReadLine().ToLower();
            foreach (Product product in products)
            {
                if (product.name == name)
                {
                    count++;
                    Console.WriteLine(count + ". " + product);
                }

            }
        }
    }
}
