using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PracticeSignalR.Models;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Security.AccessControl;
using System;

namespace PracticeSignalR.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test()
        {
            return View();
        }
    
        public ViewResult Upload()
        {
            return View();
        }

        public ViewResult Upload1()
        {
            return View();
        }
        public ViewResult ImageCrop()
        {
            return View();
        }
    }
}
