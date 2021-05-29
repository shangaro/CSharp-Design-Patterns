using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.DbContexts
{
    public class MongoDbContext : IDbContext
    {
        public void Connect()
        {
            Console.WriteLine("mongo database is connected");
        }

        public void DisConnect()
        {
            Console.WriteLine("mongo database is disconnected");
        }
    }
}