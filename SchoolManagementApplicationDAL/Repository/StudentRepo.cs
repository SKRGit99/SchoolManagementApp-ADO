using SchoolManagementApplicationDAL.Abstract;
using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Repository
{

    public class StudentRepo : IStudent
    {
        //SqlConnection conObj = new SqlConnection("Server=LAPTOP-K1PVP9J6\\;Database=SchoolManagementAppDevDb;Integrated Security=True;");

        private readonly string _connString = "Server=LAPTOP-K1PVP9J6\\;Database=SchoolManagementAppDevDb;Integrated Security=True;";

        public List<OrganizationDetails> getOrganizationDetails()
        {
            List<OrganizationDetails> orgDet = new List<OrganizationDetails>();


            return orgDet;


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


    }
}
