using ECommerce.Models;

namespace ECommerce.DataAccess.abstracts;

public interface ICategoryRepository
{
    
    void Add(Category category);
    void Update(Category category);
    void Delete(Category category);
    List<Category> GetAll();
    Category? GetById(Guid id);
}