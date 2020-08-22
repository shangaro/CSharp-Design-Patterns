using System;

namespace FactoryPattern.ProductCreation
{
    internal class ProductB : IProduct
    {
        public string Name { get; set; } = "B";
        public DateTime Expiry { get; set; }
    }
}