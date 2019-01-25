using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCoreNewDatabase.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EFCoreNewDatabase.Controllers
{
    public class HomeController : Controller
    {
        // this controller depends on the BloggingRepository
        private IBloggingRepository repository;
        public HomeController(IBloggingRepository repo) => repository = repo;

        public IActionResult Index() => View(repository.Blogs.OrderBy(b => b.Url));
        public IActionResult AddBlog() => View();
    }
}
