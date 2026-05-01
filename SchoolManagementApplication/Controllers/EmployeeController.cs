using Microsoft.AspNetCore.Mvc;
using SchoolManagementApplicationBAL;
using SchoolManagementApplicationDAL.Model;

namespace SchoolManagementApplication.Controllers
{
    public class EmployeeController : Controller
    {
        public JsonResult GetIndividualEmployeeDetailsByEmployeeId(string value)
        {
            EmployeeDetailsBAL eduDetailsDrpDwnBAL = new EmployeeDetailsBAL();
            List<EmployeeDetailsBAL> educatDetails = new List<EmployeeDetailsBAL>();

            //educatDetails = eduDetailsDrpDwnBAL.fetchEducatorDetailsByRegistrationId(Convert.ToInt32(value));

            return Json(educatDetails);
        }
    }
}
