using ConsoletoWebApi.Models;

namespace ConsoletoWebApi.Services
{
    public class ProductService : IProductService
    {
        private List<ProductModel> products = new List<ProductModel>();
        public int AddProduct(ProductModel product)
        {
            product.ProductID = products.Count + 1;
            products.Add(product);

            return product.ProductID;
        }

        public List<ProductModel> GetAllProducts()
        {
            return products;
        }
    }


}
