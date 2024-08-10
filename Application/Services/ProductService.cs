using Application.Interfaces.Services;
using Application.UseCases;
using Domain.Entities;

namespace Application.Services
{
  public class ProductService : IProductService
  {
    private readonly ListAllProductsUseCase _listAllProductsUseCase;
    private readonly ListAllAvailableProductsUseCase _listAllAvailableProductsUseCase;
    private readonly GetProductByIdUseCase _getProductByIdUseCase;
    private readonly AddProductUseCase _addProductUseCase;
    private readonly DeleteProductUseCase _deleteProductUseCase;

    public ProductService(
      ListAllProductsUseCase listAllProductsUseCase,
      ListAllAvailableProductsUseCase listAllAvailableProductsUseCase,
      GetProductByIdUseCase getProductByIdUseCase,
      AddProductUseCase addProductUseCase,
      DeleteProductUseCase deleteProductUseCase)
    {
      _listAllProductsUseCase = listAllProductsUseCase;
      _listAllAvailableProductsUseCase = listAllAvailableProductsUseCase;
      _getProductByIdUseCase = getProductByIdUseCase;
      _addProductUseCase = addProductUseCase;
      _deleteProductUseCase = deleteProductUseCase;
    }

    public List<Product> ListAllProducts()
    {
      return _listAllProductsUseCase.Execute();
    }

    public List<Product> ListAllAvailableProducts()
    {
      return _listAllAvailableProductsUseCase.Execute();
    }

    public Product GetProductById(int id)
    {
      return _getProductByIdUseCase.Execute(id);
    }

    public void AddProduct(Product product)
    {
      _addProductUseCase.Execute(product);
    }

    public void DeleteProduct(int id)
    {
      _deleteProductUseCase.Execute(id);
    }
  }
}