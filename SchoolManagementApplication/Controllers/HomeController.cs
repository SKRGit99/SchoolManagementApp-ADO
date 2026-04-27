using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SchoolManagementApplicationBAL;
using SchoolManagementApplicationDAL.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManagementApplication.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            
        }

        public IActionResult displayAboutUs()
        {
            return View();
        }

        public IActionResult displayDirectorMessage()
        {
            return View();
        }

        public IActionResult displayGallery()
        {
            return View();
        }

    }
}
