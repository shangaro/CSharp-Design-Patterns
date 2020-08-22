using System;

namespace FactoryPattern.ProductCreation
{
    internal interface IProduct
    {
        DateTime Expiry { get; set; }
        string Name { get; set; }
    }
}