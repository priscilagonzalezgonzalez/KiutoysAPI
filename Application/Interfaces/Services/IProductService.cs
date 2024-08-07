using Domain.Entities;

namespace Application.Interfaces.Services
{
  public interface IProductService
  {
    //List<Product> ListAllProducts();
    Product GetProductById(int id);
    /* void AddProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(int id); */
  }
}