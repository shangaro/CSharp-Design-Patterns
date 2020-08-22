using OpenClosePrinciple.Models;
using System;
using System.Collections.Generic;

namespace OpenClosePrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Employee> employees = new List<Employee>();
            var persons = new List<IPerson>
            {
                new Person{FirstName="foo",LastName="bar"},
                new Manager{FirstName="holy",LastName="molly"},
                new Executive{FirstName="beck",LastName="hamster"}
            };

            persons.ForEach(person =>
            {
                var emp = person.Account.Create(person);
                employees.Add(emp);
                Console.WriteLine($"{ emp.FirstName} {emp.LastName} {emp.Email} isManager:{emp.IsManager} IsExecutive:{emp.IsExecutive}");

            });
        }
    }
}
