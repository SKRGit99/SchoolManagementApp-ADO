using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Abstract
{
    public interface IEducator
    {
        /*  IEducator : contains only those methods which an Educator can access.
         
            Educator can access details of all the student.
            Educator can access all the Individual student details as well.

         */

        List<OrganizationDetails> getOrganizationDetails();
        List<EducatorDetails> getEducatorDetailsByRegistrationId(int educatorId);

        List<StudentDetails> fetchStudentDetails(int studentId);
        List<StudentDetailsForDropDown> getStudentDetailsForDropDown(int studentId);
        


    }
}
