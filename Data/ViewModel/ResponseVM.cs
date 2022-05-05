using CustomerPro.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPro.Data.ViewModel
{

    [Serializable]
    public class ResponseVM
    {
        public int Cat_Id { get; set; }
        public string Cat_Name { get; set; }
        public List<SubjectVM> Subjects { get; set; }

    }
}
