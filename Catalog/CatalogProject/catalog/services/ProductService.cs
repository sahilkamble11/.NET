using com.transflower.catalog.entities;

namespace com.transflower.catalog.services
{
    public class ProductService
    {
        public decimal CalculateDiscountedPrice(decimal price, decimal percentage)
        {
            return price - (price*percentage/100);
        }
        public bool CheckStockAvailability(int stock, int requiredQuantity)
        {
            return stock >= requiredQuantity;
        }
        public void LikeProduct(Product product)
        {
            int currentLikes = product.GetLikes();
            product.SetLikes(currentLikes + 1);
        }
    }
}
