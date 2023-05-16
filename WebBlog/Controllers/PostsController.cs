using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebBlog.Models;

namespace WebBlog.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult reader()
        {
            return View();
        }
    }
}
