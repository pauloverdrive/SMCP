using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    class CPCustomerGroupModel : ICPCustomerGroupModel
    {
        public string GroupId{ get; set; }
        public string Name { get; set; }
    }
}
