using App.Models;

namespace App.Services
{
  public class ProductService : List<ProductModel>
  {
    public ProductService()
    {
      this.AddRange(new ProductModel[] {
        new ProductModel() {Id = 1, Name = "IPhone 14 Pro", Price = 1000},
        new ProductModel() {Id = 2, Name = "IPhone 14", Price = 800},
        new ProductModel() {Id = 3, Name = "IPhone 13", Price = 600},
        new ProductModel() {Id = 4, Name = "IPhone X", Price = 500},
      });
    }
  }
}