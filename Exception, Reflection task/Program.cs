namespace Exception__Reflection_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            restart:         
            Console.WriteLine("welcome to Asman market :)");
            Console.WriteLine("1.Add Product");
            Console.WriteLine("2.Remove Product");
            Console.WriteLine("3.Filter Products By Type");
            Console.WriteLine("4.Filter Products By Name");

            string menuResult = Console.ReadLine();
            switch (menuResult)
            {
                case "1":
                    store.AddProduct();
                    goto restart;
                    break;
                case "2":
                    store.RemoveProductByNo();
                    goto restart;
                    break;
                default:
                    break;
            }

        }
    }
}