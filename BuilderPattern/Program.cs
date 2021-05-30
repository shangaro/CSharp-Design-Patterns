using BuilderPattern.ConcreteBuilders;
using System;

namespace BuilderPattern
{/// <summary>
/// Builder pattern is a creational pattern used to create complex objects with many configurations.
/// It reduces tedious newing up of object instance and makes code clean.
/// </summary>
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var builder = new ReportBuilder();
            builder.AddTitle().AddDescription()
                             .AddFooter();
            Console.Write(builder.ToString());
        }
    }
}