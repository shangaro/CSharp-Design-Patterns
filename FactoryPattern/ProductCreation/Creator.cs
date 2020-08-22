namespace FactoryPattern.ProductCreation
{
    internal abstract class Creator
    {
        internal abstract IProduct FactoryMethod(string type);
        
    }
}
