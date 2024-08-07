using Domain.Entities;

namespace Application.Interfaces
{
  public interface IProductRepository
  {
    List<Product> ListAll();
    Product GetById(int id);
    void Add(Product product);
    void Update(Product product);
    void Delete(int id);
  }
  
}
