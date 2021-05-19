namespace DataAccessLibrary.Models
{
    public interface ICPCustomerGroupSearchModel
    {
        string GroupIdFilter { get; set; }
        string NameFilter { get; set; }

    }
}