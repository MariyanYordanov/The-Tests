using Microsoft.AspNetCore.Mvc;
using TheTests.Core.Contracts;
using TheTests.Core.Models.Category;

public class CategoryController : Controller
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet]
    public async Task<IActionResult> ManageCategories()
    {
        var categories = await _categoryService.GetCategoriesAsync();
        return View(categories);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View(new CategoryModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Add(CategoryModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await _categoryService.AddCategoryAsync(model);
        return RedirectToAction(nameof(ManageCategories));
    }
    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var category = await _categoryService.GetCategoryByIdAsync(id);
        if (category == null)
        {
            return NotFound();
        }

        // Map the data model to the view model
        var model = new CategoryModel
        {
            Id = category.Id,
            Name = category.Name
        };

        return View(model);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(CategoryModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        try
        {
            await _categoryService.UpdateCategory(model); 
            TempData["SuccessMessage"] = "Category updated successfully!";
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, $"An error occurred: {ex.Message}");
            return View(model);
        }

        return RedirectToAction(nameof(ManageCategories));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _categoryService.DeleteCategory(id);
            TempData["SuccessMessage"] = "Category deleted successfully!";
        }
        catch (InvalidOperationException ex)
        {
            TempData["ErrorMessage"] = ex.Message;
        }
        catch (Exception ex)
        {
            TempData["ErrorMessage"] = $"Failed to delete category: {ex.Message}";
        }

        return RedirectToAction("ManageCategories");
    }

}
