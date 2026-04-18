using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementApplicationDAL.Abstract;

namespace SchoolManagementApplicationDAL.Repository
{

    public class StudentDetailsRepo : IStudentDetails
    {
        //SqlConnection conObj = new SqlConnection("Server=LAPTOP-K1PVP9J6\\;Database=SchoolManagementAppDevDb;Integrated Security=True;");

        private readonly string _connString = "Server=LAPTOP-K1PVP9J6\\;Database=SchoolManagementAppDevDb;Integrated Security=True;";
        public List<StudentDetails> fetchStudentDetails(int studentId)
        {
            List<StudentDetails> lstStdDetails = new List<StudentDetails>();

            /*

                        SqlCommand cmd = new SqlCommand("fetchStudentDetails", conObj);

                        cmd.CommandType = CommandType.StoredProcedure;

                        SqlParameter param1 = new SqlParameter
                        {
                        ParameterName = "@studentId", 
                        SqlDbType = SqlDbType.Int, 
                        Value = studentId, 
                        Direction = ParameterDirection.Input 
                        };

                        cmd.Parameters.Add(param1);

                        conObj.Open();

                        cmd.ExecuteNonQuery();

                        SqlDataAdapter da = new SqlDataAdapter(cmd);

                        DataTable dt = new DataTable();

            */
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
                    studentDet.SchoolRelationShipId = Convert.ToInt32(dr["RelationshipId"]);
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


                    lstStdDetails.Add(studentDet);


                }
            }



            return lstStdDetails;


        }

        public List<StudentDetailsForDropDown> getStudentDetailsForDropDown(int studentId)
        {
            /*
                List<StudentDetails> lstStdDrpDwn = new List<StudentDetails>();
                SqlCommand cmd = new SqlCommand("getStudentDetails", conObj);

                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);
             
             
             
             
             */

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

                //SqlCommand cmd = new SqlCommand("getStudentDetailsByRegId", conObj);
                //cmd.CommandType = CommandType.StoredProcedure;

                //SqlParameter param1 = new SqlParameter
                //{
                //    ParameterName = "@registrationId", //Parameter name defined in stored procedure
                //    SqlDbType = SqlDbType.Int, //Data Type of Parameter
                //    Value = registrationId, //Value passes to the paramete
                //    Direction = ParameterDirection.Input //Specify the parameter as input
                //};
                ////Add the parameter to the Parameters property of SqlCommand object
                //cmd.Parameters.Add(param1);
                //conObj.Open();

                //cmd.ExecuteNonQuery();
                //SqlDataAdapter da = new SqlDataAdapter(cmd);

                //DataTable dt = new DataTable();

                //da.Fill(dt);

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
                        studentDetByRegId.StudentFullName = dr["StudentName"].ToString();
                        studentDetByRegId.RollNumber = Convert.ToInt32(dr["RollNumber"]);
                        studentDetByRegId.StudentClass = Convert.ToInt32(dr["ClassId"]);
                        studentDetByRegId.StudentSectionName = Convert.ToChar(dr["SectionName"]);
                        studentDetByRegId.StudentFullAddress = dr["StudentAddress"].ToString();
                        studentDetByRegId.StudentPhoneNumber = dr["StudentPhoneNumber"].ToString();
                        lstStdDetailsbyRegId.Add(studentDetByRegId);


                    }

                    return lstStdDetailsbyRegId;
                }

            }

    }
}
