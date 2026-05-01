using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Model
{
    /*
       SuperAdminRepo : StudentRepo

       StudentRepo : DepartmentRepo
       
       DepartmentRepo : OrganizationRepo

       
       EducatorRepo : EmployeeRepo

       EmployeeRepo : DepartmentRepo



       StudentDetails : DepartmentDetails

       EducatorDetails : EmployeeDetails

       EmployeeDetails : DepartmentDetails

       DepartmentDetails : OrganizationDetails

   */
    public class EducatorDetails: EmployeeDetails
    {
        
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

        string _educatorName = string.Empty;
        public string EducatorName
        {
            get { return _educatorName; }
            set
            {
                _educatorName = value;
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

        string _educatorAddress = string.Empty;
        public string EducatorAddress
        {
            get { return _educatorAddress; }
            set
            {
                _educatorAddress = value;
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

        public EducatorDetails() 
        {
            this.EducatorId = 1;
            this.EducatorFirstName = "Kaushal";
            this.EducatorMiddleName = "";
            this.EducatorLastName = "Kumar";
            this.EducatorName = EducatorFirstName + EducatorMiddleName + EducatorLastName;
            this.EducatorDepartmentId = 1;
            this.EducatorDepartmentName = "Maths";
            this.EducatorClassesAssigned = "10,11,12";
            this.IsEducatorOnPermanentPayroll = 'Y';
            this.EducatorPayScale = 9;
            this.EducatorBaseSalary = Convert.ToDecimal(100000.00);
            this.EducatorPhoneNumber = "8709620330";
            this.EducatorAddressLine1 = "Jinpura";
            this.EducatorAddressLine2 = "Arwal, Patna";
            this.EducatorAddress = EducatorAddressLine1 + EducatorAddressLine2;
            this.EducatorCity = "Patna";
            this.EducatorState = "Bihar";
            this.EducatorCountry = "India";
            this.EducatorZipCode = "800040";
            this.EducatorEmailId = "kaushal@skr91.com";
        
        }

        public EducatorDetails(int eduId, string eduFName, string eduMName, string eduLName, int eduDeptId,string eduDeptName, string eduClsAssigend, char isEduPermPayroll, int eduPayScale, decimal eduBaseSalary, string eduPhoneNum, string eduAddLine1, string eduAddLine2, string eduCity, string eduState, string eduCountry, string eduZipCode, string eduEmailId,
                               int employeeId, string employeeFName, string employeeMName, string employeeLName, DateTime dob, string gen, int empdeptId, string empdesignation, DateTime doj, string emptype, int empManagerId, char isPermPayroll,int empPayScale, decimal empBaseSal, string empQual, int empExpWork, string empPhoneNum, string empAddLine1, string empAddLine2, string empCity, string empState, string empCountry, string empZipCode, string empEmailId, 
                               int deptId, string deptCode, string deptName, 
                               string schCode, string schName, string schRegNum, DateTime estYear, string affBoard, string motto, string vision, string schDesc, string addLine1, 
                               string addLine2, string city, string state, string country, string zipCode, string emailID, 
                               string schURL, string schPhoneNum) : base (employeeId, employeeFName, employeeMName, employeeLName, dob, gen, empdeptId, empdesignation, doj, emptype, empManagerId, isPermPayroll, empPayScale, empBaseSal, empQual, empExpWork, empPhoneNum, empAddLine1, empAddLine2, empCity, empState, empCountry, empZipCode, empEmailId, deptId, deptCode, deptName, schCode, schName, schRegNum, estYear, affBoard, motto, vision, schDesc, addLine1, addLine2, city, state, country, zipCode, emailID, schURL, schPhoneNum)
        {
            this.EducatorId = eduId;
            this.EducatorFirstName = eduFName;
            this.EducatorMiddleName = eduMName;
            this.EducatorLastName = eduLName;
            this.EducatorName = eduFName + eduMName + eduLName;
            this.EducatorDepartmentId = eduDeptId;
            this.EducatorDepartmentName = eduDeptName;
            this.EducatorClassesAssigned = eduClsAssigend;
            this.IsEducatorOnPermanentPayroll = isEduPermPayroll;
            this.EducatorPayScale = eduPayScale;
            this.EducatorBaseSalary = eduBaseSalary;
            this.EducatorPhoneNumber = eduPhoneNum;
            this.EducatorAddressLine1 = eduAddLine1;
            this.EducatorAddressLine2 = eduAddLine2;
            this.EducatorAddress = eduAddLine1 + eduAddLine2;
            this.EducatorCity = eduCity;
            this.EducatorState = eduState;
            this.EducatorCountry = eduCountry;
            this.EducatorZipCode = eduZipCode;
            this.EducatorEmailId = eduEmailId;

        }

        public override OrganizationDetails getOrganizationDetails()
        {
            OrganizationDetails lstOrg = new OrganizationDetails();

            return lstOrg;

        }

        /*
          static void Main(string[] args)
            {       
                
                EducatorDetails details = new EducatorDetails(1,"Santosh","Kumar","Babul",1,"Maths","10,11,12",'Y',9,Convert.ToDecimal(90000.00),"8709620330","Khagaria","Kainjari","Khagaria","Bihar","India","852161","santosh@skr91.com",
                                                              1, "Anupam","","Kumari", DateTime.Parse("1996-01-10"),"F",2,"Director", DateTime.Parse("2018-04-18"),"Admin",2,'Y',9,100000,"Graduate",10,"8123414499","Khagaria","Bihar","Khagaria","Bihar","India","852161","aupam@skr91.com", 
                                                              2, "PHY", "Physics",
                                                              "SKRPAT02", "SKR International School Patna", "SKRPATICSE", DateTime.Parse("2018-04-18"), "CBSE", "Education for All", "Education for India", "ICSE Affiliated School with AI Labs", "Vitthal VR Complex", "Saguna More Danapur", "Patna", "Bihar", "India", "800040", "info@skrschool.com", "www.skrschool.org", "8123414499");

                OrganizationDetails orgDet;        
                orgDet = new EducatorDetails();  
                orgDet.getOrganizationDetails();
                

                orgDet = new EmployeeDetails();
                orgDet.getOrganizationDetails();
                
                
                orgDet = new DepartmentDetails();
                orgDet.getOrganizationDetails();

                orgDet = new OrganizationDetails();
                orgDet.getOrganizationDetails();
                

                Console.ReadKey();
            }
         
         */
    }

}
