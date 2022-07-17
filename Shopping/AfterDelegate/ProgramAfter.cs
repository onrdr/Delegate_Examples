using AfterDelegate.Library;

namespace AfterDelegate
{ 
    public class ProgramAfter
    {
        static readonly ShoppingCartModel cart = new();
        public static void Process()
        {
            FillTheShoppingCart();

            Console.WriteLine($"The total for the cart is {cart.GenerateTotal(DisplaySubtotal, CalculateTotalAfterDiscount, DisplayDiscountingMessage):C2}\n");

            #region Same operation above with Lambda : We don't need the methods below. We included methods inside GenerateTotal method below. 

             decimal total = cart.GenerateTotal((subTotal) => Console.WriteLine($"The subtotal for cart2 is {subTotal:C2}"),
                (products, subTotal) =>
                {
                    if (products.Count > 3)
                        return subTotal * 0.5M;
                   else
                        return subTotal; 
                },
                (message) => Console.WriteLine($"Cart 2 Alert : {message}"));

            Console.WriteLine($"The total for the cart2 is {total:C2}\n");
            #endregion


            Console.WriteLine($"Press any key to exit");
            Console.ReadKey();

        }

        private static void DisplaySubtotal(decimal subTotal)
        {
            Console.WriteLine($"The subtotal is {subTotal:C2}");
        }

        private static decimal CalculateTotalAfterDiscount(List<ProductModel> items, decimal subTotal)
        {
            if (subTotal > 100)
                return subTotal * 0.80M;

            else if (subTotal > 50)
                return subTotal * 0.85M;

            else if (subTotal > 10)
                return subTotal * 0.95M;

            else
                return subTotal;
        }

        private static void DisplayDiscountingMessage(string message)
        {
            Console.WriteLine(message);
        }

        private static void FillTheShoppingCart()
        {
            cart.Items.Add(new ProductModel { ItemName = "Cereal", Price = 3.63M });
            cart.Items.Add(new ProductModel { ItemName = "Milk", Price = 2.95M });
            cart.Items.Add(new ProductModel { ItemName = "Strawberries", Price = 7.51M });
            cart.Items.Add(new ProductModel { ItemName = "Blueberries", Price = 8.84M });
        }
    }
}