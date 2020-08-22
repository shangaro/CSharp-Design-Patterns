using OpenClosePrinciple.Models;

namespace OpenClosePrinciple.Accounts
{
    public interface IAccount
    {
        Employee Create(IPerson person);
    }
}