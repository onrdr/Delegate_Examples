
namespace BeforeDelegate.Library
{
    public class ShoppingCartModel
    {
        public List<ProductModel> Items { get; set; } = new();

        public decimal GenerateTotal()
        {
            decimal subTotal = Items.Sum(x => x.Price);

            if (subTotal > 100)
                return subTotal * 0.80M;

            else if (subTotal > 50)
                return subTotal * 0.85M;

            else if (subTotal > 10)
                return subTotal * 0.90M;

            else
                return subTotal;
        }
    }
}