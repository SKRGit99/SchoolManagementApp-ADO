using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagementApplicationBAL;
using SchoolManagementApplicationDAL.Model;

namespace SchoolManagementApplication.Controllers
{
    public class StudentController : Controller
    {

        //[HttpGet]
        //public IActionResult GetIndividualStudentDetailsByRegistrationId()
        //{
        //    int inputStudentId = 0;
        //    StudentDetailsBAL studentDetailsBusiness = new StudentDetailsBAL();

        //    /*This code is for getting dropdown details*/
        //    List<StudentDetailsForDropDown> studentDetailsForDrpDwn = new List<StudentDetailsForDropDown>();
        //    studentDetailsForDrpDwn = studentDetailsBusiness.GetStudentDetailsForDropdown(inputStudentId);

        //     ViewBag.studentList = new SelectList(studentDetailsForDrpDwn, "StudentIdForDrpDwn", "StudentFullNameForDrpDwn");
        //    /*code for getting dropdown details ends*/

        //    return View();
        //}
        
        
        //[HttpPost]
        public JsonResult GetIndividualStudentDetailsByRegistrationId(string value)
        {
            StudentDetailsBAL studentDetailsBusiness = new StudentDetailsBAL();
            List<StudentDetails> studentDetails = new List<StudentDetails>();


            studentDetails = studentDetailsBusiness.GetStudentDetailsByRegistrationId(Convert.ToInt32(value));

            return Json(studentDetails);
        }


        
        

        

    }
}
