using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using TheTests.Core.Contracts;
using TheTests.Core.Models.Test;
using TheTests.Core.Services;
using TheTests.Models;

namespace TheTests.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestService _testService;

        public HomeController(ITestService testService)
        {
            _testService = testService;
        }

        public async Task<IActionResult> Index()
        {
            var publishedTests = await _testService.GetPublishedTestsAsync();
            return View(publishedTests);
        }
    }

}
