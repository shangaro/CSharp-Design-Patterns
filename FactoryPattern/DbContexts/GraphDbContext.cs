using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.DbContexts
{
    public class GraphDbContext : IDbContext
    {
        private readonly DbContextOptions _options;

        public GraphDbContext(DbContextOptions options)
        {
            _options = options;
        }

        public void Connect()
        {
            Console.WriteLine($"graph database is connected with{_options.ConnectionString}");
        }

        public void DisConnect()
        {
            Console.WriteLine($"graph database is disconnect with{_options.ConnectionString}");
        }
    }
}