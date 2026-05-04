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

        public IActionResult displayPrincipalMessage()
        {
            return View();
        }

        public IActionResult displayHistoryPage()
        {
            return View();
        }

        public IActionResult displayManagingCommittee()
        {
            return View();
        }

        public IActionResult displayAdmissionProcess()
        {
            return View();
        }

        public IActionResult displayAcademicCalender()
        {
            return View();
        }

        public IActionResult displayFeeStructure()
        {
            return View();
        }
        public IActionResult displayGallery()
        {
            return View();
        }

        public IActionResult displayContactUsPage()
        {
            return View();
        }

    }
}
