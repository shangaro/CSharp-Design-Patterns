using OpenClosePrinciple.Accounts;

namespace OpenClosePrinciple.Models
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccount Account { get; set; } = new Account();
    }
}