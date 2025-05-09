using ECommerce.Models;

namespace ECommerce.Services.Abstracts;

public interface ICategoryService
{
    List<Category> GetAll();
    Category? GetById(Guid id);
    void Add(Category category);
    void Update(Category category);
    void Delete(Guid id);    
}