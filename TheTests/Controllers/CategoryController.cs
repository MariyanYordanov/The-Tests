using Microsoft.AspNetCore.Mvc;
using TheTests.Core.Contracts;
using TheTests.Core.Models.Category;

namespace TheTests.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryService _categoryService;

        public CategoryController()
        {
            
        }
        [HttpPost]
        public async Task<IActionResult> AddCategory([FromBody] CategoryModel model)
        {
            if (string.IsNullOrWhiteSpace(model.Name))
            {
                return BadRequest(new { message = "Category name is required." });
            }

            var category = await _categoryService.AddCategoryAsync(model);

            return Ok(new { id = category.Id, name = category.Name });
        }

    }
}
