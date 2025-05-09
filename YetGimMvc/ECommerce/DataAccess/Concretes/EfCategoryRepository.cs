using ECommerce.DataAccess.abstracts;
using ECommerce.DataAccess.Contexts;
using ECommerce.Models;

namespace ECommerce.DataAccess.Concretes;

public class EfCategoryRepository : ICategoryRepository
{
    private BaseDbContext _context;
    public EfCategoryRepository(BaseDbContext context)
    {
        _context = context;
    }

    public void Add(Category category)
    {
        category.CreatedTime = DateTime.Now;
        _context.Categories.Add(category);
        _context.SaveChanges();
    }
    public void Update(Category category)
    {
        category.UpdatedTime = DateTime.Now;
        _context.Categories.Update(category);
        _context.SaveChanges();
    }
    public void Delete(Category category)
    {
        category.CreatedTime = DateTime.Now;
        _context.Categories.Remove(category);
        _context.SaveChanges();
    }
    public List<Category> GetAll()
    {
        return _context.Categories.ToList();
    }

    public Category? GetById(Guid id)
    {
        return _context.Categories.Find(id);
    }
}