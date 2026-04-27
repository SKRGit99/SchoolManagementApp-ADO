using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Abstract
{
    public interface IStudent
    {
        /* IStudent : contains only those methods which an Student can access.
         
         
         */
        List<OrganizationDetails> getOrganizationDetails();
        List<StudentDetails> getStudentDetailsByRegistrationId(int registrationId);


    }

   
}
