using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.DbContexts
{
    public class GraphDbContext : IDbContext
    {
        public void Connect()
        {
            Console.WriteLine("graph database is connected");
        }

        public void DisConnect()
        {
            Console.WriteLine("graph database is disconnected");
        }
    }
}