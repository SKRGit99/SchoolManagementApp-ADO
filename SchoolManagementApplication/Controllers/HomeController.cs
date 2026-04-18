using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SchoolManagementApplicationBAL;
using SchoolManagementApplicationDAL.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolManagementApplication.Controllers
{
    public class HomeController : StudentBaseController<StudentDetails>
    {
        public IActionResult Index()
        {
            return View();
            
        }

    }
}
