using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortal.Models;

namespace WebPortal.Pages.CPCustomer_Groups
{
    public partial class CPCustomerGroupMaintenance
    {
        private ICPCustomerGroupModel cpCustomerGroup = new CPCustomerGroupDisplayModel();
    
        private void HandleValidSubmit()
        {
            cpCustomerGroupData.InsertCPCustomerGroup(cpCustomerGroup);
            // reset to a new object for next entry
            cpCustomerGroup = new CPCustomerGroupDisplayModel();
        }
    }
}
