using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.DbContexts
{
    public class SqlDbContext : IDbContext
    {
        public void Connect()
        {
            Console.WriteLine("sql database is connected");
        }

        public void DisConnect()
        {
            Console.WriteLine("sql database is disconnected");
        }
    }
}