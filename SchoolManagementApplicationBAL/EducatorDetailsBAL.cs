using SchoolManagementApplicationDAL.Abstract;
using SchoolManagementApplicationDAL.Model;
using SchoolManagementApplicationDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationBAL
{
    /*
      SuperAdminRepo : StudentRepo

      StudentRepo : DepartmentRepo

      StudentDetails : DepartmentDetails

      EducatorDetails : EmployeeDetails

      EmployeeDetails : DepartmentDetails

      DepartmentRepo : DepartmentDetails

      DepartmentDetails : OrganizationRepo

      OrganizationRepo : OrganizationDetails

  */
    public class EducatorDetailsBAL
    {
        IEducator edudet = new EducatorRepo();
        
        public List<EducatorDetails> fetchEducatorDetailsByRegistrationId(int educatorid)
        {
            List<EducatorDetails> eduDetRegId = new List<EducatorDetails>();
            eduDetRegId = edudet.getEducatorDetailsByRegistrationId(educatorid);
            return eduDetRegId;
        }


    }
}
