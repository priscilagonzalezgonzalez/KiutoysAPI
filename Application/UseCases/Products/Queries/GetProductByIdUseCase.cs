using Application.Interfaces;
using Domain.Entities;

namespace Application.UseCases
{
  public class GetProductByIdUseCase
  {
    private readonly IProductRepository _productRepository;
    public GetProductByIdUseCase(IProductRepository productRepository)
    {
      _productRepository = productRepository;
    }

    public Product Execute(int id)
    {
      return _productRepository.GetById(id);
    }
  }
}