using Application.Interfaces.Services;
using Application.UseCases;
using Domain.Entities;

namespace Application.Services
{
  public class ProductService : IProductService
  {
    private readonly GetProductByIdUseCase _getProductByIdUseCase;
    // Yet to implement 
    //private readonly ListAllProductsUseCase _listProducts;
    // ... 
    public ProductService(GetProductByIdUseCase getProductByIdUseCase)
    {
      _getProductByIdUseCase = getProductByIdUseCase;
    }

    public Product GetProductById(int id)
    {
      return _getProductByIdUseCase.Execute(id);
    }
  }
}