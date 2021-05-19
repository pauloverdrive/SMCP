using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataService
{
    public interface ICPCustomerGroupDataService
    {
       public Task<List<ICPCustomerGroupModel>> GetCPCustomerGroups(ICPCustomerGroupSearchModel cpCustomerGroupSearchWords);
       public Task InsertCPCustomerGroup(ICPCustomerGroupModel cpCustomerGroup);
    }
}