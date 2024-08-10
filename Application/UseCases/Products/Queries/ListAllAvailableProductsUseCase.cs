using Application.Interfaces;
using Domain.Entities;

namespace Application.UseCases
{
  public class ListAllAvailableProductsUseCase
  {
    private readonly IProductRepository _productRepository;
    public ListAllAvailableProductsUseCase(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public List<Product> Execute()
    {
      return _productRepository.ListAllAvailable();
    }
  }
}