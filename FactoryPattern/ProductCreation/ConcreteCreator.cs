using System;

namespace FactoryPattern.ProductCreation
{
    internal class ConcreteCreator:Creator
    {
     
        internal override IProduct FactoryMethod(string type)
        {
            switch (type)
            {
                case "A": return new ProductA();
                case "B": return new ProductB();
                default: throw new ArgumentException("invalid type", type);
            }  
        }
    }
}
