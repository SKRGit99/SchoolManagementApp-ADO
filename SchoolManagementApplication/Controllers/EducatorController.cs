using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SchoolManagementApplicationBAL;
using SchoolManagementApplicationDAL.Abstract;
using SchoolManagementApplicationDAL.Model;

namespace SchoolManagementApplication.Controllers
{
    public class EducatorController : EducatorBaseController<EducatorDetails>
    {
        [HttpGet]
        public IActionResult GetIndividualEducatorDetailsByRegistrationId()
        {
            int educatorid = 0;
            EducatorDetailsBAL eduDetailsBAL = new EducatorDetailsBAL();

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
            EducatorDetailsBAL eduDetailsDrpDwnBAL = new EducatorDetailsBAL();
            List<EducatorDetails> educatDetails = new List<EducatorDetails>();

            educatDetails = eduDetailsDrpDwnBAL.fetchEducatorDetailsByRegistrationId(Convert.ToInt32(value));

            return Json(educatDetails);
        }
        public IActionResult GetEducatorDetails(int page = 1)
        {
            int educatorId = 0;
            EducatorDetailsBAL educatorDetailsBusiness = new EducatorDetailsBAL();

            var educatorDetails = educatorDetailsBusiness.fetchEducatorDetails(educatorId);

            ViewBag.TotalRecords = educatorDetails.Count;
            ViewBag.CurrentPage = page;

            var paginatedResult = PaginatedResult(educatorDetails, page, 10);
            return View(paginatedResult);

        }





    }
}
