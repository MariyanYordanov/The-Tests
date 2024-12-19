using Microsoft.AspNetCore.Mvc.Rendering;
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

        public async Task<Category> AddCategoryAsync(CategoryModel model)
        {
            var category = new Category
            {
                Name = model.Name
            };

            await _repository.AddAsync(category);
            await _repository.SaveChangesAsync();

            return category;
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
    }
}

