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
    public class EducatorDetailsRepo: IEducatorDetails
    {
        //SqlConnection conObj = new SqlConnection("Server=LAPTOP-K1PVP9J6\\;Database=SchoolManagementAppDevDb;Integrated Security=True;");

        private readonly string _connString = "Server=LAPTOP-K1PVP9J6\\;Database=SchoolManagementAppDevDb;Integrated Security=True;";
        public List<EducatorDetails> fetchEducatorDetails(int educatorid)
        {
            List<EducatorDetails> lstEduDetails = new List<EducatorDetails>();

            using (var con = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("fetchEducatorDetails", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@educatorid", SqlDbType.Int) { Value = educatorid });

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
                    eduDet.EducatorFullName = dr["EducatorFullName"].ToString();

                    eduDet.EducatorDepartmentName = dr["DepartmentName"].ToString();
                    eduDet.EducatorClassesAssigned = dr["ClassesAssigned"].ToString();
                    eduDet.EducatorPhoneNumber = dr["EducatorPhoneNumber"].ToString();
                    eduDet.EducatorAddressLine1 = dr["EducatorAddressLine1"].ToString();
                    eduDet.EducatorAddressLine2 = dr["EducatorAddressLine2"].ToString();
                    eduDet.EducatorFullAddress = dr["EducatorFullAddress"].ToString();
                    eduDet.EducatorCity = dr["City"].ToString();
                    eduDet.EducatorState = dr["HomeState"].ToString();
                    eduDet.EducatorCountry = dr["Country"].ToString();
                    eduDet.ZipCode = dr["ZipCode"].ToString();
                    eduDet.EmailId = dr["EmailId"].ToString();



                    lstEduDetails.Add(eduDet);


                }

                return lstEduDetails;


            }
        }

        public List<EducatorDetailsForDropDown> getEducatorDetailsForDropDown(int educatorId)
        {
            List<EducatorDetailsForDropDown> lstEduDrpDwn = new List<EducatorDetailsForDropDown>();

            using (var con = new SqlConnection(_connString))
            using (var cmd = new SqlCommand("fetchEducatorDetails", con))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@educatorId", SqlDbType.Int) { Value = educatorId });

                var da = new SqlDataAdapter(cmd);

                var ds = new DataSet();

                da.Fill(ds);

                DataTable dt = new DataTable();

                dt = ds.Tables[1];

                foreach (DataRow dr in dt.Rows)
                {
                    EducatorDetailsForDropDown educatorDetailsByDropDown = new EducatorDetailsForDropDown();
                    educatorDetailsByDropDown.EducatorIdForDrpDwn = Convert.ToInt32(dr["EducatorId"]);
                    educatorDetailsByDropDown.EducatorFullNameForDrpDwn = dr["EducatorFullName"].ToString();


                    lstEduDrpDwn.Add(educatorDetailsByDropDown);
                }
                return lstEduDrpDwn;
            }
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
                    eduDet.EducatorFullName = dr["EducatorFullName"].ToString();

                    eduDet.EducatorDepartmentName = dr["DepartmentName"].ToString();
                    eduDet.EducatorClassesAssigned = dr["ClassesAssigned"].ToString();
                    eduDet.EducatorPhoneNumber = dr["EducatorPhoneNumber"].ToString();
                    eduDet.EducatorAddressLine1 = dr["EducatorAddressLine1"].ToString();
                    eduDet.EducatorAddressLine2 = dr["EducatorAddressLine2"].ToString();
                    eduDet.EducatorFullAddress = dr["EducatorFullAddress"].ToString();
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


    }
}
