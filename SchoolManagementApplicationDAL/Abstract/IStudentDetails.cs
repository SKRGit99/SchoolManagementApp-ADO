using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Abstract
{
    public interface IStudentDetails
    {
        public List<StudentDetails> fetchStudentDetails(int _inputStudentId);

        public List<StudentDetailsForDropDown> getStudentDetailsForDropDown(int studentId);
        
        public List<StudentDetails> getStudentDetailsByRegistrationId(int registrationId);

        
    }

   
}
