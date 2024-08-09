using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
  public class ProductRepository : IProductRepository
  {
    private readonly KiutoysContext _context;

    public ProductRepository(KiutoysContext context)
    {
      _context = context;
    }

    public List<Product> ListAll()
    {
      return _context.Products.ToList();
    }

    public List<Product> ListAllAvailable()
    {
      return _context.Products.Where(x => x.Stock >= 1).ToList();
    }

    public Product GetById(int id)
    {
      Console.WriteLine($"Attempting to retrieve product: {id}");
      return _context.Products.Find(id);
    }

    public void Add(Product product)
    {
      Console.WriteLine($"Attempting to add product: {product.Title}");
      _context.Products.Add(product);
      _context.SaveChanges();
    }

    public void Update(Product product)
    {
      _context.Products.Update(product);
      _context.SaveChanges();
    }

    public void Delete(int id)
    {
      Product product = GetById(id);
      if(product == null)
      {
        // EXCEPTION
      }

      _context.Products.Remove(product);
      _context.SaveChanges();
    }
  }
}