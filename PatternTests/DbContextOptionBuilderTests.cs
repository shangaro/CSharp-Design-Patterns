using Xunit;
using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternTests
{
    [Trait("Category", "Unit")]
    public class DbContextOptionBuilderTests
    {
        private IDbContextOptionBuilder sut = new DbContextOptionBuilder();

        [Fact()]
        public void AddConnectionStringTest()
        {
            const string expected = "connString";
            var dbOption = sut.AddConnectionString("connString").Build();
            Assert.Equal(expected, dbOption.ConnectionString);
        }

        [Fact()]
        public void SetTimeOutTest()
        {
            TimeSpan expected = TimeSpan.Zero;
            var dbOption = sut.SetTimeOut(expected).Build();
            Assert.Equal(expected, dbOption.Timeout);
        }

        [Fact()]
        public void EnableMemoryCacheTest()
        {
            const bool expected = false;
            var dbOption = sut.EnableMemoryCache(expected).Build();
            Assert.Equal(expected, dbOption.EnableMemoryCache);
        }

        [Fact()]
        public void AddDatabaseNameTest()
        {
            const string expected = "dbName";
            var dbOption = sut.AddDatabaseName(expected).Build();
            Assert.Equal(expected, dbOption.DatabaseName);
        }

        [Fact()]
        public void BuildTest()
        {
            var expected = new DbContextOptions();
            var dbOption = sut.Build();
            Assert.Equal(expected, dbOption);
        }
    }
}