using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NewsPress.Areas.Identity.Data;
using NewsPress.Data;
using NewsPress.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NewsPress.Controllers
{
    
    public class HomeController : Controller
    {
    private readonly ApplicationDbContext _db;
        private readonly AuthDbContext _dbAuth;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,ApplicationDbContext db, AuthDbContext dbAuth)
        {
            _logger = logger;
            _db = db;
            _dbAuth = dbAuth;
        }

        public IActionResult Index()
        {
            IEnumerable<Article> objList = _db.Articles;
            IEnumerable<Theme> themeList = _db.Themes;
            ViewBag.themeList = themeList;

            IEnumerable<Author> authorList = _dbAuth.Authors;
            ViewBag.authorList = authorList; 
            return View(objList);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
