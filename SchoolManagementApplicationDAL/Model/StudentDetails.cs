using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolManagementApplicationDAL.Model
{
    public class StudentDetails : DepartmentDetails
    {
        public StudentDetails() { }

        int _studentId;
        public int StudentId
        {
            get { return _studentId; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Student Id can not be less than 0.");
                _studentId = value;
            }
        }

        string _studentFirstName = string.Empty;
        public string StudentFirstName
        {
            get { return _studentFirstName; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Student Fisrt Name can not be null.");
                _studentFirstName = value;
            }
        }


        string _studentMiddleName = string.Empty;
        public string StudentMiddleName
        {
            get { return _studentMiddleName; }
            set
            {
                _studentMiddleName = value;
            }
        }

        string _studentLastName = string.Empty;
        public string StudentLastName
        {
            get { return _studentLastName; }
            set
            {
                _studentLastName = value;
            }
        }

        string _studentFullName = string.Empty;
        public string StudentFullName
        {
            get { return _studentFullName; }
            set
            {
                _studentFullName = value;
            }
        }

        char _isRegisteredStudent;
        internal char IsRegisteredStudent
        {
            get { return _isRegisteredStudent; }

            set
            {
                if ((value != 'Y') && (value != 'N'))
                    throw new ArgumentException("Invalid Value. Please Select Y/N.");
                _isRegisteredStudent = value;
            }
        }

        string _studentRegistrationId = string.Empty;
        protected string StudentRegistrationId
        {
            get { return _studentRegistrationId; }
            set { _studentRegistrationId= value; }
        }

        DateTime _studentRegistrationDate;
        protected DateTime StudentRegistrationDate
        {
            get { return (DateTime)_studentRegistrationDate; }
            set { _studentRegistrationDate = value; }
        }


        int _rollNumber;
        public int RollNumber
        {
            get { return _rollNumber; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Roll number can not be lessa than 0.");
                _rollNumber = value;
            }
        }


        int _studentClass;
        public int StudentClass
        {
            get { return _studentClass; }
            set
            {
                _studentClass = value;
            }
        }

        int _studentSectionId;
        public int StudentSectionId
        {
            get { return _studentSectionId; }
            set { _studentSectionId = value; }
        }

        char _studentSectionName;
        public char StudentSectionName
        {
            get { return _studentSectionName; }
            set { _studentSectionName = value; }
        }


        string _studentPhoneNumber=string.Empty;
        public string StudentPhoneNumber
        {
            get { return _studentPhoneNumber; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Student Phone number can not be less than 0");
                _studentPhoneNumber = value;

            }
        }


        string _studentAddressLine1 = string.Empty;
        protected string StudentAddressLine1
        {
            get { return _studentAddressLine1; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("AddressLine1 can not be null.");
                _studentAddressLine1 = value;
            }
        }

        string _studentAddressLine2 = string.Empty;
        protected string StudentAddressLine2
        {
            get { return _studentAddressLine2; }
            set { _studentAddressLine2 = value; }
        }

        string _studentFullAddress = string.Empty;
        public string StudentFullAddress
        {
            get { return _studentFullAddress; }
            set
            {
                _studentFullAddress = value;
            }
        }

        string _studentCity = string.Empty;
        public string StudentCity
        {
            get { return _studentCity; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("City can not be null.");
                _studentCity = value;
            }
        }

        string _studentState = string.Empty;
        public string StudentState
        {
            get { return _studentState; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("State can not be null.");
                _studentState = value;
            }
        }

        string _studentCountry = string.Empty;
        public string StudentCountry
        {
            get { return _studentCountry; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Country can not be null.");
                _studentCountry = value;
            }
        }

        string _studentZipCode = string.Empty;
        protected string StudentZipCode
        {
            get { return _studentZipCode; }
            set { _studentZipCode = value; }
        }

        string _studentEmailId = string.Empty;
        protected string StudentEmailId
        {
            get { return _studentEmailId; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Student EmailID can not be null");
                _studentEmailId = value;
            }
        }



        public override void getOrganizationDetails()
        {
            Console.WriteLine($"Organization details: School Code : {SchoolCode} School Name : {SchoolName} Registration Number : {RegistrationNumber} Establishment Year : {EstablishmentYear} Affiliation Board : {AffiliationBoard} Motto : {Motto} Vision : {Vision} Description : {Description} AddressLine1 : {AddressLine1} AddressLine2 : {AddressLine2} Full Address : {FullAddress} City : {City} State : {SchoolState} Country : {Country} ZipCode : {ZipCode} EmailId : {EmailId} Website URL : {WebsiteURL} Phone Number : {SchoolPhoneNumber}");
        }

       
        public override void getOrganizationRelationshipDetails(int studentId, string schoolCode)
        {
            Console.WriteLine($"Relationship Id : {StudentRelationShipId} Relationship Category Id: {SchoolRelationShipCategoryId} Relationship Category Name : {SchoolRelationShipCategoryName} Relationship-Department Name :{SchoolDepartmentId} ");
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
