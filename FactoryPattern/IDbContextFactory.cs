using FactoryPattern.DbContexts;
using System;

namespace FactoryPattern
{
    public interface IDbContextFactory
    {
        IDbContext CreateGraph(Action<IDbContextOptionBuilder> action);

        IDbContext CreateMongo(Action<IDbContextOptionBuilder> action);

        IDbContext CreateSql(Action<IDbContextOptionBuilder> action);
    }
}