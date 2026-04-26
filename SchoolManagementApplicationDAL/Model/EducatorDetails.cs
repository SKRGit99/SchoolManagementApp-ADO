using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Model
{
    public class EducatorDetails: EmployeeDetails
    {
        public EducatorDetails() { }

        int _educatorId;
        public int EducatorId
        {
            get { return _educatorId; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Educator Id can not be less than 0.");
                _educatorId = value;
            }
        }

        string _educatorFirstName = string.Empty;
        public string EducatorFirstName
        {
            get { return _educatorFirstName; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Educator Name can not be null");
                _educatorFirstName = value;


            }
        }

        string _educatorMiddleName = string.Empty;
        public string EducatorMiddleName
        {
            get { return _educatorMiddleName; }
            set
            {
                _educatorMiddleName = value;
            }


        }


        string _educatorLastName = string.Empty;
        public string EducatorLastName
        {
            get { return _educatorLastName; }
            set
            {
                _educatorLastName = value;

            }


        }

        string _educatorFullName = string.Empty;
        public string EducatorFullName
        {
            get { return _educatorFullName; }
            set
            {
                _educatorFullName = value;
            }
        }

        int _educatorDepartmentId;
        protected int EducatorDepartmentId
        {
            get { return _educatorDepartmentId; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Educator Department Id can ot be less than Zero");
                _educatorDepartmentId = value;


            }
        }

        string _educatorDepartmentName= string.Empty;
        public string EducatorDepartmentName
        {
            get { return _educatorDepartmentName; }
            set { _educatorDepartmentName = value; }
        }

        string _educatorClassesAssigned = string.Empty;
        public string EducatorClassesAssigned
        {
            get { return _educatorClassesAssigned; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Classes assigned to an educator can not be null");
                _educatorClassesAssigned = value;
            }
        }


        char _isEducatorOnPermanentPayroll;
        protected char IsEducatorOnPermanentPayroll
        {
            get { return _isEducatorOnPermanentPayroll; }
            set { _isEducatorOnPermanentPayroll = value; }
        }

        int _educatorPayScale;
        protected int EducatorPayScale
        {
            get { return _educatorPayScale; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("PayScale can not be less than 0.");
                _educatorPayScale = value;
            }
        }

        decimal _educatorBaseSalary;
        protected decimal EducatorBaseSalary
        {
            get { return (decimal)_educatorBaseSalary; }
            set { _educatorBaseSalary = value; }
        }

        string _educatorPhoneNumber = string.Empty;
        public string EducatorPhoneNumber
        {
            get { return _educatorPhoneNumber; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Educator phone number can not be null");
                _educatorPhoneNumber = value;

            }
        }


        string _educatorAddressLine1 = string.Empty;
        public string EducatorAddressLine1
        {
            get { return _educatorAddressLine1; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("AddressLine1 can not be null.");
                _educatorAddressLine1 = value;
            }
        }

        string _educatorAddressLine2 = string.Empty;
        public string EducatorAddressLine2
        {
            get { return _educatorAddressLine2; }
            set { _educatorAddressLine2 = value; }
        }

        string _educatorFullAddress = string.Empty;
        public string EducatorFullAddress
        {
            get { return _educatorFullAddress; }
            set
            {
                _educatorFullAddress = value;
            }
        }

        string _educatorCity = string.Empty;
        public string EducatorCity
        {
            get { return _educatorCity; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("City can not be null.");
                _educatorCity = value;
            }
        }

        string _educatorState = string.Empty;
        public string EducatorState
        {
            get { return _educatorState; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("State can not be null.");
                _educatorState = value;
            }
        }

        string _educatorCountry = string.Empty;
        public string EducatorCountry
        {
            get { return _educatorCountry; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Country can not be null.");
                _educatorCountry = value;
            }
        }

        string _educatorZipCode = string.Empty;
        protected string EducatorZipCode
        {
            get { return _educatorZipCode; }
            set { _educatorZipCode = value; }
        }

        string _educatorEmailId = string.Empty;
        protected string EducatorEmailId
        {
            get { return _educatorEmailId; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Educator EmailID can not be null");
                _educatorEmailId = value;
            }
        }


        public override List<OrganizationDetails> getOrganizationDetails()
        {
            List<OrganizationDetails> lstOrg = new List<OrganizationDetails>();
            return lstOrg;
            //Console.WriteLine($"Organization details: School Code : {_schoolCode} School Name : {_schoolName} Registration Number : {_registrationNumber} Establishment Year : {_establishmentYear} Affiliation Board : {_affiliationBoard} Motto : {_motto} Vision : {_vision} Description : {_description} AddressLine1 : {_addressLine1} AddressLine2 : {_addressLine2} Full Address : {_fullAddress} City : {_city} State : {_schoolState} Country : {_country} ZipCode : {_zipCode} EmailId : {_emailId} Website URL : {_websiteURL} Phone Number : {_schoolPhoneNumber}");

        }

        public override void getOrganizationRelationshipDetails(string schoolCode, int empId)
        {
            Console.WriteLine($"Educator Id : {EmployeeRelationShipId} Department Name : {DepartmentName} Relationship Category Id: {SchoolRelationShipCategoryId} Relationship Category Name : {SchoolRelationShipCategoryName}");
        }

       
        public override void getDepartmentDetails(int deptId)
        {
            Console.WriteLine($"Department Id : {DepartmentId} Department Code : {DepartmentCode} Department Name :{DepartmentName}");
        }
        public override void getDepartmentDetails(int deptId, string deptName)
        {
            Console.WriteLine($"Department Id : {DepartmentId} Department Code : {DepartmentCode} Department Name :{DepartmentName}");
        }

        public override void getDepartmentDetails(string deptName, int deptId)
        {
            Console.WriteLine($"Department Id : {DepartmentId} Department Code : {DepartmentCode} Department Name :{DepartmentName}");
        }


    }

}
