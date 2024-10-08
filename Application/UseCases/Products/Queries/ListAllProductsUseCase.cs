using Application.Interfaces;
using Domain.Entities;

namespace Application.UseCases
{
  public class ListAllProductsUseCase
  {
    private readonly IProductRepository _productRepository;
    public ListAllProductsUseCase(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public List<Product> Execute()
    {
      return _productRepository.ListAll();
    }
  }
}