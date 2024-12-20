﻿using TheTests.Core.Contracts;
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


        public async Task<IActionResult> Details(int testId)
        {
            try
            {
                var test = await _testService.GetTestDetailsAsync(testId);
                return View(test);
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = ex.Message;
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = "An unexpected error occurred.";
                return RedirectToAction("Index", "Home");
            }
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
            var model = await _testService.GetTestForSolvingAsync(testId);

            if (model == null)
            {
                TempData["ErrorMessage"] = "Test not found.";
                return RedirectToAction("Home", "Test");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitTest(TestSubmissionModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Invalid test submission.";
                return RedirectToAction("SolveTest", new { testId = model.Id });
            }

            try
            {
                await _testService.EvaluateTestAsync(model,User.Id());
                TempData["SuccessMessage"] = "Test submitted successfully!";
                return RedirectToAction("MyResults", "Test");
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Failed to submit test: {ex.Message}";
                return RedirectToAction("SolveTest", new { testId = model.Id });
            }
        }

        [HttpGet]
        [Route("Test/DeleteTest/Confirm/{testId}")]
        public IActionResult DeleteTest(int testId)
        {
            return View(testId); 
        }

        [HttpPost]
        [Route("Test/DeleteTest/Perform")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteTestConfirmed(int testId)
        {
            try
            {
                await _testService.DeleteTestAsync(testId);
                TempData["SuccessMessage"] = "Test deleted successfully!";
            }
            catch (ArgumentException ex)
            {
                TempData["ErrorMessage"] = $"Error: {ex.Message}";
            }
            catch (Exception ex)
            {
                TempData["ErrorMessage"] = $"Failed to delete test: {ex.Message}";
            }

            return RedirectToAction("MyTests");
        }

    }
}
