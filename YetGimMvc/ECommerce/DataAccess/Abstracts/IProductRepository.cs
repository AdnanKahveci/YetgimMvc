using ECommerce.Models;

namespace ECommerce.DataAccess.Abstracts;

public interface IProductRepository
{
    void Add(Product product);
    void Update(Product product);
    void Delete(Product product);
    List<Product> GetAll();
    Product? GetById(int id);
}