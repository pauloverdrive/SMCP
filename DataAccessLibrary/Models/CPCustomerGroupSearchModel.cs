using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    class CPCustomerGroupSearchModel : ICPCustomerGroupSearchModel
    {
        public string GroupIdFilter { get; set; }
        public string NameFilter { get; set; }

    }
}
