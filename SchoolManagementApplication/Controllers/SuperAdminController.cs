using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagementApplicationBAL;
using SchoolManagementApplicationDAL.Abstract;
using SchoolManagementApplicationDAL.Model;

namespace SchoolManagementApplication.Controllers
{
    public class SuperAdminController : Controller
    {

        private readonly SuperAdminBaseController<StudentDetails> _studentBase
        = new SuperAdminBaseController<StudentDetails>();
        private readonly SuperAdminBaseController<EducatorDetails> _educatorBase
            = new SuperAdminBaseController<EducatorDetails>();

        [HttpGet]
        public IActionResult GetIndividualStudentDetailsByRegistrationId()
        {
            int inputStudentId = 0;
            SuperAdminBAL studentDetailsBusiness = new SuperAdminBAL();

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
            SuperAdminBAL studentDetailsBusiness = new SuperAdminBAL();
            List<StudentDetails> studentDetails = new List<StudentDetails>();


            studentDetails = studentDetailsBusiness.GetStudentDetailsByRegistrationId(Convert.ToInt32(value));

            return Json(studentDetails);
        }


        public IActionResult GetStudentDetails(int page = 1)
        {
            int _inputStudentId = 0;

            SuperAdminBAL studentDetailsBusiness = new SuperAdminBAL();

            var stuDet = studentDetailsBusiness.fetchStudentDetails(_inputStudentId);

            var viewModel = stuDet.Select(S => new StudentDetails
            {
                SchoolName = S.SchoolName,
                StudentName = S.StudentName,
                RollNumber = S.RollNumber,
                StudentClass = S.StudentClass,
                StudentSectionId = S.StudentSectionId,
                StudentSectionName = S.StudentSectionName,
                StudentAddress = S.StudentAddress,
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

            //var paginatedResult = PaginatedResult(viewModel, page, 10);
            var paginatedResult = _studentBase.PaginatedResult(viewModel, page, 10);
            return View(paginatedResult);
        }


        [HttpGet]
        public IActionResult GetIndividualEducatorDetailsByRegistrationId()
        {
            int educatorid = 0;
            SuperAdminBAL eduDetailsBAL = new SuperAdminBAL();

            /*This code is for grtting dropdown details*/
            List<EducatorDetailsForDropDown> educatorDetDrpDwn = new List<EducatorDetailsForDropDown>();
            educatorDetDrpDwn = eduDetailsBAL.fetchEducatorDetailsForDropDown(educatorid);
            ViewBag.EducatorList = new SelectList(educatorDetDrpDwn, "EducatorIdForDrpDwn", "EducatorFullNameForDrpDwn");
            /*code for grtting dropdown details ends*/

            return View();
        }

        [HttpPost]
        public JsonResult GetIndividualEducatorDetailsByRegistrationId(string value)
        {
            SuperAdminBAL eduDetailsDrpDwnBAL = new SuperAdminBAL();
            List<EducatorDetails> educatDetails = new List<EducatorDetails>();

            educatDetails = eduDetailsDrpDwnBAL.fetchEducatorDetailsByRegistrationId(Convert.ToInt32(value));

            return Json(educatDetails);
        }

        public IActionResult GetEducatorDetails(int page = 1)
        {
            int educatorId = 0;
            SuperAdminBAL educatorDetailsBusiness = new SuperAdminBAL();

            var educatorDetails = educatorDetailsBusiness.fetchEducatorDetails(educatorId);

            var viewModel = educatorDetails.Select(S => new EducatorDetails
            {
                EducatorId = S.EducatorId,
                EducatorName = S.EducatorName,
                EducatorDepartmentName = S.EducatorDepartmentName,
                EducatorClassesAssigned = S.EducatorClassesAssigned,
                EducatorAddress = S.EducatorAddress,
                EducatorCity = S.EducatorCity,
                EducatorState = S.EducatorState,
                EducatorCountry = S.EducatorCountry,
                EducatorPhoneNumber = S.EducatorPhoneNumber,
                EmailId = S.EmailId


            }).ToList();

            ViewBag.TotalRecords = educatorDetails.Count;
            ViewBag.CurrentPage = page;

            //var paginatedResult = PaginatedResult(educatorDetails, page, 10);
            var paginatedResult = _educatorBase.PaginatedResult(viewModel, page, 10);
            return View(paginatedResult);

        }



    }
}
