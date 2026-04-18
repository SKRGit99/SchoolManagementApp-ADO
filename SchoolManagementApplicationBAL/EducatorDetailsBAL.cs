using SchoolManagementApplicationDAL.Abstract;
using SchoolManagementApplicationDAL.Model;
using SchoolManagementApplicationDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationBAL
{
    public class EducatorDetailsBAL
    {
        IEducatorDetails edudet = new EducatorDetailsRepo();
        public List<EducatorDetails> fetchEducatorDetails(int educatorid)
        {
            List<EducatorDetails> eduDetails = new List<EducatorDetails>();
            eduDetails = edudet.fetchEducatorDetails(educatorid);
            return eduDetails;
        }

        public List<EducatorDetailsForDropDown> fetchEducatorDetailsForDropDown(int educatorid)
        {
            List<EducatorDetailsForDropDown> lstEduDetDrpDwn = new List<EducatorDetailsForDropDown>();
            lstEduDetDrpDwn = edudet.getEducatorDetailsForDropDown(educatorid);
            return lstEduDetDrpDwn;
        }

        public List<EducatorDetails> fetchEducatorDetailsByRegistrationId(int educatorid)
        {
            List<EducatorDetails> eduDetRegId = new List<EducatorDetails>();
            eduDetRegId = edudet.getEducatorDetailsByRegistrationId(educatorid);
            return eduDetRegId;
        }


    }
}
