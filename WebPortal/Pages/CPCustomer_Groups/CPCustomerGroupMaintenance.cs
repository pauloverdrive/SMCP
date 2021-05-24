using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
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

        private bool groupIdSet;
        [Parameter]
        public string GroupId { get; set; }
        public override async Task<ICPCustomerGroupModel> SetParametersAsync(ParameterView parameters)
        {
            groupIdSet = parameters.TryGetValue<string>(nameof(GroupId), out string value);

            if (groupIdSet)
            {

                var result = await cpCustomerGroupData.SelectCPCustomerGroup(value);
                cpCustomerGroup = (ICPCustomerGroupModel)result;
                this.StateHasChanged();
                return cpCustomerGroup;
            }
            else
            {
                this.StateHasChanged();
                cpCustomerGroup = new CPCustomerGroupDisplayModel();
                this.StateHasChanged();
                return cpCustomerGroup;
            }
        }
        private void HandleValidSubmit()
        {
            cpCustomerGroupData.UpsertCPCustomerGroup(cpCustomerGroup);
            // reset to a new object for next entry
            cpCustomerGroup = new CPCustomerGroupDisplayModel();
        }
    }
}
