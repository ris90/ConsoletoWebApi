using ConsoletoWebApi.Models;

namespace ConsoletoWebApi.Services
{
    public interface IProductService
    {
        int AddProduct(ProductModel product);
        List<ProductModel> GetAllProducts();
    }
}