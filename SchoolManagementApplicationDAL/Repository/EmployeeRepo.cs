using SchoolManagementApplicationDAL.Abstract;
using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Repository
{
    /*
     SuperAdminRepo : StudentRepo

     StudentRepo : DepartmentRepo

     EmployeeRepo : DepartmentRepo




     StudentDetails : DepartmentDetails

     EducatorDetails : EmployeeDetails

     EmployeeDetails : DepartmentDetails

     DepartmentDetails : OrganizationDetails

 */
    public class EmployeeRepo : DepartmentRepo,IEmployee
    {
        public EmployeeRepo() { }

        public override OrganizationDetails getOrganizationDetails()
        {
            OrganizationDetails lstOrg = new OrganizationDetails();

            return lstOrg;

        }

        public override void getOrganizationRelationshipDetails(int empId)
        {
            OrganizationDetails orgEmpDet = new OrganizationDetails();
            Console.WriteLine($"Relationship Id : {orgEmpDet.EmployeeRelationShipId} Relationship Category Id: {orgEmpDet.SchoolRelationShipCategoryId} Relationship Category Name : {orgEmpDet.SchoolRelationShipCategoryName} Relationship-Department Name :{orgEmpDet.SchoolDepartmentId} ");
        }

        public override void getOrganizationRelationshipDetails(int studentId, int? stuRollNum)
        {
            OrganizationDetails orgStuDet = new OrganizationDetails();
            Console.WriteLine($"Relationship Id : {orgStuDet.StudentRelationShipId} Relationship Category Id: {orgStuDet.SchoolRelationShipCategoryId} Relationship Category Name : {orgStuDet.SchoolRelationShipCategoryName} Relationship-Department Name :{orgStuDet.SchoolDepartmentId} ");
        }


        public override void getDepartmentDetails(int empId)
        {
            DepartmentDetails deptEmpDet = new DepartmentDetails();
            Console.WriteLine($"Department Id : {deptEmpDet.DepartmentId} Department Name :{deptEmpDet.DepartmentName}");
        }




        /*------------------------------- Department details methods ------------------------------------*/

        /*
         
          static void Main(string[] args)
            {       
                
                EmployeeDetails details = new EmployeeDetails(1, "Anupam","","Kumari", DateTime.Parse("1996-01-10"),"F",2,"Director", DateTime.Parse("2018-04-18"),"Admin",2,'Y',9,100000,"Graduate",10,"8123414499","Khagaria","Bihar","Khagaria","Bihar","India","852161","aupam@skrintlschool.com", 2, "PHY", "Physics", 20, "SKRPAT02", "SKR International School Patna", "SKRPATICSE", DateTime.Parse("2018-04-18"), "CBSE", "Education for All", "Education for India", "ICSE Affiliated School with AI Labs", "Vitthal VR Complex", "Saguna More Danapur", "Patna", "Bihar", "India", "800040", "info@skrschool.com", "www.skrschool.org", "8123414499");

                OrganizationDetails orgDet;        
                orgDet = new DepartmentDetails();  
                orgDet.displayOrganizationDetails();
                orgDet.displayAddress();

                orgDet = new EmployeeDetails();
                orgDet.displayOrganizationDetails();
                orgDet.displayAddress();


                orgDet = new OrganizationDetails();
                orgDet.displayOrganizationDetails();
                orgDet.displayAddress();

                Console.ReadKey();
            }
         
         
         
         
         
         
         
         */

    }
}
