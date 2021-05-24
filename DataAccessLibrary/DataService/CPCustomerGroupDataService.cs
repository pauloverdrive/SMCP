using DataAccessLibrary.DataAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.DataService
{
    public class CPCustomerGroupDataService : ICPCustomerGroupDataService
    {
        private readonly ISqlDataAccess _dataAccess;

        private string groupIdFilter;
        private string nameFilter;
        public CPCustomerGroupDataService(ISqlDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public async Task UpsertCPCustomerGroup(ICPCustomerGroupModel cpCustomerGroup)
        {
            // p is parameters for the stored procedure
            var p = new
            {
                cpCustomerGroup.GroupId,
                cpCustomerGroup.Name
            };
            await _dataAccess.SaveData("dbo.spCPCustomerGroup_Upsert", p, "SMCPSqlDBConnection");

        }
        public async Task<ICPCustomerGroupModel> SelectCPCustomerGroup(string groupId)
        {
            // p is parameters for the stored procedure
            var p = new
            {
                groupId
            };
            var cpCustomerGroups = await _dataAccess.LoadData<CPCustomerGroupModel, dynamic>("dbo.spCPCustomerGroup_SelectByGroupId", p, "SMCPSqlDBConnection");
            return cpCustomerGroups.FirstOrDefault();         }

        public async Task<List<ICPCustomerGroupModel>> GetCPCustomerGroups(ICPCustomerGroupSearchModel cpCustomerGroupSearchWords)
        {

            groupIdFilter = cpCustomerGroupSearchWords.GroupIdFilter;
            nameFilter = cpCustomerGroupSearchWords.NameFilter;
            // pass in % (wild card) if they did not enter anything to search on in this field 
            if (string.IsNullOrEmpty(groupIdFilter))
            {
                groupIdFilter = "%";
            }
            else
            {
                groupIdFilter = "%" + groupIdFilter + "%";

            }
            if (string.IsNullOrEmpty(nameFilter))
            {
                nameFilter = "%";
            }
            else
            {
                nameFilter = "%" + nameFilter + "%";

            }
            // p is parameters for the stored procedure - pass in the search words

            var p = new
            {
                groupIdFilter,
                nameFilter
            };

            var cpCustomerGroups = await _dataAccess.LoadData<CPCustomerGroupModel, dynamic>("dbo.spCPCustomerGroup_NameSearch", p, "SMCPSqlDBConnection");
            return cpCustomerGroups.ToList<ICPCustomerGroupModel>();
        }
    }
}
