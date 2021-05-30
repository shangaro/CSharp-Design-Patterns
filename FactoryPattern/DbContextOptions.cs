using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class DbContextOptions
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }
        public string DatabaseName { get; set; }
        public bool EnableMemoryCache { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as DbContextOptions;
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return ConnectionString == other.ConnectionString
                   && DatabaseName == other.DatabaseName
                   && Timeout == other.Timeout;
        }

        public override int GetHashCode() => HashCode.Combine(EnableMemoryCache);
    }
}