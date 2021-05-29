namespace FactoryPattern.DbContexts
{
    public class NullContext : IDbContext
    {
        public void Connect()
        {
        }

        public void DisConnect()
        {
        }
    }
}