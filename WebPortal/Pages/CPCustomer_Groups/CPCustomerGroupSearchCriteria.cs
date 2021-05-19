using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPortal.FormValidation;
using WebPortal.Models;

namespace WebPortal.Pages.CPCustomer_Groups
{

    public partial class CPCustomerGroupSearchCriteria

    {
        private CustomValidation customValidation;
        private ICPCustomerGroupSearchModel cpCustomerGroupSearchCriteria = new CPCustomerGroupSearchModel();
        [Parameter]
        public EventCallback<ICPCustomerGroupSearchModel> OnSearchSubmitted { get; set; }

        private void HandleValidSubmit()
        {
            customValidation.ClearErrors();
            var errors = new Dictionary<string, List<string>>();

            if (string.IsNullOrEmpty(cpCustomerGroupSearchCriteria.GroupIdFilter) &&
                string.IsNullOrEmpty(cpCustomerGroupSearchCriteria.NameFilter))
            {
                errors.Add(nameof(cpCustomerGroupSearchCriteria.GroupIdFilter),
                    new() { "Please enter a Group Id or Group Name for Searching" });
            }
            if (errors.Count() > 0)
            {
                customValidation.DisplayErrors(errors);
            }
            else
            {
                OnSearchSubmitted.InvokeAsync(cpCustomerGroupSearchCriteria);
            }
        }

    }


}
