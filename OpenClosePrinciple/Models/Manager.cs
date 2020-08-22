using OpenClosePrinciple.Accounts;
using OpenClosePrinciple.Models;

namespace OpenClosePrinciple
{
    public class Manager : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccount Account { get; set; } = new ManagerAccount();
    }
}