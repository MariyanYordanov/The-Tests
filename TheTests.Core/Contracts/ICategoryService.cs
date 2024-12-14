using TheTests.Core.Models.Category;

namespace TheTests.Core.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryModel>> GetCategoriesAsync();
    }
}
