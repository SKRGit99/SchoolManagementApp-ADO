using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagementApplicationBAL;
using SchoolManagementApplicationDAL.Model;

namespace SchoolManagementApplication.Controllers
{
    public class StudentController : StudentBaseController<StudentDetails>
    {

        [HttpGet]
        public IActionResult GetIndividualStudentDetailsByRegistrationId()
        {
            int inputStudentId = 0;
            StudentDetailsBAL studentDetailsBusiness = new StudentDetailsBAL();

            /*This code is for getting dropdown details*/
            List<StudentDetailsForDropDown> studentDetailsForDrpDwn = new List<StudentDetailsForDropDown>();
            studentDetailsForDrpDwn = studentDetailsBusiness.GetStudentDetailsForDropdown(inputStudentId);

             ViewBag.studentList = new SelectList(studentDetailsForDrpDwn, "StudentIdForDrpDwn", "StudentFullNameForDrpDwn");
            /*code for getting dropdown details ends*/

            return View();
        }
        
        
        [HttpPost]
        public JsonResult GetIndividualStudentDetailsByRegistrationId(string value)
        {
            StudentDetailsBAL studentDetailsBusiness = new StudentDetailsBAL();
            List<StudentDetails> studentDetails = new List<StudentDetails>();


            studentDetails = studentDetailsBusiness.GetStudentDetailsByRegistrationId(Convert.ToInt32(value));

            return Json(studentDetails);
        }


        
        public IActionResult GetStudentDetails(int page = 1)
        {
            int _inputStudentId = 0;

            StudentDetailsBAL studentDetailsBusiness = new StudentDetailsBAL();

            var stuDet = studentDetailsBusiness.fetchStudentDetails(_inputStudentId);

            var viewModel = stuDet.Select(S => new StudentDetails
            {
                SchoolName = S.SchoolName,
                StudentFirstName = S.StudentFirstName,
                StudentMiddleName = S.StudentMiddleName,
                StudentLastName = S.StudentLastName,
                RollNumber = S.RollNumber,
                StudentClass = S.StudentClass,
                StudentSectionId = S.StudentSectionId,
                StudentSectionName = S.StudentSectionName,

                StudentCity = S.StudentCity,
                StudentState = S.StudentState,
                StudentCountry = S.StudentCountry


            }).ToList();

            //ViewBag.TotalRecords = stuDet.Count;
            //ViewBag.CurrentPage = page;

            //var paginatedResult = PaginatedResult(studentDetails, page, 10);
            //return View(paginatedResult);

            ViewBag.TotalRecords = viewModel.Count;
            ViewBag.CurrentPage = page;

            var paginatedResult = PaginatedResult(viewModel, page, 10);
            return View(paginatedResult);
        }



    }
}
