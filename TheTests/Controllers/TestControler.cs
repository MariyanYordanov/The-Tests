using TheTests.Core.Contracts;
using TheTests.Core.Models.Test;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TheTests.Core.Models.Answer;
using TheTests.Core.Models.Question;
using Microsoft.AspNetCore.Identity;
using TheTests.Infrastructure.Data.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security.Claims;

namespace TheTests.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestService _testService;
        private readonly ICategoryService _categoryService;

        public TestController(ITestService testService, 
            ICategoryService categoryService)
        {
            _testService = testService;
            _categoryService = categoryService;
        }

        /// <summary>
        /// The create test action
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> CreateTest()
        {
            var questionTypes = await _testService.GetQuestionTypesAsync();
            var questionTypeItems = questionTypes.Select(q => new SelectListItem
            {
                Value = q.ToString(),
                Text = q.ToString()
            }).ToList();

            var categories = await _categoryService.GetCategoriesAsync();
            var categoryItems = categories.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            }).ToList();

            var model = new TestCreateModel
            {
                QuestionTypes = questionTypeItems,
                Categories = categoryItems
            };

            return View(model);
        }


        /// <summary>
        /// Тhe create test action
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateTest(TestCreateModel model)
        {
            if (!ModelState.IsValid)
            {
                var questionTypes = await _testService.GetQuestionTypesAsync();
                var categories = await _categoryService.GetCategoriesAsync();

                ViewBag.QuestionTypes = questionTypes.Select(q => new SelectListItem
                {
                    Value = q.ToString(),
                    Text = q.ToString()
                });

                model.Categories = categories.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                });

                return View(model);
            }

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); 
            model.CreatorId = userId;

            await _testService.CreateTestAsync(model); 
            return RedirectToAction("Index", "Home");
        }


        /// <summary>
        /// The my tests action
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> MyTests()
        {
            var tests = await _testService.GetAllTestsByUserIdAsync(User.Id());

            return View(tests);
        }

    }
}
