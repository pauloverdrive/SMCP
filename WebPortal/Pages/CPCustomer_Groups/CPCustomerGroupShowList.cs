using DataAccessLibrary.DataService;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortal.Models;


namespace WebPortal.Pages.CPCustomer_Groups
{
    public partial class CPCustomerGroupShowList
    {

        private List<ICPCustomerGroupModel> cpCustomerGroups;

        protected override void OnParametersSet()
        {
            cpCustomerGroups = new List<ICPCustomerGroupModel>();

        }
        private async void HandleValidSubmit(ICPCustomerGroupSearchModel cpCustomerGroupSearchCriteria)
        {
            cpCustomerGroups = await cpCustomerGroupData.GetCPCustomerGroups(cpCustomerGroupSearchCriteria);
            this.StateHasChanged();
        }
        private void UpdateGroup(string groupId)
        {
            NavManager.NavigateTo("CPCustomerGroupMaintenance/"+groupId);
        }

    }


}
