using ECommerce.DataAccess.abstracts;
using ECommerce.Models;
using ECommerce.Services.Abstracts;

namespace ECommerce.Services.Concretes;

public class CategoryService : ICategoryService
{
    private ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public List<Category> GetAll()
    {
        return _categoryRepository.GetAll();
    }

    public Category? GetById(Guid id)
    {
        return _categoryRepository.GetById(id);
    }

    public void Add(Category category)
    { 
        _categoryRepository.Add(category);    
    }

    public void Update(Category category)
    {
        _categoryRepository.Update(category);   
    }

    public void Delete(Guid id)
    {
        Category category = _categoryRepository.GetById(id);
        _categoryRepository.Delete(category);   
    }
}