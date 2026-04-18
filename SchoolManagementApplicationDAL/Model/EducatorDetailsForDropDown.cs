using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementApplicationDAL.Model
{
    public class EducatorDetailsForDropDown
    {
        public EducatorDetailsForDropDown() { }
        
        int _educatorIdForDrpDwn;
        public int EducatorIdForDrpDwn
        {
            get { return _educatorIdForDrpDwn; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Educator Id can not be less than 0.");
                _educatorIdForDrpDwn = value;
            }
        }

        string _educatorFullNameForDrpDwn = string.Empty;
        public string EducatorFullNameForDrpDwn
        {
            get { return _educatorFullNameForDrpDwn; }
            set
            {
                _educatorFullNameForDrpDwn = value;
            }
        }
    }
}
