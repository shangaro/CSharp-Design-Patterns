using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FactoryPattern
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            IDbContextFactory dbContextFactory = new DbContextFactory();
            var context = dbContextFactory.CreateSql(opt =>
            {
                opt.AddConnectionString("sqlConn")
                    .EnableMemoryCache(true)
                    .SetTimeOut(new TimeSpan(3400));
            });
            context.Connect();
        }
    }
}