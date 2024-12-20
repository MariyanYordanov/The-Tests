using TheTests.Core.Contracts;
using TheTests.Core.Models.Test;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace TheTests.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestService _testService;
        private readonly ICategoryService _categoryService;

        public TestController(ITestService testService, ICategoryService categoryService)
        {
            _testService = testService;
            _categoryService = categoryService;
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UnpublishTest(int testId)
        {
            try
            {
                await _testService.UnpublishTestAsync(testId, User.Id());
                TempData["SuccessMessage"] = "Test unpublished successfully.";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Failed to unpublish test: {ex.Message}";
            }

            return RedirectToAction("MyTests");
        }



        [HttpGet]
        public async Task<IActionResult> Details(int testId)
        {
            var test = await _testService.GetTestDetailsAsync(testId);
            return View(test);
        }

        [HttpGet]
        public async Task<IActionResult> MyTests()
        {
            var tests = await _testService.GetAllTestsByUserIdAsync(User.Id());
            return View(tests);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeactivateTest(int testId)
        {
            try
            {
                await _testService.DeactivateTestAsync(testId);
                TempData["SuccessMessage"] = "Test deactivated successfully.";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Failed to deactivate test: {ex.Message}";
            }

            return RedirectToAction("MyTests");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ActivateTest(int testId)
        {
            await _testService.ActivateTestAsync(testId, User.Id());
            TempData["SuccessMessage"] = "Test activated successfully!";
            return RedirectToAction("MyTests");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> PublishTest(int testId)
        {
            try
            {
                await _testService.PublishTestAsync(testId);
                TempData["SuccessMessage"] = "Test published successfully!";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Failed to publish test: {ex.Message}";
            }

            return RedirectToAction("MyTests");
        }


        [HttpGet]
        public async Task<IActionResult> CreateTest()
        {
            var categories = await _categoryService.GetCategoriesAsync();
            var model = new TestCreateModel
            {
                Categories = categories.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                })
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTest(TestCreateModel model)
        {
            var userId = User.Id();

            if (string.IsNullOrEmpty(userId))
            {
                throw new Exception("User ID is null or empty.");
            }

            model.CreatorId = userId;

            if (!ModelState.IsValid)
            {
                foreach (var modelStateKey in ModelState.Keys)
                {
                    var value = ModelState[modelStateKey];
                    foreach (var error in value.Errors)
                    {
                        Console.WriteLine($"Key: {modelStateKey}, Error: {error.ErrorMessage}");
                    }
                }
                return View(model); 
            }

            var testId = await _testService.CreateTestAsync(model);
            return RedirectToAction("EditTest", new { testId });
        }

        [HttpGet]
        public async Task<IActionResult> EditTest(int testId)
        {
            var userId = User.Id();

            if (string.IsNullOrEmpty(userId))
            {
                return Unauthorized("User is not logged in.");
            }

            try
            {
                var test = await _testService.GetTestForEditAsync(testId, userId);

                if (test == null)
                {
                    return NotFound($"Test with ID {testId} was not found.");
                }

                return View(test);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditTest(TestEditModel model)
        {
            if (!ModelState.IsValid)
            {
                foreach (var key in ModelState.Keys)
                {
                    var value = ModelState[key];
                    foreach (var error in value.Errors)
                    {
                        Console.WriteLine($"Key: {key}, Error: {error.ErrorMessage}");
                    }
                }
                return View(model);
            }

            try
            {
                await _testService.UpdateTestAsync(model);
                TempData["SuccessMessage"] = "Test updated successfully!";
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"An error occurred: {ex.Message}");
                return View(model);
            }

            return RedirectToAction("MyTests");
        }

        [HttpGet]
        public async Task<IActionResult> SolveTest(int testId)
        {
            var test = await _testService.GetTestForSolvingAsync(testId, User.Id());
            if (test == null)
            {
                return NotFound("Test not found or you do not have access.");
            }

            return View(test);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitTest(TestSubmissionModel model)
        {
            try
            {
                var result = await _testService.EvaluateTestAsync(model, User.Id());
                return RedirectToAction("Result", new { testId = result.TestId });
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
                return View("SolveTest", model);
            }
        }

        [HttpGet]
        public async Task<IActionResult> Delete()
        {
            var tests = await _testService.GetAllTestsByUserIdAsync(User.Id());
            return View(tests);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int testId)
        {
            try
            {
                await _testService.DeleteTestAsync(testId);
                TempData["SuccessMessage"] = "Test deleted successfully!";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Failed to delete test: {ex.Message}";
            }

            return RedirectToAction("MyTests");
        }

    }
}
