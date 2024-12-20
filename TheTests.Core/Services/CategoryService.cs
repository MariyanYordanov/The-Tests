using Microsoft.EntityFrameworkCore;
using TheTests.Core.Contracts;
using TheTests.Core.Models.Category;
using TheTests.Infrastructure.Data.Common;
using TheTests.Infrastructure.Data.Models;

namespace TheTests.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository _repository;
  
        public CategoryService(IRepository repository)
        { 
            _repository = repository;
        }

       
        public async Task<IEnumerable<CategoryModel>> GetCategoriesAsync()
        {
            return await _repository.AllReadonly<Category>()
                .Select(c => new CategoryModel
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToListAsync();
        }

        public async Task<Category> AddCategoryAsync(CategoryModel model)
        {
            var category = new Category
            {
                Name = model.Name
            };

            await _repository.AddAsync(category);
            await _repository.SaveChangesAsync();

            model.Id = category.Id;

            return category;
        }


        public async Task<Category> GetCategoryByIdAsync(int id) 
            => await _repository.All<Category>().FirstOrDefaultAsync(c => c.Id == id);

        public async Task UpdateCategory(CategoryModel model)
        {
            var category = await _repository.GetByIdAsync<Category>(model.Id);
            if (category == null)
            {
                throw new ArgumentException("Category not found.");
            }

            category.Name = model.Name;
            await _repository.SaveChangesAsync();
        }

        public async Task DeleteCategory(int id)
        {
            var category = await _repository.All<Category>()
                .Include(c => c.Tests) 
                .FirstOrDefaultAsync(c => c.Id == id);

            if (category == null)
            {
                throw new InvalidOperationException($"Category with ID {id} not found.");
            }

            if (category.Tests != null && category.Tests.Any())
            {
                throw new InvalidOperationException("Cannot delete category with associated tests.");
            }

            _repository.Delete(category);

            await _repository.SaveChangesAsync();
        }
    }
}

