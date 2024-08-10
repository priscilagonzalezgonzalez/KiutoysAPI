using Application.Interfaces;
using Domain.Entities;

namespace Application.UseCases
{
  public class AddProductUseCase
  {
    private readonly IProductRepository _productRepository;
    public AddProductUseCase(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public void Execute(Product product)
    {
      _productRepository.Add(product);
    }
  }
}