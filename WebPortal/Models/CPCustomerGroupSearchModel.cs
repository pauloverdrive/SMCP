using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary.Models;


namespace WebPortal.Models
{
    public class CPCustomerGroupSearchModel : ICPCustomerGroupSearchModel
    {
        public string GroupIdFilter { get; set; }
        public string NameFilter { get; set; }
    }
}
