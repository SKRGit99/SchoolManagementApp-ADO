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
        List<OrganizationDetails> getOrganizationDetails();
        List<DepartmentDetails> getDepartmentDetails(int deptId);
        decimal getDepartmentWiseExpenditureDetails(int deptId);
        List<EmployeeDetails> getEmployeeDetails();
        List<EducatorDetails> fetchEducatorDetails(int educatorid);
        List<EducatorDetailsForDropDown> getEducatorDetailsForDropDown(int educatorId);
        List<EducatorDetails> getEducatorDetailsByRegistrationId(int educatorId);
        public decimal getEmployeeSalaryDetails();
        decimal getIndividualEmployeeSalaryDetails(int empId);

        public List<StudentDetails> fetchStudentDetails(int studentId);
        public List<StudentDetailsForDropDown> getStudentDetailsForDropDown(int studentId);
        public List<StudentDetails> getStudentDetailsByRegistrationId(int registrationId);


    }
}
