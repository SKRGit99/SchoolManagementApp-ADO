using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Model
{
    public class EmployeeDetails : DepartmentDetails
    {
        int _employeeId;
        public int EmployeeId
        {
            get { return _employeeId; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("EmployeeId Id can not be less than 0.");
                _employeeId = value;
            }
        }

        string _employeeFirstName = string.Empty;
        public string EmployeeFirstName
        {
            get { return _employeeFirstName; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Employee First Name can not be null");
                _employeeFirstName = value;


            }
        }

        string? _employeeMiddleName;
        public string EmployeeMiddleName
        {
            get { return _employeeMiddleName ?? string.Empty; }
            set
            {
                _employeeMiddleName = value;
            }


        }


        string? _employeeLastName;
        public string EmployeeLastName
        {
            get { return _employeeLastName ?? string.Empty; }
            set
            {
                _employeeLastName = value;

            }


        }

        string _employeeFullName = string.Empty;
        public string EmployeeFullName
        {
            get { return _employeeFullName; }
            set
            {
                _employeeFullName = value;
            }
        }

        DateTime _employeeDateOfBirth;
        public DateTime EmployeeDateOfBirth
        {
            get { return (DateTime)_employeeDateOfBirth; }
            set { _employeeDateOfBirth = value; }
        }

        String _employeeGender = string.Empty;
        public String EmployeeGender
        {
            get { return _employeeGender; }
            set { _employeeGender = value; }
        }

        int _employeeDepartmentId;
        protected int EmployeeDepartmentId
        {
            get { return _employeeDepartmentId; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Educator Department Id can ot be less than Zero");
                _employeeDepartmentId = value;


            }
        }


        string _employeeDesignation = string.Empty;
        public string EmployeeDesignation
        {
            get { return _employeeDesignation ?? string.Empty; }
            set { _employeeDesignation = value; }
        }


        DateTime _dateOfJoining;
        public DateTime DateOfJoining
        {
            get { return _dateOfJoining; }
            set { _dateOfJoining = value; }
        }

        int _employeeManagerId;
        public int EmployeeManagerId
        {
            get { return _employeeManagerId; }
            set { _employeeManagerId = value; }
        }


        char _isEmployeeOnPermanentPayroll;
        public char IsEmployeeOnPermanentPayroll
        {
            get { return _isEmployeeOnPermanentPayroll; }
            set { _isEmployeeOnPermanentPayroll = value; }
        }

        int _employeePayScale;
        public int EmployeePayScale
        {
            get { return _employeePayScale; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("PayScale can not be less than 0.");
                _employeePayScale = value;
            }
        }

        decimal _employeeBaseSalary;
        protected decimal EmployeeBaseSalary
        {
            get { return (decimal)_employeeBaseSalary; }
            set { _employeeBaseSalary = value; }
        }

        string _employeeQualifications = string.Empty;
        protected string EmployeeQualifications
        {
            get { return _employeeQualifications; }
            set { _employeeQualifications = value; }
        }

        int _experienceOfWork;
        public int ExperienceOfWork
        {
            get { return _experienceOfWork; }
            set { _experienceOfWork = value; }
        }

        string? _employeePhoneNumber;
        public string EmployeePhoneNumber
        {
            get { return _employeePhoneNumber ?? string.Empty; }
            set
            {
                _employeePhoneNumber = value;

            }
        }


        string _employeeAddressLine1 = string.Empty;
        protected string EmployeeAddressLine1
        {
            get { return _employeeAddressLine1; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("AddressLine1 can not be null.");
                _employeeAddressLine1 = value;
            }
        }

        string? _employeeAddressLine2;
        protected string EmployeeAddressLine2
        {
            get { return _employeeAddressLine2 ?? string.Empty; }
            set { _employeeAddressLine2 = value; }
        }

        string _employeeFullAddress = string.Empty;
        public string EmployeeFullAddress
        {
            get { return _employeeFullAddress; }
            set
            {
                _employeeFullAddress = value;
            }
        }

        string _employeeCity = string.Empty;
        public string EmployeeCity
        {
            get { return _employeeCity; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("City can not be null.");
                _employeeCity = value;
            }
        }

        string? _employeeState;
        public string EmployeeState
        {
            get { return _employeeState ?? string.Empty; }
            set
            {
                _employeeState = value;
            }
        }

        string? _employeeCountry;
        public string EmployeeCountry
        {
            get { return _employeeCountry ?? string.Empty; }
            set
            {
                _employeeCountry = value;
            }
        }

        string _employeeZipCode = string.Empty;
        protected string EmployeeZipCode
        {
            get { return _employeeZipCode; }
            set { _employeeZipCode = value; }
        }

        string _employeeEmailId = string.Empty;
        public string EmployeeEmailId
        {
            get { return _employeeEmailId; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Employee EmailID can not be null");
                _employeeEmailId = value;
            }
        }


        public EmployeeDetails()
        {
            this._employeeId = 0;
            this._employeeFirstName = string.Empty;
            this._employeeMiddleName = string.Empty;
            this._employeeLastName = string.Empty;
            this._employeeFullName = _employeeFirstName + _employeeMiddleName + _employeeLastName;
            this._employeeDateOfBirth = DateTime.MinValue;
            this._employeeGender = string.Empty;
            this._employeeDepartmentId = 0;

            this._employeeDesignation = string.Empty;
            this.DateOfJoining = DateTime.MinValue;
            
            this._employeeManagerId = 0;
            this._isEmployeeOnPermanentPayroll = 'Y';
            this._employeePayScale = 0;
            this._employeeBaseSalary = 0;
            this._employeeQualifications = string.Empty;
            this._experienceOfWork = 0;
            this._employeePhoneNumber = string.Empty;
            this._employeeAddressLine1 = string.Empty;
            this._employeeAddressLine2 = string.Empty;
            this._employeeFullAddress = _employeeAddressLine1 + _employeeAddressLine2;
            this._employeeCity = string.Empty;
            this._employeeState = string.Empty;
            this._employeeCountry = string.Empty;
            this._employeeZipCode = string.Empty;
            this._employeeEmailId = string.Empty;
        }

        public EmployeeDetails(int employeeId, string employeeFName, string employeeMName, string employeeLName, DateTime dob, string gen, int empdeptId, string empdesignation, DateTime doj, string emptype, int empManagerId, char isPermPayroll, int empPayScale, decimal empBaseSal, string empQual, int empExpWork, string empPhoneNum, string empAddLine1, string empAddLine2, string empCity, string empState, string empCountry, string empZipCode, string empEmailId, int deptId, string deptCode, string deptName, string schCode, string schName, string schRegNum, DateTime estYear, string affBoard, string motto, string vision, string schDesc, string addLine1, string addLine2, string city, string state, string country, string zipCode, string emailID, string schURL, string schPhoneNum) : base(deptId, deptCode, deptName, schCode, schName, schRegNum, estYear, affBoard, motto, vision, schDesc, addLine1, addLine2, city, state, country, zipCode, emailID, schURL, schPhoneNum)
        {
            this._employeeId = employeeId;
            this._employeeFirstName = employeeFName;
            this._employeeMiddleName = employeeMName;
            this._employeeLastName = employeeLName;
            this._employeeFullName = _employeeFirstName + _employeeMiddleName + _employeeLastName;
            this._employeeDateOfBirth = dob;
            this._employeeGender = gen;
            this._employeeDepartmentId = empdeptId;

            this._employeeDesignation = empdesignation;
            this.DateOfJoining = doj;
            
            this._employeeManagerId = empManagerId;
            this._isEmployeeOnPermanentPayroll = isPermPayroll;
            this._employeePayScale = empPayScale;
            this._employeeBaseSalary = empBaseSal;
            this._employeeQualifications = empQual;
            this._experienceOfWork = empExpWork;
            this._employeePhoneNumber = empPhoneNum;
            this._employeeAddressLine1 = empAddLine1;
            this._employeeAddressLine2 = empAddLine2;
            this._employeeFullAddress = _employeeAddressLine1 + _employeeAddressLine2;
            this._employeeCity = empCity;
            this._employeeState = empState;
            this._employeeCountry = empCountry;
            this._employeeZipCode = empZipCode;
            this._employeeEmailId = empEmailId;



        }

        /*------------------------------- Organization details Methods ----------------------------------*/
        public override void getOrganizationDetails()
        {
            Console.WriteLine($"Organization details: School Code : {SchoolCode} School Name : {SchoolName} Registration Number : {RegistrationNumber} Establishment Year : {EstablishmentYear} Affiliation Board : {AffiliationBoard} Motto : {Motto} Vision : {Vision} Description : {Description} AddressLine1 : {AddressLine1} AddressLine2 : {AddressLine2} Full address : {FullAddress} City : {City} State : {SchoolState} Country : {Country} ZipCode : {ZipCode} EmailId : {EmailId} Website URL : {WebsiteURL} Phone Number : {SchoolPhoneNumber}");

        }

        public override void getOrganizationRelationshipDetails(string schoolCode,int empId)
        {
            Console.WriteLine($"Employee Id : {EmployeeRelationShipId} Department Name : {DepartmentName} Relationship Category Id: {SchoolRelationShipCategoryId} Relationship Category Name : {SchoolRelationShipCategoryName}");
        }

        /*------------------------------- Organization details Methods ----------------------------------*/



        /*------------------------------- Department details methods ------------------------------------*/
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
