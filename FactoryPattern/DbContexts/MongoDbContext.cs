using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.DbContexts
{
    public class MongoDbContext : IDbContext
    {
        private readonly DbContextOptions _dbContextOptions;

        public MongoDbContext(DbContextOptions dbContextOptions)
        {
            _dbContextOptions = dbContextOptions;
        }

        public void Connect()
        {
            Console.WriteLine($"mongo database is connected with {_dbContextOptions.ConnectionString}");
        }

        public void DisConnect()
        {
            Console.WriteLine($"mongo database is disconnected with {_dbContextOptions.ConnectionString}");
        }
    }
}