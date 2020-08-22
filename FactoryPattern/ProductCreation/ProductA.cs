using System;

namespace FactoryPattern.ProductCreation
{
    internal class ProductA : IProduct
    {
        public string Name { get; set; } = "A";
        public DateTime Expiry { get; set; }
    }
}
