using FactoryPattern.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FactoryPattern
{
    public class DbContextFactory : IDbContextFactory
    {
        public IDbContextOptionBuilder builder = new DbContextOptionBuilder();

        public T Create<T>() where T : class
        {
            Type[] assemblyTypes = Assembly.GetExecutingAssembly().GetTypes();
            var filtered = assemblyTypes.Where(t => t.GetInterface(typeof(IDbContext).ToString()) != null);
            T dbContext = null;
            filtered.ForEach(t =>
            {
                if (t == typeof(MongoDbContext))
                {
                    var tup = Activator.CreateInstance<MongoDbContext>();
                    dbContext = tup as T;
                }
                else
                if (t == typeof(GraphDbContext))
                {
                    dbContext = Activator.CreateInstance<MongoDbContext>() as T;
                }
                else
                if (t == typeof(SqlDbContext))
                {
                    dbContext = Activator.CreateInstance<MongoDbContext>() as T;
                }
            });
            return dbContext;
        }

        public IDbContext CreateGraph(Action<IDbContextOptionBuilder> action)
        {
            action?.Invoke(builder);
            var dbContextOptions = builder.Build();
            return new GraphDbContext(dbContextOptions);
        }

        public IDbContext CreateMongo(Action<IDbContextOptionBuilder> action)
        {
            action?.Invoke(builder);
            var dbContextOptions = builder.Build();
            return new MongoDbContext(dbContextOptions);
        }

        public IDbContext CreateSql(Action<IDbContextOptionBuilder> action)
        {
            action?.Invoke(builder);
            var dbContextOptions = builder.Build();
            return new SqlDbContext(dbContextOptions);
        }
    }
}