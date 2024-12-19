using Microsoft.AspNetCore.Mvc;
using TheTests.Core.Contracts;
using TheTests.Core.Models.Answer;
using TheTests.Core.Models.Question;

namespace TheTests.Controllers
{
    public class QuestionController : Controller
    {
        private readonly IQuestionService _questionService;

        public QuestionController(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        // GET: Display form for creating a new question
        [HttpGet]
        public IActionResult CreateQuestion()
        {
            var model = new QuestionCreateModel
            {
                Answers = new List<AnswerCreateModel>
                {
                    new AnswerCreateModel(),
                    new AnswerCreateModel()
                }
            };

            return View(model);
        }

        // POST: Save the question to the database
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateQuestion(QuestionCreateModel questionModel)
        {
            if (!ModelState.IsValid)
            {
                return View(questionModel); // Return the same view if validation fails
            }

            await _questionService.CreateQuestionAsync(questionModel);

            return RedirectToAction("Index", "Home"); // Redirect to a list of questions or another page
        }
    }
}
