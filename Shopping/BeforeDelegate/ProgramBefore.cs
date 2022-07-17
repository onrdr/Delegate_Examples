using BeforeDelegate.Library;

namespace BeforeDelegate
{
    public class ProgramBefore
    {
        static readonly ShoppingCartModel cart = new();
        public static void Process()
        {
            PopulateCartWithDemoData();

            Console.WriteLine($"The total for the cart is {cart.GenerateTotal():C2}\n");


            Console.WriteLine($"Press any key to exit");
            Console.ReadKey();

        }

        private static void PopulateCartWithDemoData()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }
    }
}