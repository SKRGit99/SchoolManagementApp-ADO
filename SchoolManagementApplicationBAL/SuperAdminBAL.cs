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
    public class SuperAdminBAL
    {
        ISuperAdmin adminSup = new SuperAdminRepo();
        public List<StudentDetails> fetchStudentDetails(int _inputStudentId)
        {
            List<StudentDetails> detStudent = new List<StudentDetails>();
            detStudent = adminSup.fetchStudentDetails(_inputStudentId);
            return detStudent;
        }

        public List<StudentDetailsForDropDown> GetStudentDetailsForDropdown(int studentId)
        {
            List<StudentDetailsForDropDown> detStudentDrpDwn = new List<StudentDetailsForDropDown>();
            detStudentDrpDwn = adminSup.getStudentDetailsForDropDown(studentId);
            return detStudentDrpDwn;
        }

        public List<StudentDetails> GetStudentDetailsByRegistrationId(int selectedStudentRegId)
        {
            List<StudentDetails> detStudentbyRegId = new List<StudentDetails>();
            detStudentbyRegId = adminSup.getStudentDetailsByRegistrationId(selectedStudentRegId);
            return detStudentbyRegId;
        }

        public List<EducatorDetails> fetchEducatorDetails(int educatorid)
        {
            List<EducatorDetails> eduDetails = new List<EducatorDetails>();
            eduDetails = adminSup.fetchEducatorDetails(educatorid);
            return eduDetails;
        }

        public List<EducatorDetailsForDropDown> fetchEducatorDetailsForDropDown(int educatorid)
        {
            List<EducatorDetailsForDropDown> lstEduDetDrpDwn = new List<EducatorDetailsForDropDown>();
            lstEduDetDrpDwn = adminSup.getEducatorDetailsForDropDown(educatorid);
            return lstEduDetDrpDwn;
        }

        public List<EducatorDetails> fetchEducatorDetailsByRegistrationId(int educatorid)
        {
            List<EducatorDetails> eduDetRegId = new List<EducatorDetails>();
            eduDetRegId = adminSup.getEducatorDetailsByRegistrationId(educatorid);
            return eduDetRegId;
        }



    }
}
