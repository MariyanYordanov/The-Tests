using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;
using TheTests.Core.Contracts;
using TheTests.Models;

namespace TheTests.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IActionResult> Index()
        {
            var tests = await _homeService.GetAllTestAsync();
            return View(tests);
        }
    }

}
