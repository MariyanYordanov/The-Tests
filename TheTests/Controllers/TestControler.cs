using TheTests.Core.Contracts;
using TheTests.Core.Models.Test;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using TheTests.Core.Models.Answer;
using TheTests.Core.Models.Question;

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

        [HttpGet]
        public async Task<IActionResult> CreateTest()
        {
            var questionTypes = await _testService.GetQuestionTypesAsync();
            var categories = await _categoryService.GetCategoriesAsync();

            ViewBag.QuestionTypes = questionTypes.Select(q => new SelectListItem
            {
                Value = q.ToString(),
                Text = q.ToString()
            });

            var model = new TestCreateModel
            {
                Categories = categories.Select(c => new SelectListItem
                {
                    Value = c.Id.ToString(),
                    Text = c.Name
                }),
                Questions = new List<QuestionCreateModel>
                {
                    new QuestionCreateModel
                    {
                        Answers = new List<AnswerCreateModel>
                        {
                            new AnswerCreateModel(),
                            new AnswerCreateModel(),
                            new AnswerCreateModel(),
                            new AnswerCreateModel()
                        }
                    }
                }
            };

            return View(model);
        }

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

            await _testService.CreateTestAsync(model);
            return RedirectToAction("Index", "Home");
        }
    }
}
