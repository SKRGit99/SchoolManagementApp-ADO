using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Model
{
    public class SchoolDetails
    {
            public SchoolDetails() { }

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

            DateTime _establishmentYear;
            public DateTime EstablishmentYear
            {
                get { return _establishmentYear; }
                set
                {
                    _establishmentYear = value;
                }


            }

            char _isSchoolRegistered;
            protected char IsSchoolRegistered 
            {
                get { return _isSchoolRegistered; }
                set
                {
                    if ( (value != 'Y') && (value != 'N'))
                        throw new ArgumentException("Invalid Value. Please Enter Y/N.");
                    _isSchoolRegistered = value;
                }
            }

            string _registrationNumber = string.Empty;
            protected string RegistrationNumber
            {
                get { return _registrationNumber; }
                set
                {
                    _registrationNumber = value;
                }
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
            public string AffiliationBoard
            {
                get { return _affiliationBoard; }
                set
                {
                    _affiliationBoard = value;
                }
            }

            string _schoolPhoneNumber = string.Empty;
            public string SchoolPhoneNumber
            {

                get { return _schoolPhoneNumber; }
                set
                {
                    if ((value == null) || (value.ToString().Length < 10))
                        throw new ArgumentException("Phone Number can not be less than 10 characters or null.");
                    _schoolPhoneNumber = value;
                }
            }

            string _motto = string.Empty;
            public string Motto
            {
                get { return _motto; }
                set { _motto = value; }
            }

            string _vision = string.Empty;
            public string Vision
            {
                get { return _vision; }
                set { _vision = value; }
            }

            string _description = string.Empty;
            public string Description
            {
                get { return _description; }
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

            string _addressLine2 = string.Empty;
            public string AddressLine2
            {
                get { return _addressLine2; }
                set { _addressLine2 = value; }
            }

            string _city = string.Empty;
            public string City
            {
                get { return _city; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("City can not be null.");
                    _city = value;
                }
            }

            string _state = string.Empty;
            public string State
            {
                get { return _state; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("State can not be null.");
                    _state = value;
                }
            }

            string _country = string.Empty;
            public string Country
            {
                get { return _country; }
                set
                {
                    if (value == null)
                        throw new ArgumentNullException("Country can not be null.");
                    _country = value;
                }
            }

            string _zipCode = string.Empty;
            public string ZipCode
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

            string _schoolRelationShipCategoryName=string.Empty;
            internal string SchoolRelationShipCategoryName
            { 
                get { return _schoolRelationShipCategoryName; }

                set { _schoolRelationShipCategoryName = value; }
        
        
            }

            int _schoolRelationShipId;
            public int SchoolRelationShipId
            {
                get { return (int)_schoolRelationShipId; }
                set { _schoolRelationShipId = value; }
            }

            


    }



    
}
