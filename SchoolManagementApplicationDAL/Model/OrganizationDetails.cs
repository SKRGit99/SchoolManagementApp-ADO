using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Model
{
    public class OrganizationDetails
    {
        /*------------------------------------------ Organization details ---------------------------------------------*/

            string _schoolCode = string.Empty;
            protected string SchoolCode
            {
                get { return _schoolCode; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("School Code can not be null.");
                    _schoolCode = value;
                }
            }

            string _schoolName = string.Empty;
            public string SchoolName
            {
                get { return _schoolName; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("School Name can not be null.");
                    _schoolName = value;
                }
            }


            DateTime _establishmentYear = DateTime.MinValue;
            public DateTime EstablishmentYear
            {
                get { return _establishmentYear; }
                set { _establishmentYear = value; }
            }

            char _isSchoolRegistered;
            protected char IsSchoolRegistered
            {
                get { return _isSchoolRegistered; }
                set
                {
                    if ((value != 'Y') && (value != 'N'))
                        throw new ArgumentException("Invalid Value. Please Enter Y/N.");
                    _isSchoolRegistered = value;
                }
            }


            string _registrationNumber = string.Empty;
            protected string RegistrationNumber
            {
                get { return _registrationNumber; }
                set { _registrationNumber = value; }
            }

            char _isSchoolAffiliated;
            protected char IsSchoolAffiliated
            {
                get { return _isSchoolAffiliated; }
                set
                {
                    if ((value != 'Y') && (value != 'N'))
                        throw new ArgumentException("Invalid Value. Please Enter Y/N.");
                    _isSchoolAffiliated = value;
                }
            }

            string _affiliationBoard = string.Empty;
            public String AffiliationBoard
            {
                get { return _affiliationBoard; }
                set { _affiliationBoard = value; }
            }

            string? _motto;
            public string Motto
            {
                get { return _motto ?? string.Empty; }
                set { _motto = value; }
            }

            string? _vision;
            public string Vision
            {
                get { return _vision ?? string.Empty; }
                set { _vision = value; }
            }

            string? _description;
            public string Description
            {
                get { return _description ?? string.Empty; }
                set { _description = value; }
            }

            string _addressLine1 = string.Empty;
            public string AddressLine1
            {
                get { return _addressLine1; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("AddressLine1 can not be null.");
                    _addressLine1 = value;
                }
            }

            string? _addressLine2;
            protected string AddressLine2
            {
                get { return _addressLine2 ?? string.Empty; }
                set { _addressLine2 = value; }
            }

            string _fullAddress = string.Empty;
            public string FullAddress
            {
                get { return _fullAddress; }
                set { _fullAddress = value; }
            }

            string _city = string.Empty;
            public String City
            {
                get { return _city; }
                set { _city = value; }
            }

            string _schoolState = string.Empty;
            public string SchoolState
        {
                get { return _schoolState; }
                set { _schoolState = value; }
            }

            string _country = string.Empty;
            public string Country
            {
                get { return _country; }
                set { _country = value; }
            }

            string _zipCode = string.Empty;
            public String ZipCode
            {
                get { return _zipCode; }
                set { _zipCode = value; }
            }

            string _emailId = string.Empty;
            public string EmailId
            {
                get { return _emailId; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("Email can not be null.");
                    _emailId = value;

                }
            }

            string _websiteURL = string.Empty;
            public string WebsiteURL
            {
                get { return _websiteURL; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("WebsiteURL can not be null.");
                    _websiteURL = value;
                }
            }

            string _schoolPhoneNumber = string.Empty;
            public string SchoolPhoneNumber
            {
                get { return _schoolPhoneNumber; }
                set { _schoolPhoneNumber = value; }
            }


        /*--------------------------------- Organization details -----------------------------------------------------*/


        /*--------------------------------- Organization - Individual relationship details -----------------------------



        _schoolRelationShipId = > This establishes relationship of an Individual with the Organization.
        
                                    Example: EmployeeId for employees like EducatorId or StudentId
         
         
         */
        
            int _employeeRelationShipId;            
            public int EmployeeRelationShipId
            {
                get { return (int)_employeeRelationShipId; }
                set { _employeeRelationShipId = value; }
            }

            int _studentRelationShipId;
            public int StudentRelationShipId
            {
                get { return (int)_studentRelationShipId; }
                set { _studentRelationShipId = value; }
            }

            int _schoolRelationShipCategoryId;
            internal int SchoolRelationShipCategoryId
            {
                get { return _schoolRelationShipCategoryId; }
                set
                {
                    if (value < 0)

                        throw new ArgumentException("School Id can not be less than 0.");
                    _schoolRelationShipCategoryId = value;
                }
            }

            string _schoolRelationShipCategoryName = string.Empty;
            internal string SchoolRelationShipCategoryName
            {
                get { return _schoolRelationShipCategoryName; }

                set { _schoolRelationShipCategoryName = value; }


            }

            int _schoolDepartmentId;        //Department of the Related Individual
            public int SchoolDepartmentId
            {
                get { return (int)_schoolDepartmentId; }
                set
                {
                    if (value < 0) throw new ArgumentException("DepartmentId can not be less than 0");
                    _schoolDepartmentId = value;

                }
            }

        /*--------------------------------- Organization - Individual relationship details ----------------------------------*/

            public OrganizationDetails()
            {
                this._schoolCode = "SKRPAT01";
                this._schoolName = "SKR International School";
                this._establishmentYear = DateTime.Parse("2018-03-18");
                this.IsSchoolRegistered = 'Y';
                this._registrationNumber = "SKRPATCBSE";
                this.IsSchoolAffiliated = 'Y';
                this._affiliationBoard = "CBSE";
                this._motto = "Education for everyone";
                this._vision = "Education for Bihar";
                this._description = "CBSE Affiliated School with AI Labs";
                this._addressLine1 = "Saguna More";
                this._addressLine2 = "Danapur";
                this._fullAddress = _addressLine1 + _addressLine2;
                this._city = "Patna";
                this._schoolState = "Bihar";
                this._country = "India";
                this._zipCode = "800020";
                this._emailId = "contact@skrschool.com";
                this._websiteURL = "www.skrschool.com";
                this._schoolPhoneNumber = "8123414488";

            }
            public OrganizationDetails(string schCode, string schName, string schRegNum, DateTime estYear, string affBoard, string motto, string vision, string schDesc, string addLine1, string addLine2, string city, string state, string country, string zipCode, string emailID, string schURL, string schPhoneNum)
            {
                this._schoolCode = schCode;
                this._schoolName = schName;
                this._registrationNumber = schRegNum;
                this._establishmentYear = estYear;
                this._affiliationBoard = affBoard;
                this._motto = motto;
                this._vision = vision;
                this._description = schDesc;
                this._addressLine1 = addLine1;
                this._addressLine2 = addLine2;
                this._city = city;
                this._schoolState = state;
                this._country = country;
                this._zipCode = zipCode;
                this._emailId = emailID;
                this._websiteURL = schURL;
                this._schoolPhoneNumber = schPhoneNum;


            }

         
            public virtual List<OrganizationDetails> getOrganizationDetails()
            {
                List<OrganizationDetails> lstOrg = new List<OrganizationDetails>();
                return lstOrg;
                //Console.WriteLine($"Organization details: School Code : {_schoolCode} School Name : {_schoolName} Registration Number : {_registrationNumber} Establishment Year : {_establishmentYear} Affiliation Board : {_affiliationBoard} Motto : {_motto} Vision : {_vision} Description : {_description} AddressLine1 : {_addressLine1} AddressLine2 : {_addressLine2} Full Address : {_fullAddress} City : {_city} State : {_schoolState} Country : {_country} ZipCode : {_zipCode} EmailId : {_emailId} Website URL : {_websiteURL} Phone Number : {_schoolPhoneNumber}");
            
            }

            public virtual void getOrganizationRelationshipDetails(string schoolCode, int empId)
            {
                Console.WriteLine($"Relationship Id : {_employeeRelationShipId} Relationship Category Id: {_schoolRelationShipCategoryId} Relationship Category Name : {_schoolRelationShipCategoryName} Relationship-Department Name :{_schoolDepartmentId} ");
            }

            public virtual void getOrganizationRelationshipDetails(int studentId, string schoolCode)
            {
                Console.WriteLine($"Relationship Id : {_studentRelationShipId} Relationship Category Id: {_schoolRelationShipCategoryId} Relationship Category Name : {_schoolRelationShipCategoryName} Relationship-Department Name :{_schoolDepartmentId} ");
            }



    }
    
}
