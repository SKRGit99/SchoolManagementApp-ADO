using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Model
{
    public class DepartmentDetails : OrganizationDetails
    {
        int _departmentId;

        public int DepartmentId
        {
            get { return _departmentId; }
            set { _departmentId = value; }
        }

        string _departmentCode = string.Empty;
        protected string? DepartmentCode
        {
            get { return _departmentCode; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Department Code can not be null");
                _departmentCode = value;
            }
        }

        string _departmentName = string.Empty;
        public string? DepartmentName
        {
            get { return _departmentName; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Department Name can not be null");
                _departmentName = value;
            }
        }

        public DepartmentDetails()
        {
            this._departmentId = 1;
            this._departmentCode = "MAT";
            this._departmentName = "Mathematics";

        }
        public DepartmentDetails(int deptId, string deptCode, string deptName, string schCode, string schName, string schRegNum, DateTime estYear, string affBoard, string motto, string vision, string schDesc, string addLine1, string addLine2, string city, string state, string country, string zipCode, string emailID, string schURL, string schPhoneNum) : base( schCode, schName, schRegNum, estYear, affBoard, motto, vision, schDesc, addLine1, addLine2, city, state, country, zipCode, emailID, schURL, schPhoneNum)
        {
            this._departmentId = deptId;
            this._departmentCode = deptCode;
            this._departmentName = deptName;

        }

       
        
        public override void getOrganizationDetails()
        {
            Console.WriteLine($"Department Organization details: School Code : {SchoolCode} School Name : {SchoolName} Registration Number : {RegistrationNumber} Establishment Year : {EstablishmentYear} Affiliation Board : {AffiliationBoard} Motto : {Motto} Vision : {Vision} Description : {Description} AddressLine1 : {AddressLine1} AddressLine2 : {AddressLine2} Full Address : {FullAddress} City : {City} State : {SchoolState} Country : {Country} ZipCode : {ZipCode} EmailId : {EmailId} Website URL : {WebsiteURL} Phone Number : {SchoolPhoneNumber}");

        }

        public override void getOrganizationRelationshipDetails(string schoolCode, int empId)
        {
            Console.WriteLine($"Relationship Id : {EmployeeRelationShipId} Relationship Category Id: {SchoolRelationShipCategoryId} Relationship Category Name : {SchoolRelationShipCategoryName} ");
        }

        public override void getOrganizationRelationshipDetails(int studentId, string schoolCode)
        {
            Console.WriteLine($"Relationship Id : {StudentRelationShipId} Relationship Category Id: {SchoolRelationShipCategoryId} Relationship Category Name : {SchoolRelationShipCategoryName} ");
        }

        /*Methods to fetch Department Details*/

        public virtual void getDepartmentDetails(int deptId)
        {
            Console.WriteLine($"Department Id : {_departmentId} Department Code : {_departmentCode} Department Name :{_departmentName}");
        }
        public virtual void getDepartmentDetails(int deptId, string deptName)
        {
            Console.WriteLine($"Department Id : {_departmentId} Department Code : {_departmentCode} Department Name :{_departmentName}");
        }

        public virtual void getDepartmentDetails(string deptName, int deptId)
        {
            Console.WriteLine($"Department Id : {_departmentId} Department Code : {_departmentCode} Department Name :{_departmentName}");
        }

        public decimal getDepartmentWiseExpenses(int deptId) 
        {
            decimal _deptExpenses = 0;

            return _deptExpenses;
        }

        

    }
}
