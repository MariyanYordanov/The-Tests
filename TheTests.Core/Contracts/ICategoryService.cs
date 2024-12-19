using TheTests.Core.Models.Category;
using TheTests.Infrastructure.Data.Models;

namespace TheTests.Core.Contracts
{
    public interface ICategoryService
    {
        Task<Category> AddCategoryAsync(CategoryModel model);
        Task<IEnumerable<CategoryModel>> GetCategoriesAsync();
    }
}
