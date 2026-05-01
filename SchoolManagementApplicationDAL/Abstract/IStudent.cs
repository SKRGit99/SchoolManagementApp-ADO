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
        OrganizationDetails getOrganizationDetails();
        void getOrganizationRelationshipDetails(int studentId, int? stuRollNum);
        void getDepartmentDetails(int studentId, int? stuRollNum);
        List<StudentDetails> getStudentDetailsByRegistrationId(int registrationId);


    }

   
}
