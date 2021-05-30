using System;

namespace FactoryPattern
{
    public interface IDbContextOptionBuilder
    {
        IDbContextOptionBuilder AddConnectionString(string connString);

        IDbContextOptionBuilder EnableMemoryCache(bool val);

        IDbContextOptionBuilder SetTimeOut(TimeSpan time);

        DbContextOptions Build();

        IDbContextOptionBuilder AddDatabaseName(string dbName);
    }
}