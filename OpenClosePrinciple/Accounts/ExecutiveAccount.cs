using OpenClosePrinciple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple.Accounts
{
    public class ExecutiveAccount : IAccount
    {
        public Employee Create(IPerson person)
        {
            return new Employee
            {
                FirstName = person.FirstName,
                LastName = person.LastName,
                Email = $"{person.FirstName.Substring(0, 1)}{person.LastName}@acme.com",
                IsExecutive=true
            };
        }
    }
}
