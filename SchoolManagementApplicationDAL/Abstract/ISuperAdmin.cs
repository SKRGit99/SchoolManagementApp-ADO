using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Abstract
{
    public interface ISuperAdmin
    {
        /*  ISuperAdmin : can access all the Data.
         
         
         */
        OrganizationDetails getOrganizationDetails();
        void getOrganizationRelationshipDetails(int empId);
        void getOrganizationRelationshipDetails(int studentId, int? stuRollNum);
        void getDepartmentDetails(int empId);
        void getDepartmentDetails(int studentId, int? stuRollNum);
        decimal getDepartmentWiseExpenditureDetails(int deptId);
        List<EmployeeDetails> getEmployeeDetails();
        List<EducatorDetails> fetchEducatorDetails(int educatorid);
        List<EducatorDetailsForDropDown> getEducatorDetailsForDropDown(int educatorId);
        List<EducatorDetails> getEducatorDetailsByRegistrationId(int educatorId);
        List<EmployeeDetails> getEmployeeSalaryDetails();
        decimal getIndividualEmployeeSalaryDetails(int empId);
        List<StudentDetails> fetchStudentDetails(int studentId);
        List<StudentDetailsForDropDown> getStudentDetailsForDropDown(int studentId);
        List<StudentDetails> getStudentDetailsByRegistrationId(int registrationId);


    }
}
