using Xunit;
using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using FactoryPattern.DbContexts;

namespace PatternTests
{
    public class DbContextFactoryTests
    {
        private readonly Action<IDbContextOptionBuilder> action;
        private readonly DbContextFactory sut;

        public DbContextFactoryTests()
        {
            action = new Mock<Action<IDbContextOptionBuilder>>().Object;
            sut = new DbContextFactory();
        }

        [Fact()]
        public void CreateGraphTest()
        {
            var result = sut.CreateGraph(action);
            Assert.NotNull(result);
            Assert.IsType<GraphDbContext>(result);
        }

        [Fact()]
        public void CreateMongoTest()
        {
            var result = sut.CreateMongo(action);
            Assert.NotNull(result);
            Assert.IsType<MongoDbContext>(result);
        }

        [Fact()]
        public void CreateSqlTest()
        {
            var result = sut.CreateSql(action);
            Assert.NotNull(result);
            Assert.IsType<SqlDbContext>(result);
        }
    }
}