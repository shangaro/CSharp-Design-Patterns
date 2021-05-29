using FactoryPattern.DbContexts;

namespace FactoryPattern
{
    public interface IDbContextFactory
    {
        T Create<T>() where T : class;

        IDbContext CreateGraph();

        IDbContext CreateMongo();

        IDbContext CreateSql();
    }
}