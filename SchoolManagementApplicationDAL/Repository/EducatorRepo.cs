using SchoolManagementApplicationDAL.Abstract;
using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Repository
{
    public class EducatorRepo: IEducator,IStudent
    {
        private readonly string _connString = "Server=LAPTOP-K1PVP9J6\\;Database=SchoolManagementAppDevDb;Integrated Security=True;";

        public List<OrganizationDetails> getOrganizationDetails()
        {
            List<OrganizationDetails> orgDet = new List<OrganizationDetails>();


            return orgDet;


        }
        public List<EducatorDetails> getEducatorDetailsByRegistrationId(int educatorId)
        {
            List<EducatorDetails> lstEduDetailsbyRegId = new List<EducatorDetails>();

            using (var con = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("fetchEducatorDetails", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@educatorId", SqlDbType.Int) { Value = educatorId });

                var da = new SqlDataAdapter(cmd);

                var ds = new DataSet();

                da.Fill(ds);

                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    EducatorDetails eduDet = new EducatorDetails();
                    eduDet.EducatorId = Convert.ToInt32(dr["EducatorId"]);
                    eduDet.EducatorFirstName = dr["EducatorFirstName"].ToString();
                    eduDet.EducatorMiddleName = dr["EducatorMiddleName"].ToString();
                    eduDet.EducatorLastName = dr["EducatorLastName"].ToString();
                    eduDet.EducatorName = dr["EducatorFullName"].ToString();

                    eduDet.EducatorDepartmentName = dr["DepartmentName"].ToString();
                    eduDet.EducatorClassesAssigned = dr["ClassesAssigned"].ToString();
                    eduDet.EducatorPhoneNumber = dr["EducatorPhoneNumber"].ToString();
                    eduDet.EducatorAddressLine1 = dr["EducatorAddressLine1"].ToString();
                    eduDet.EducatorAddressLine2 = dr["EducatorAddressLine2"].ToString();
                    eduDet.EducatorAddress = dr["EducatorFullAddress"].ToString();
                    eduDet.EducatorCity = dr["City"].ToString();
                    eduDet.EducatorState = dr["HomeState"].ToString();
                    eduDet.EducatorCountry = dr["Country"].ToString();
                    eduDet.ZipCode = dr["ZipCode"].ToString();
                    eduDet.EmailId = dr["EmailId"].ToString();

                    lstEduDetailsbyRegId.Add(eduDet);


                }

                return lstEduDetailsbyRegId;
            }
        }


        

        /*--------------------------------------------- Student Data ----------------------------------------------*/
        public List<StudentDetails> fetchStudentDetails(int studentId)
        {
            List<StudentDetails> stuDet = new List<StudentDetails>();

            using (var con = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("fetchStudentDetails", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@studentId", SqlDbType.Int) { Value = studentId });

                var da = new SqlDataAdapter(cmd);
                var ds = new DataSet();

                da.Fill(ds);

                DataTable dt = new DataTable();
                dt = ds.Tables[0];

                foreach (DataRow dr in dt.Rows)
                {
                    StudentDetails studentDet = new StudentDetails();

                    studentDet.SchoolRelationShipCategoryId = Convert.ToInt32(dr["RelationshipCategoryId"]);
                    studentDet.SchoolRelationShipCategoryName = dr["RelationshipCategoryName"].ToString();
                    studentDet.StudentRelationShipId = Convert.ToInt32(dr["RelationshipId"]);
                    studentDet.SchoolName = dr["SchoolName"].ToString();

                    studentDet.StudentFirstName = dr["StudentFirstName"].ToString();
                    studentDet.StudentMiddleName = dr["StudentMiddleName"].ToString();
                    studentDet.StudentLastName = dr["StudentLastName"].ToString();

                    studentDet.IsRegisteredStudent = Convert.ToChar(dr["IsRegisteredStudent"]);


                    studentDet.RollNumber = Convert.ToInt32(dr["RollNumber"]);
                    studentDet.StudentClass = Convert.ToInt32(dr["ClassId"]);
                    studentDet.StudentSectionId = Convert.ToInt32(dr["SectionId"]);
                    studentDet.StudentSectionName = Convert.ToChar(dr["SectionName"]);

                    studentDet.StudentCity = dr["City"].ToString();
                    studentDet.StudentState = dr["HomeState"].ToString();
                    studentDet.StudentCountry = dr["Country"].ToString();

                    stuDet.Add(studentDet);
                }
            }

            return stuDet;


        }


        public List<StudentDetailsForDropDown> getStudentDetailsForDropDown(int studentId)
        {
            List<StudentDetailsForDropDown> lstStdDrpDwn = new List<StudentDetailsForDropDown>();
            using (var con = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("fetchStudentDetails", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@studentId", SqlDbType.Int) { Value = studentId });

                var da = new SqlDataAdapter(cmd);

                var ds = new DataSet();

                da.Fill(ds);

                DataTable dt = new DataTable();
                dt = ds.Tables[1];

                foreach (DataRow dr in dt.Rows)
                {
                    StudentDetailsForDropDown studentDetailsByDropDown = new StudentDetailsForDropDown();
                    studentDetailsByDropDown.StudentIdForDrpDwn = Convert.ToInt32(dr["RelationshipId"]);
                    studentDetailsByDropDown.StudentFullNameForDrpDwn = dr["StudentName"].ToString();


                    lstStdDrpDwn.Add(studentDetailsByDropDown);
                }
                return lstStdDrpDwn;
            }
        }

        public List<StudentDetails> getStudentDetailsByRegistrationId(int registrationId)
        {
            List<StudentDetails> lstStdDetailsbyRegId = new List<StudentDetails>();

            using (var con = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("fetchStudentDetails", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@studentId", SqlDbType.Int) { Value = registrationId });

                var da = new SqlDataAdapter(cmd);

                var ds = new DataSet();

                da.Fill(ds);

                DataTable dt = new DataTable();
                dt = ds.Tables[0];


                foreach (DataRow dr in dt.Rows)
                {
                    StudentDetails studentDetByRegId = new StudentDetails();
                    studentDetByRegId.StudentId = Convert.ToInt32(dr["RelationshipId"]);
                    studentDetByRegId.StudentName = dr["StudentName"].ToString();
                    studentDetByRegId.RollNumber = Convert.ToInt32(dr["RollNumber"]);
                    studentDetByRegId.StudentClass = Convert.ToInt32(dr["ClassId"]);
                    studentDetByRegId.StudentSectionName = Convert.ToChar(dr["SectionName"]);
                    studentDetByRegId.StudentAddress = dr["StudentAddress"].ToString();
                    studentDetByRegId.StudentPhoneNumber = dr["StudentPhoneNumber"].ToString();
                    lstStdDetailsbyRegId.Add(studentDetByRegId);


                }

                return lstStdDetailsbyRegId;
            }
        }

        /*--------------------------------------------- Student Data ---------------------------------------------*/



    }
}
