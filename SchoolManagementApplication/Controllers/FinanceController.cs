using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementApplication.Controllers
{
    public class FinanceController : Controller
    {
        public IActionResult displayFinanceSection()
        {
            return View();
        }
    }
}
