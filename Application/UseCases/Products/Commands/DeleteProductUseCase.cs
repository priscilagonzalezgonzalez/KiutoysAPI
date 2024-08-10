using Application.Interfaces;

namespace Application.UseCases
{
  public class DeleteProductUseCase
  {
    private readonly IProductRepository _productRepository;

    public DeleteProductUseCase(IProductRepository productRepository)
    {
      _productRepository = productRepository;      
    }

    public void Execute(int id)
    {
      _productRepository.Delete(id);
    }
  }
}