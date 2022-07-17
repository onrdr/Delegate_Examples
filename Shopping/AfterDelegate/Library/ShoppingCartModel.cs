
namespace AfterDelegate.Library
{ 
    public class ShoppingCartModel
    {
        public delegate void DisplaySubtotal(decimal subTotal);
        public List<ProductModel> Items { get; set; } = new();

        public decimal GenerateTotal(DisplaySubtotal displaySubtotal,
            Func<List<ProductModel>, decimal, decimal> calculateTotalAfterDiscount,
            Action<string> discountingMessage)
        {
            decimal subTotal = Items.Sum(x => x.Price);

            displaySubtotal(subTotal);

            discountingMessage("We are applying your discount");

            return calculateTotalAfterDiscount(Items, subTotal);
        }
    }
}
