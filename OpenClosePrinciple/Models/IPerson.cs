using OpenClosePrinciple.Accounts;

namespace OpenClosePrinciple.Models
{
    public interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccount Account { get; set; }
    }
}