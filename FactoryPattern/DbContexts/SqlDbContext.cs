using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.DbContexts
{
    public class SqlDbContext : IDbContext
    {
        private readonly DbContextOptions _options;

        public SqlDbContext(DbContextOptions dbContextOptions)
        {
            _options = dbContextOptions;
        }

        public void Connect()
        {
            Console.WriteLine($"sql database is connected with {_options.ConnectionString}");
        }

        public void DisConnect()
        {
            Console.WriteLine($"sql database is disconnected with {_options.ConnectionString}");
        }
    }
}