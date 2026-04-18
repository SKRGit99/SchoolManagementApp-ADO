using SchoolManagementApplicationDAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Abstract
{
    public interface IEducatorDetails
    {
        public List<EducatorDetails> fetchEducatorDetails(int educatorid);

        List<EducatorDetailsForDropDown> getEducatorDetailsForDropDown(int educatorId);

        List<EducatorDetails> getEducatorDetailsByRegistrationId(int educatorId);
    }
}
