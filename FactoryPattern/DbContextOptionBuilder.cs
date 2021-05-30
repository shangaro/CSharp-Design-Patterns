using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class DbContextOptionBuilder : IDbContextOptionBuilder
    {
        private DbContextOptions _options;

        public DbContextOptionBuilder()
        {
            Reset();
        }

        private void Reset()
        {
            _options = new DbContextOptions();
        }

        public IDbContextOptionBuilder AddConnectionString(string connString)
        {
            _options.ConnectionString = connString;
            return this;
        }

        public IDbContextOptionBuilder SetTimeOut(TimeSpan time)
        {
            _options.Timeout = time;
            return this;
        }

        public IDbContextOptionBuilder EnableMemoryCache(bool val)
        {
            _options.EnableMemoryCache = val;
            return this;
        }

        public IDbContextOptionBuilder AddDatabaseName(string dbName)
        {
            _options.DatabaseName = dbName;
            return this;
        }

        public DbContextOptions Build()
        {
            return _options;
        }
    }
}