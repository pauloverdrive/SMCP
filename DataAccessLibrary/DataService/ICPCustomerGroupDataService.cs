using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataService
{
    public interface ICPCustomerGroupDataService
    {
       public Task<List<ICPCustomerGroupModel>> GetCPCustomerGroups(ICPCustomerGroupSearchModel cpCustomerGroupSearchWords);
        Task<ICPCustomerGroupModel> SelectCPCustomerGroup(string groupId);
        Task UpsertCPCustomerGroup(ICPCustomerGroupModel cpCustomerGroup);
    }
}