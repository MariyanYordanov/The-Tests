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
            var categories = await _repository
                .AllReadonly<Category>()
                .ToListAsync();

            return categories.Select(c => new CategoryModel
            {
                Id = c.Id,
                Name = c.Name
            });
        }

    }
}

