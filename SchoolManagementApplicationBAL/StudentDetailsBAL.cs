using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementApplicationDAL.Abstract;
using SchoolManagementApplicationDAL.Model;
using SchoolManagementApplicationDAL.Repository;

namespace SchoolManagementApplicationBAL
{
    public class StudentDetailsBAL
    {
        IStudentDetails stdet = new StudentDetailsRepo();
        public List<StudentDetails> fetchStudentDetails(int _inputStudentId)
        {
            List<StudentDetails> detStudent = new List<StudentDetails>();
            detStudent = stdet.fetchStudentDetails(_inputStudentId);
            return detStudent;
        }

        public List<StudentDetailsForDropDown> GetStudentDetailsForDropdown(int studentId)
        {
            List<StudentDetailsForDropDown> detStudentDrpDwn = new List<StudentDetailsForDropDown>();
            detStudentDrpDwn = stdet.getStudentDetailsForDropDown(studentId);
            return detStudentDrpDwn;
        }

        public List<StudentDetails> GetStudentDetailsByRegistrationId(int selectedStudentRegId)
        {
            List<StudentDetails> detStudentbyRegId = new List<StudentDetails>();
            detStudentbyRegId = stdet.getStudentDetailsByRegistrationId(selectedStudentRegId);
            return detStudentbyRegId;
        }

        //public List<StudentDetailsADO> fetchStdDetails()
        //{
        //    List<StudentDetailsADO> lstt = new List<StudentDetailsADO> ();
        //    foreach (StudentDetailsADO student in stdet.getAllStudentDetails())
        //    {
        //        lstt.Add(student);
        //    }

        //    return lstt;
        //}

        //public List<StudentDetails> fetchIndvStdDetails(int inputStdId)
        //{
        //    List<StudentDetails> lsttt = new List<StudentDetails>();
        //    foreach (StudentDetails student in stdet.getStudentDetailsForDropDown(inputStdId))
        //    {
        //        lsttt.Add(student);
        //    }

        //    return lsttt;
        //}





    }
}
