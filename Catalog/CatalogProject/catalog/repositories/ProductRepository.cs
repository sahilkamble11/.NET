using com.transflower.catalog.entities;

namespace com.transflower.catalog.repositories
{
    public class ProductRepository
    {
        public bool AddProduct(Product product)
        {
            return true;
        }
        public Product GetProductById(int id)
        {
            return new Product();
        }
        public bool UpdateProduct(Product product)
        {
            return true;
        }
        public bool DeleteProduct(int id)
        {
            return true; 
        }
    }
}